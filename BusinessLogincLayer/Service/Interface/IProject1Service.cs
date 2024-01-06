using BusinessLogicLayer.Service.Implement;
using System.Data;

namespace BusinessLogicLayer.Service.Interface
{
    public interface IProject1Service
    {
        DataTable GetUserData(string id);
    }
}
