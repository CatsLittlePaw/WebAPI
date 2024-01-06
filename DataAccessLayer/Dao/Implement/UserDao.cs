using CMUtility;
using DataAccessLayer.Dao.Interface;
using DomainObject.DomainObject.DefinedDomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer.Dao.Implement
{
    public partial class UserDao : IUserDao
    {
        public List<MySqlParam> Create(UsersRegist user)
        {
            List<MySqlParam> lst = new List<MySqlParam>();
            MySqlParam userParam = new MySqlParam(user);
            userParam.sql = "INSERT INTO [USERS] (UID, ACCOUNT, P455WORD, PRIVATE_KEY, PUBLIC_KEY, STATUS, CRT_DATETIME, UPD_DATETIME) VALUES(@UID, @ACCOUNT, @P455WORD, @PRIVATE_KEY, @PUBLIC_KEY, @STATUS, GETDATE(), GETDATE()); ";
            userParam.SqlParameter.Add(new SqlParameter("@STATUS", "0"));
            userParam.SqlParameter.Add(new SqlParameter("@PRIVATE_KEY", "0"));
            userParam.SqlParameter.Add(new SqlParameter("@PUBLIC_KEY", "0"));

            lst.Add(userParam);

            return lst;
        }
    }
}
