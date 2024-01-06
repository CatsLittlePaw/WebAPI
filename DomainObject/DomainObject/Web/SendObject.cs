using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObject.DomainObject.LogHandler;

namespace DomainObject.DomainObject.Web
{
    public class SendObject
    {
        /// <summary>
        /// Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 目前所在頁面
        /// </summary>
        public string CurrentPath { get; set; }

        /// <summary>
        /// 功能ID
        /// </summary>
        public string FunctionId { get; set; }

        /// <summary>
        /// 傳入參數
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        /// LOG訊息物件
        /// </summary>
        public LogInfoObject LogInfoObject { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// 時區
        /// </summary>
        public string Timezone { get; set; }
    }
}
