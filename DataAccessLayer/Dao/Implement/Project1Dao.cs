using DataAccessLayer.Dao.Interface;
using System.Data;

namespace DataAccessLayer.Dao.Implement
{
    public class Project1Dao : IProject1Dao
    {
        public DataTable GetUserData(string id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Rows.Add(new object[] { id });
            dt.Rows.Add(new object[] { $"{id}new" });

            return dt;
        }
    }
}
