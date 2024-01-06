using CMLogHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class BaseService
    {
        #region Properties

        /// <summary>
        /// 紀錄Log
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public static LogController LogController
        {
            get
            {
                return new LogController();
            }
        }

        #endregion
    }
}
