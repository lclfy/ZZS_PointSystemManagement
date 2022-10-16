using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class MonthlyPoint
    {
        //月份和对应分数
        public string month { get; set; }
        public double point { get; set; }

        public MonthlyPoint()
        {
            month = "";
            point = 0;
        }
    }
}
