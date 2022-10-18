namespace ClassLibrary1.SQL
{
    public class SQLStringConnector
    {
        public string sServer { get; private set; }
        public string sPort { get; private set; }
        public string sPooling { get; private set; }
        public string sDatabase { get; private set; }
        public string sUserId { get; private set; }
        public string sPassword { get; private set; }
        public string sStringConexion
        {
            get
            {
                return "Host=" + sServer +
                   ";Port=" + sPort +
                   ";Pooling=" + sPooling +
                   ";Database=" + sDatabase +
                   ";User Id=" + sUserId +
                   ";Password=" + sPassword;
            }
        }

        public SQLStringConnector()
        {
            sServer = "localhost";
            sPort = "5432";
            sPooling = "true";
            sDatabase = "postgres";
            sUserId = "postgres";
            sPassword = "454840";
        }

        public SQLStringConnector(string _sserver, string _sport, string _spooling, string _sdatabase, string _suserId, string _spassword)
        {
            sServer = _sserver;
            sPort = _sport;
            sPooling = _spooling;
            sDatabase = _sdatabase;
            sUserId = _suserId;
            sPassword = _spassword;
        }
    }
}