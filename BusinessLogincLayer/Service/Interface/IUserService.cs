using DomainObject.DomainObject.DefinedDomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service.Interface
{
    public interface IUserService
    {
        public string Create(UsersRegist user);
    }
}
