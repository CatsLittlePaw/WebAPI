using BusinessLogicLayer.Service.Implement;
using BusinessLogicLayer.Service.Interface;
using DomainObject.DomainObject.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public string EmailValidation(string id)
        {
            string jsonData = JsonConvert.SerializeObject(project1Service.GetUserData(id));
            return jsonData;
        }


        [HttpPost]
        [Route("[action]")]
        public string SendValidateMail(string id)
        {
            string jsonData = JsonConvert.SerializeObject(project1Service.GetUserData(id));
            return jsonData;
        }
    }
}
