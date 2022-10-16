using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class RevisionTime
    {
        //修订时间的ID，2209191005
        public string ID { get; set; }
        //对应的时间
        public DateTime revisionTime { get; set; }
        //修改人ID
        public string memberID { get; set; }

        public RevisionTime()
        {
            revisionTime = DateTime.Now;
            ID = revisionTime.ToString("yyMMddHHmm");
            memberID = "";
        }
    }
}
