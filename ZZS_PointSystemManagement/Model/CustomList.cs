using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class CustomList
    {
        //班组表Team，岗位表Job，职务表Post
        //ID,名称
        public string ID { get; set; }
        public string name { get; set; }
        //自定义条目，在Post职务表内表示职务对应基础分
        public string customText { get; set; }
        //在Team里面用来算平均分
        public double customDemical { get; set; }

        public CustomList()
        {
            ID = "";
            name = "";
            customText = "";
            customDemical = 0;
        }
    }
}
