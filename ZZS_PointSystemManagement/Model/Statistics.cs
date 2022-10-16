using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZZS_PointSystemManagement.Model
{
    public class Statistics
    {
        //统计表,成员ID和每月分数
        public string memberID {get;set;}
        public List<MonthlyPoint> monthlyPoint { get; set; }
        
        public Statistics()
        {
            memberID = "";
            for(int i = 0; i < 12; i++)
            {
                MonthlyPoint _mp = new MonthlyPoint();
                _mp.month = (i + 1).ToString();
                monthlyPoint.Add(_mp);
            }
        }
    }
}
