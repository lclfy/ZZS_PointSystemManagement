using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class MainData
    {
        /*ID 220921100535+目标人员ID
        加减分变动产生的日期-时间
        添加账户ID
        目标人员ID
        加减分ID
        加减分说明
        实际加/减分数
        修订时间
        删除标记
        注意限制每秒钟只能提交一次
        导出：选择按月份导出，导出格式按黄主任给的表，以逗号隔开
        */
        public string ID { get; set; }
        public DateTime originalDate { get; set; }
        public string createUserID { get; set; }
        public string targetMemberID { get; set; }
        public string targetPointChangeID { get; set; }
        //加减分说明
        public string pointChangeDetails { get; set; }
        public double pointChange { get; set; }
        public DateTime revisionTime { get; set; }
        public bool hasBeenDeleted { get; set; }

        public MainData()
        {
            originalDate = DateTime.Now;
            ID = originalDate.ToString("yyMMddHHmmss");
            createUserID = "";
            targetMemberID = "";
            targetPointChangeID = "";
            pointChange = 0;
            revisionTime = originalDate;
            hasBeenDeleted = false;
        }
    }
}
