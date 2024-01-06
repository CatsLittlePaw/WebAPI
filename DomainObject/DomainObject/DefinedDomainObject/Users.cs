namespace DomainObject.DomainObject.DefinedDomainObject
{
    public class UsersRegist
    {
        #region Properties
        public string UID { get; set; }
        public string ACCOUNT { get; set; }
        public string P455WORD { get; set; }
        public string USER_NAME { get; set; }
        public string EMAIL { get; set; }
        public string SERIAL_NUMBER { get; set; }
        #endregion
        public UsersRegist(string uid, string acc, string pwd, string name, string mail, string serialNum)
        {
            UID = uid;
            ACCOUNT = acc;
            P455WORD = pwd;
            USER_NAME = name;
            EMAIL = mail;
            SERIAL_NUMBER = serialNum;
        }
        private UsersRegist() { }
    }
    public class Users
    {

    }


}
