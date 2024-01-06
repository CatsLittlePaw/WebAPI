using DataAccessLayer.Dao.Interface;
using BusinessLogicLayer.Service.Interface;
using DataAccessLayer.Dao.Implement;
using System.Data;

namespace BusinessLogicLayer.Service.Implement
{
    public partial class Project1Service : IProject1Service
    {

        #region Properties
        public IProject1Dao project1Dao { get; set; } = new Project1Dao();

        #endregion


        public DataTable GetUserData(string id)
        {
            return project1Dao.GetUserData(id);
        }
    }
}
