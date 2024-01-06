using Microsoft.AspNetCore.Mvc;
using BusinessLogicLayer.Service.Implement;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Project1Controller : ControllerBase
    {
        #region Properties

        private Project1Service project1Service { get; set; } = new Project1Service();    
        
        #endregion

        [HttpPost]
        [Route("[action]")]
        public string GetUserData(string id)
        {
            string jsonData = JsonConvert.SerializeObject(project1Service.GetUserData(id));
            return jsonData;
        }

        [HttpGet]
        public string GetTest()
        {
            string jsonData = "你呼叫的是Default的Get方法";
            return jsonData;
        }

        [HttpGet]
        [Route("[action]")]
        public string GetTest2()
        {
            string jsonData = "呼叫GetTest2成功";
            return jsonData;
        }

        [HttpGet]
        [Route("[action]")]
        public string GetTest3()
        {
            string jsonData = "呼叫GetTest3成功";
            return jsonData;
        }
    }
}
