using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class UserData
    {
        //账号,使用人名称
        public string ID { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        //能管理的班组ID，多个在Excel中逗号区分
        public List<string> managedTeamID { get; set; }

        public string UserKey { get; set; }

        public UserData()
        {
            ID = "hkggly";
            name = "管理";
            password = "Ky123456@";
            managedTeamID = new List<string>();
            UserKey = "";
        }

    }
}
