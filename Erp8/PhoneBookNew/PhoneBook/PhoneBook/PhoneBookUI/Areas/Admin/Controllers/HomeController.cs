using Microsoft.AspNetCore.Mvc;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookUI.Areas.Admin.Models;

namespace PhoneBookUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Route("a/[Controller]/[Action]/{id?}")] bu route verildiğinde [action] yazan yere action'ın tam adını yazmadan sayfa açılmaz
    //[Route("a/h/")] //bu route verildiğinde controller'a nasıl ulaştığı belirtilir
    //ve action'a ulaşılma konusundaki kuralı action üzerine yazılan kural belirler.

    [Route("admin")]
    public class HomeController : Controller
    {
        private readonly IMemberManager _memberManager;
        private readonly IPhoneTypeManager _phoneTypeManager;
        private readonly IMemberPhoneManager _memberPhoneManager;
        public HomeController(IMemberManager memberManager, IPhoneTypeManager phoneTypeManager, IMemberPhoneManager memberPhoneManager)
        {
            _memberManager = memberManager;
            _phoneTypeManager = phoneTypeManager;
            _memberPhoneManager = memberPhoneManager;
        }

        [HttpGet]
        //[Route("d")]
        [Route("dsh")] //Action'un ismi çok uzun olabilir url'e action'ın isminin hepsini yazmak istemezsek action'a Route verebiliriz.
        public IActionResult Dashboard()
        {
            //Bu ay sisteme kayıt olan üye sayısı
            DateTime thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            ViewBag.MonthlyMemberCount = _memberManager.GetAll(x => x.CreatedDate > thisMonth.AddDays(-1)).Data.Count();

            //bu ay sisteme eklenen numara sayısı
            ViewBag.MonthlyContactCount = _memberPhoneManager.GetAll(x => x.CreatedDate > thisMonth.AddDays(-1)).Data.Count();

            var members = _memberManager.GetAll().Data.OrderBy(x => x.CreatedDate);
            //en son eklenen üyenin adı soyadı
            ViewBag.LastMember = $"{members.LastOrDefault()?.Name} {members.LastOrDefault()?.Surname}";

            //Rehbere en son eklenen kişinin adı soyadı
            var contacts = _memberPhoneManager.GetAll().Data.OrderBy(x=>x.CreatedDate);

            ViewBag.LastContact = contacts.LastOrDefault()?.FriendNameSurname;
            return View();
        }

        [Route("/admin/GetPhoneTypePieData")] //buradaki  admin controller'ın route'ı
        public JsonResult GetPhoneTypePieData()
        {
            try
            {
                Dictionary<string, int> model = new Dictionary<string, int>();
                var data = _memberPhoneManager.GetAll().Data;
                foreach (var item in data)
                {
                    if (model.ContainsKey(item.PhoneType.Name)) // wissen kurs tipinden var mı ?
                    {
                        //sayısı 1 arttırsın
                        model[item.PhoneType.Name] += 1;
                    }
                    else
                    {
                        model.Add(item.PhoneType.Name, 1);
                    }


                } //foreach bitti
                

                return Json(new
                {
                    isSuccess = true,
                    message = "Veriler geldi",
                    types = model.Keys.ToArray(), //bir gönder bakalım
                    points = model.Values.ToArray()
                }) ;
            }
            catch (Exception ex)
            {
                return Json(new { isSuccess = false, message = "Veriler getirilemedi!" });

            }
        }

        [HttpGet]
        [Route("m")]
        public IActionResult MemberIndex()
        {
            try
            {
                var data = _memberManager.GetAll().Data;
                return View(data);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Beklenmedik hata oldu!" + ex.Message);
                return View();
            }
        }

    }
}

