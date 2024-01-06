using Microsoft.AspNetCore.Mvc;
using DomainObject.DomainObject.Web;
using BusinessLogicLayer.Service.Implement;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailServerController : ControllerBase
    {
        #region Properties
        private MailService mailService { get; set; } = new MailService();

        #endregion

        public void Regist(ReceiveObject recvObj)
        {
            mailService.SendValidationMail(recvObj);
        }
    }
}
