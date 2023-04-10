using AutoMapper;
using AutoMapper.Execution;
using PhoneBookEntityLayer.Entities;
using PhoneBookEntityLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookEntityLayer.Mappings
{
    public class Maps:Profile
    {
        //Kim Kime dönüşsün?
        public Maps()
        {
            CreateMap<Entities.Member, MemberViewModel>();
            CreateMap<MemberViewModel, Entities.Member>();

            CreateMap<PhoneType, PhoneTypeViewModel>().ReverseMap(); //tersine otomatik döndürür
            CreateMap<MemberPhone, MemberPhoneViewModel>().ReverseMap();
        }
    }
}
