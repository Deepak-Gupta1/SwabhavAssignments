using System;
using System.Collections.Generic;
using System.Configuration;

namespace AppConfigApp.Model
{
    internal class AppConfig
    {
        private string _server;
        private string _database;

        private string _conncet1 = ConfigurationSettings.AppSettings["connection1"];
        

        private string _conncet2 = ConfigurationSettings.AppSettings["connection2"];
        
        public string getDatabase1()
        {
            SplitStr(_conncet1);
            return _database;
        }
        public string getServer1()
        {
            SplitStr(_conncet1);
            return _server;
        }
        public string getDatabase2()
        {
            SplitStr(_conncet2);
            return _database;
        }
        public string getServer2()
        {
            SplitStr(_conncet2);
            return _server;
        }
        private void SplitStr(string s) {
            string[] str = s.Split(';');
            _server = str[0];
            _database = str[1];
        }
    }
}
