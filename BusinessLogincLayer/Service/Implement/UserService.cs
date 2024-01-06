using BusinessLogicLayer.Service.Interface;
using CMDomainObject.DomainObject.DefinedDomainObject.Authentication;
using CMUtility;
using DataAccessLayer.Dao.Implement;
using DomainObject.DomainObject.DefinedDomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service.Implement
{
    public partial class UserService : IUserService
    {
        SqlCommonHelper sqlHelper = new SqlCommonHelper();
        UserDao userDao = new UserDao();
        public string Create(UsersRegist user)
        {
            List<MySqlParam> lst = new List<MySqlParam>();
            string uid = SerialNumber.GetRandomString(30);
            user.UID = uid;
            lst.AddRange(userDao.Create(user));

            if (sqlHelper.InsertUpdateQuery(lst) > 0)
            {
                return uid;
            }

            return string.Empty;
        }
    }
}
