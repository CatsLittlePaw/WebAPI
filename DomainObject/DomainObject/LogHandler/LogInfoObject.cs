namespace DomainObject.DomainObject.LogHandler
{
    /// <summary>
    /// LOG類別
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// Print
        /// </summary>
        Print = 0,
        /// <summary>
        /// Export
        /// </summary>
        Export = 1,
        /// <summary>
        /// Insert
        /// </summary>
        Insert = 2,
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 3,
        /// <summary>
        /// Update
        /// </summary>
        Update = 4,
        /// <summary>
        /// Query
        /// </summary>
        Query = 5,
        /// <summary>
        /// SYS
        /// </summary>
        SYS = 998,
        /// <summary>
        /// ERROR
        /// </summary>
        ERROR = 999
    }

    /// <summary>
    /// 定義LOG相關資訊
    /// </summary>
    public class LogInfoObject
    {
        /// <summary>
        /// 使用者ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 使用者IP
        /// </summary>
        public string UserIP { get; set; }

        /// <summary>
        /// 目前功能ID
        /// </summary>
        public string FunctionList { get; set; }

        /// <summary>
        /// 目前功能列(麵包屑)
        /// </summary>
        public string FunctionBRC { get; set; }

        /// <summary>
        /// 目前Service的方法名稱
        /// </summary>
        public string ServiceMethodName { get; set; }

        /// <summary>
        /// 目前Service的方法名稱
        /// </summary>
        public string DaoMethodName { get; set; }

        /// <summary>
        /// 類別
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// SQL語法
        /// </summary>
        public string SQL { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// 自訂訊息
        /// </summary>
        public string SysMsg { get; set; }

        /// <summary>
        /// BATCH名稱
        /// </summary>
        public string BatchName { get; set; }

        /// <summary>
        /// BATCH名稱
        /// </summary>
        public string BatchMethodName { get; set; }

        /// <summary>
        /// 參數
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public string RolId { get; set; }

        /// <summary>
        /// token id
        /// </summary>
        public string TokenId { get; set; }

        /// <summary>
        /// 客戶 id
        /// </summary>
        public string CustId { get; set; }

        /// <summary>
        /// 案件編號
        /// </summary>
        public string CaseNo { get; set; }
    }
}
