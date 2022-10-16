using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class PointControl
    {
        //加减分条目ID
        public string ID { get; set; }
        //加减分条目
        public string name { get; set; }
        //该项目的默认加减分，减分体现为<0
        public double defaultPointChange { get; set; }

        public PointControl()
        {
            ID = "";
            name = "";
            defaultPointChange = 0;
        }
    }
}
