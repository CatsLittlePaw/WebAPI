using CMDomainObject.DomainObject.DefinedDomainObject.Authentication;
using CMUtility;
using DomainObject.DomainObject.DefinedDomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dao.Interface
{
    public interface IUserDao
    {
        public List<MySqlParam> Create(UsersRegist user);
    }
}
