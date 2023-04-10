using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookDataLayer.ImplementationsOfRepo;

namespace PhoneBookDataLayer.ImplementationsOfRepo
{
    public class PhoneTypeRepository : Repository<PhoneType, byte>, IPhoneTypeRepository
    {
        public PhoneTypeRepository(MyContext context) : base(context)
        {
        }
    }
}