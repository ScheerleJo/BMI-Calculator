using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmirechnerGUI
{
    class Utility
    {
        string date, username, path, path2, pathU;

        #region Date
        public string nowDate()
        {
            date = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
            return date;
        }
        #endregion
        #region Paths
        public void setUsername(string value)
        {
            username = value;
        }
        public string getPath()
        {
            path = @"" + Environment.CurrentDirectory + "/Benutzerprofile/";
            return path;
        }
        public string getPathUsername()
        {
            pathU = getPath() + username + ".txt";
            return pathU;
        }
        public string getPath2()
        {
            path2 = getPath() + "Usernames.txt";
            return path2;
        }
        #endregion
    }
}
