using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class Member
    {
        //基础数据
        //ID,工号
        public string ID { get; set; }
        //姓名
        public string name { get; set; }
        //所在班组名称/ID
        public string teamName { get; set; }
        public string teamID { get; set; }
        //所在岗位名称/ID
        public string jobName { get; set; }
        public string jobID { get; set; }
        //职务名称/ID
        public string postName { get; set; }
        public string postID { get; set; }

        public double basePoint { get; set; }

        public double currentPoint { get; set; }

        //构造
        public Member(string _id = "", string _name = "", string _teamName = "", string _teamID = "",string _jobName = "",string _jobID = "",string _postName = "",string _postID = "",double _basePoint = 100)
        {
            ID = _id;
            name = _name;
            teamName = _teamName;
            teamID = _teamID;
            jobName = _jobName;
            jobID = _jobID;
            postName = _postName;
            postID = _postID;
            basePoint = _basePoint;
            currentPoint = basePoint;
        }

    }
}
