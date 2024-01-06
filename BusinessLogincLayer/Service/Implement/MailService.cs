using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Service.Interface;
using Newtonsoft.Json;
using DomainObject.DomainObject.Web;
using DomainObject.DomainObject.DefinedDomainObject;
using System.Configuration;
using CMUtility;
using DataAccessLayer.Dao.Implement;

namespace BusinessLogicLayer.Service.Implement
{
    public partial class MailService : IMailService
    {
        SqlCommonHelper sqlHelper= new SqlCommonHelper();
        UserService userService = new UserService();

        public SendObject SendValidationMail(ReceiveObject recvObj)
        {
             UsersRegist userData = JsonConvert.DeserializeObject<UsersRegist>(recvObj.Parameters.ToString());

            // 使用 Google Mail Server 發信
            string? GoogleID = ConfigurationManager.AppSettings["SMTP_ID"]?.ToString(); //Google 發信帳號
            string? TempPwd = ConfigurationManager.AppSettings["SMTP_P4D"]?.ToString(); ; // 應用程式密碼
            string? ReceiveMail = userData.EMAIL; //接收信箱
            string SmtpServer = "smtp.gmail.com";
            int SmtpPort = 587;

            // 修改並寫入serialNumber、回傳serialNumber
            userData.SERIAL_NUMBER = SerialNumber.GetRandomString(18);
            string serialNumber = userService.Create(userData);

            string url = $"{ConfigurationManager.AppSettings["apiUrl"]?.ToString()}/Validation/EmailValidation?id={serialNumber}";

            MailMessage mms = new MailMessage();
            mms.From = new MailAddress(GoogleID);
            mms.Subject = "Project1驗證信";
            mms.Body = $"請點選網址完成驗證:<br \\> {url}";
            mms.IsBodyHtml = true;
            mms.SubjectEncoding = Encoding.UTF8;
            mms.To.Add(new MailAddress(ReceiveMail));
            using (SmtpClient client = new SmtpClient(SmtpServer, SmtpPort))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(GoogleID, TempPwd);//寄信帳密 
                client.Send(mms); //寄出信件
            }

            SendObject returnObj = new SendObject();
            return returnObj;
        }
    }
}
