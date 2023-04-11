using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PhoneBookBusinessLayer.EmailSenderBusiness;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookUI.Models;

namespace PhoneBookUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMemberManager _memberManager;
        private readonly IEmailSender _emailSender;

        public AccountController(IMemberManager memberManager, IEmailSender emailSender)
        {
            _memberManager = memberManager;
            _emailSender = emailSender;
        }

        public IActionResult Register()
        {
            //Bu metot sayfayı sadece getirir. HTTPGET
            return View();  //bu metot geriye bir sayfa gönderecek
        }

        [HttpPost] //sayfadaki submit türündeki butona tıkladığımda yazdığı bilgilerle bu metoda düşecektir
        public IActionResult Register(RegisterViewModel model)
        {
            try
            {
                if (!ModelState.IsValid) //gelen bilgiler class içindeki annotationslara uygun değilse
                {
                    ModelState.AddModelError("", "Gerekli alanları lütfen doldurunuz!");
                    return View(model);
                }//Ekleme işlemleri yapılacak

                return View(); //ÇAkma
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Beklenmedik bir sorun oluştu!" + ex.Message); //ex loglanmalı biz şimdi geçici olarak yazdık
                return View(model);//burada return View(model) parametre olarak model vermemizin sebebi sayfadaki bilgiler silinmesin.
            }
        }

    }
}
