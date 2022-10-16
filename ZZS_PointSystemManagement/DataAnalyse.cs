using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using ZZS_PointSystemManagement.Model;

namespace ZZS_PointSystemManagement
{
    public partial class DataAnalyse : Skin_Mac
    {
        public List<MainData> allMainData;
        public List<Member> allMembers;
        public List<CustomList> teamDic;
        public List<CustomList> jobDic;
        public List<CustomList> postDic;
        string searchedText;
        string selectedTeam;
        int dateMode = 0;
        public DataAnalyse(List<MainData> _mainData, List<Member> _member, List<CustomList> _teamDic, List<CustomList> _jobDic, List<CustomList> _postDic)
        {
            allMainData = _mainData;
            allMembers = _member;
            teamDic = _teamDic;
            jobDic = _jobDic;
            postDic = _postDic;
            searchedText = "";
            selectedTeam = "";
            InitializeComponent();
        }

        private void DataAnalyse_Load(object sender, EventArgs e)
        {
            initList();
            refreshMemberListData(allMembers);
            //默认显示月度
            month_radioButton.Checked = true;
            loadUI();
        }

        private void loadUI()
        {
            //班组默认显示“全部”
            teamSelect_cb.Items.Add("全部");
            teamSelect_cb.SelectedIndex = 0;
            //班组字典
            foreach (CustomList _model in teamDic)
            {
                teamSelect_cb.Items.Add(_model.name);
            }
            initDateTimePicker();
        }

        private void initList(int mode = 0)
        {
            memberList_lv.Items.Clear();
            memberList_lv.Columns.Clear();
            //mode=0为常规，mode=1显示班组长
            memberList_lv.View = View.Details;
            memberList_lv.ShowGroups = false;
            if(mode == 0)
            {
                string[] memberTitle = new string[] { "序号", "工号", "姓名", "班组", "岗位", "职务", "固定分", "总分" };
                for (int i = 0; i < memberTitle.Length; i++)
                {
                    ColumnHeader ch = new ColumnHeader();
                    ch.Text = memberTitle[i];   //设置列标题 
                    switch (i)
                    {
                        case 0:
                            ch.Width = 50;
                            break;
                        case 1:
                            ch.Width = 70;
                            break;
                        case 2:
                            ch.Width = 80;
                            break;
                        case 3:
                            ch.Width = 80;
                            break;
                        case 4:
                            ch.Width = 80;
                            break;
                        case 5:
                            ch.Width = 80;
                            break;
                        case 6:
                            ch.Width = 70;
                            break;
                        case 7:
                            ch.Width = 70;
                            break;
                    }
                    memberList_lv.FullRowSelect = true;
                    this.memberList_lv.Columns.Add(ch);    //将列头添加到ListView控件。
                }
            }
            else
            {
                string[] memberTitle = new string[] { "序号", "班组名称", "平均分" };
                for (int i = 0; i < memberTitle.Length; i++)
                {
                    ColumnHeader ch = new ColumnHeader();
                    ch.Text = memberTitle[i];   //设置列标题 
                    switch (i)
                    {
                        case 0:
                            ch.Width = 50;
                            break;
                        case 1:
                            ch.Width = 80;
                            break;
                        case 2:
                            ch.Width = 80;
                            break;
                    }
                    memberList_lv.FullRowSelect = true;
                    this.memberList_lv.Columns.Add(ch);    //将列头添加到ListView控件。
                }
            }

        }

        //同步计算所有人分数
        private bool updateMembersPoint(List<Member> _allMembers, List<MainData> _allMainData)
        {
            try
            {
                List<MainData> selectedMainData = new List<MainData>();
                foreach (MainData _m in _allMainData)
                {
                    if (targetDateIsInSelected(_m.originalDate))
                    {
                        selectedMainData.Add(_m);
                    }
                }
                for (int i = 0; i < _allMembers.Count; i++)
                {
                    _allMembers[i].currentPoint = _allMembers[i].basePoint;
                    foreach (MainData _model in selectedMainData)
                    {
                        {
                            if (_allMembers[i].ID.Equals(_model.targetMemberID))
                            {
                                _allMembers[i].currentPoint = _allMembers[i].currentPoint + _model.pointChange;
                            }
                        }
                    }
                }
                //按照分数排模型
                allMembers = _allMembers.OrderByDescending(a => a.currentPoint).ToList();//降序
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }
        //根据选定的日期刷新分数


        //刷新成员列表显示
        private bool refreshMemberListData(List<Member> _allMembers, string selectedTeamID = "", string searchedMember = "")
        {
            try
            {
                memberList_lv.Items.Clear();
                memberList_lv.Groups.Clear();
                this.memberList_lv.BeginUpdate();
                int counter = 1;
                foreach (Member _m in _allMembers)
                {
                    //搜索框
                    if (searchedMember.Length != 0)
                    {
                        if (!_m.name.Contains(searchedMember))
                        {
                            continue;
                        }
                    }
                    //班组选择，搜索的时候不显示
                    else if (selectedTeamID.Length != 0)
                    {
                        if (!_m.teamID.Equals(selectedTeamID))
                        {
                            continue;
                        }
                    }

                    ListViewItem item = new ListViewItem();
                    item.SubItems[0].Text = counter.ToString();
                    item.SubItems.Add(_m.ID);
                    item.SubItems.Add(_m.name);
                    item.SubItems.Add(_m.teamName);
                    item.SubItems.Add(_m.jobName);
                    item.SubItems.Add(_m.postName);
                    item.SubItems.Add(_m.basePoint.ToString());
                    //当前分数还没有计算
                    item.SubItems.Add(_m.currentPoint.ToString());
                    memberList_lv.Items.Add(item);
                    counter++;
                }
                ImageList imgList = new ImageList();
                imgList.ImageSize = new Size(1, 20);// 设置行高 20 //分别是宽和高 
                memberList_lv.SmallImageList = imgList; //这里设置listView的SmallImageList ,用imgList将其撑大 
                this.memberList_lv.EndUpdate();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //改变选框，改变datetimepicker
        private void checkChanged()
        {
            if (day_radioButton.Checked)
            {
                dateMode = 1;
                date_dtp.Enabled = true;
                month_dtp.Enabled = false;
                threemonth_cb.Enabled = false;
                threemonth_year_cb.Enabled = false;
                sixmonth_cb.Enabled = false;
                sixmonth_year_cb.Enabled = false;
                year_dtp.Enabled = false;
            }
            else if (month_radioButton.Checked)
            {
                dateMode = 2;
                date_dtp.Enabled = false;
                month_dtp.Enabled = true;
                threemonth_cb.Enabled = false;
                threemonth_year_cb.Enabled = false;
                sixmonth_cb.Enabled = false;
                sixmonth_year_cb.Enabled = false;
                year_dtp.Enabled = false;
            }
            else if (threemonth_radioButton.Checked)
            {
                dateMode = 3;
                date_dtp.Enabled = false;
                month_dtp.Enabled = false;
                threemonth_cb.Enabled = true;
                threemonth_year_cb.Enabled = true;
                sixmonth_cb.Enabled = false;
                sixmonth_year_cb.Enabled = false;
                year_dtp.Enabled = false;
            }
            else if (sixmonth_radioButton.Checked)
            {
                dateMode = 4;
                date_dtp.Enabled = false;
                month_dtp.Enabled = false;
                threemonth_cb.Enabled = false;
                threemonth_year_cb.Enabled = false;
                sixmonth_cb.Enabled = true;
                sixmonth_year_cb.Enabled = true;
                year_dtp.Enabled = false;
            }
            else if (year_radioButton.Checked)
            {
                dateMode = 5;
                date_dtp.Enabled = false;
                month_dtp.Enabled = false;
                threemonth_cb.Enabled = false;
                threemonth_year_cb.Enabled = false;
                sixmonth_cb.Enabled = false;
                sixmonth_year_cb.Enabled = false;
                year_dtp.Enabled = true;
            }
            //选好了，最后更新一波大家的分数
            updateMembersPoint(allMembers,allMainData);
            refreshMemberListData(allMembers);
        }
        //判断某个日期是否位于选定的某个时间区间内，分日期，月度，三个月，六个月，年度
        private bool targetDateIsInSelected(DateTime targetDT,int selectedYear=0,string selectedText = "")
        {
            bool hasGot = false;
            //日期
            if(dateMode == 1)
            {
                DateTime selectedDate = date_dtp.Value;
                if(targetDT.Year.ToString().Equals(selectedDate.Year.ToString())&&
                    targetDT.Month.ToString().Equals(selectedDate.Month.ToString()) &&
                    targetDT.Day.ToString().Equals(selectedDate.Day.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //月度
            else if(dateMode == 2)
            {
                DateTime selectedDate = month_dtp.Value;
                DateTime dtStart = Convert.ToDateTime(selectedDate.AddMonths(-1).Year.ToString() + "/" + (selectedDate.AddMonths(-1).Month).ToString() + "/26");
                DateTime dtStop = Convert.ToDateTime(selectedDate.Year.ToString() + "/" + (selectedDate.Month).ToString() + "/25");
                return targetDT.CompareTo(dtStart) >= 0 && targetDT.CompareTo(dtStop) <= 0;
            }
            //三个月
            else if (dateMode == 3)
            {
                //先对字符串进行识别
                //结算日期为26日至次月25日
                int year = Convert.ToInt32(threemonth_year_cb.SelectedItem.ToString().Replace("年",""));
                int lastYear = year - 1;
                int startMonth = 0;
                int startDate = 0;
                int stopMonth = 0;
                int stopDate = 0;
                DateTime dtStart = new DateTime();
                DateTime dtStop = new DateTime();
                if (threemonth_cb.SelectedItem.ToString().Contains("一"))
                {
                    startMonth = 12;
                    startDate = 26;
                    stopMonth = 3;
                    stopDate = 25;
                    string dtStartStr = lastYear.ToString() + "/" + startMonth + "/" + startDate;
                    dtStart = Convert.ToDateTime(dtStartStr);
                    string dtStopStr = year.ToString() + "/" + stopMonth + "/" + stopDate;
                    dtStop = Convert.ToDateTime(dtStopStr);
                }
                else if (threemonth_cb.SelectedItem.ToString().Contains("二"))
                {
                    startMonth = 3;
                    startDate = 26;
                    stopMonth = 6;
                    stopDate = 25;
                    string dtStartStr = year.ToString() + "/" + startMonth + "/" + startDate;
                    dtStart = Convert.ToDateTime(dtStartStr);
                    string dtStopStr = year.ToString() + "/" + stopMonth + "/" + stopDate;
                    dtStop = Convert.ToDateTime(dtStopStr);
                }
                else if (threemonth_cb.SelectedItem.ToString().Contains("三"))
                {
                    startMonth = 6;
                    startDate = 26;
                    stopMonth = 9;
                    stopDate = 25;
                    string dtStartStr = year.ToString() + "/" + startMonth + "/" + startDate;
                    dtStart = Convert.ToDateTime(dtStartStr);
                    string dtStopStr = year.ToString() + "/" + stopMonth + "/" + stopDate;
                    dtStop = Convert.ToDateTime(dtStopStr);
                }
                else if (threemonth_cb.SelectedItem.ToString().Contains("四"))
                {
                    startMonth = 9;
                    startDate = 26;
                    stopMonth = 12;
                    stopDate = 25;
                    string dtStartStr = year.ToString() + "/" + startMonth + "/" + startDate;
                    dtStart = Convert.ToDateTime(dtStartStr);
                    string dtStopStr = year.ToString() + "/" + stopMonth + "/" + stopDate;
                    dtStop = Convert.ToDateTime(dtStopStr);
                }
                return targetDT.CompareTo(dtStart) >= 0 && targetDT.CompareTo(dtStop) <= 0;
            }
            //半年
            else if (dateMode == 4)
            {
                int year = Convert.ToInt32(sixmonth_year_cb.SelectedItem.ToString().Replace("年", ""));
                //结算日期为26日至次月25日
                int lastYear = year - 1;
                int startMonth = 0;
                int startDate = 0;
                int stopMonth = 0;
                int stopDate = 0;
                DateTime dtStart = new DateTime();
                DateTime dtStop = new DateTime();
                if (sixmonth_cb.SelectedItem.ToString().Contains("上"))
                {
                    startMonth = 12;
                    startDate = 26;
                    stopMonth = 6;
                    stopDate = 25;
                    string dtStartStr = lastYear.ToString() + "/" + startMonth + "/" + startDate;
                    dtStart = Convert.ToDateTime(dtStartStr);
                    string dtStopStr = year.ToString() + "/" + stopMonth + "/" + stopDate;
                    dtStop = Convert.ToDateTime(dtStopStr);
                }
                else if (sixmonth_cb.SelectedItem.ToString().Contains("下"))
                {
                    startMonth = 6;
                    startDate = 26;
                    stopMonth = 12;
                    stopDate = 25;
                    string dtStartStr = year.ToString() + "/" + startMonth + "/" + startDate;
                    dtStart = Convert.ToDateTime(dtStartStr);
                    string dtStopStr = year.ToString() + "/" + stopMonth + "/" + stopDate;
                    dtStop = Convert.ToDateTime(dtStopStr);
                }
                return targetDT.CompareTo(dtStart) >= 0 && targetDT.CompareTo(dtStop) <= 0;
            }
            //年度
            else if (dateMode == 5)
            {
                DateTime selectedDate = year_dtp.Value;
                if (targetDT.Year.ToString().Equals(selectedDate.Year.ToString()))
                {
                    //本年12月26日-31日不算
                    if (targetDT.Month == 12 && targetDT.Day >= 26)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                //上一年12月26日-31日要加进来
                else if (targetDT.Year.ToString().Equals(selectedDate.AddYears(-1).Year.ToString()))
                {
                    if (targetDT.Month == 12 && targetDT.Day >= 26)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return hasGot;
        }
        //初始化日期选择器
        private void initDateTimePicker()
        {
            //日期的不用搞了
            //月度
            month_dtp.Format = DateTimePickerFormat.Custom;
            month_dtp.CustomFormat = "MMMM,yyyy年";
            month_dtp.ShowUpDown = true;
            //三个月，半年（先添加年份-10年）
            for(int i = 0; i < 10; i++)
            {
                int currentYear = DateTime.Now.Year;
                threemonth_year_cb.Items.Add((currentYear - i).ToString() + "年");
                sixmonth_year_cb.Items.Add((currentYear - i).ToString() + "年");
            }
            threemonth_year_cb.SelectedIndex = 0;
            sixmonth_year_cb.SelectedIndex = 0;
            //季度
            threemonth_cb.Items.Add("一季度");
            threemonth_cb.Items.Add("二季度");
            threemonth_cb.Items.Add("三季度");
            threemonth_cb.Items.Add("四季度");
            threemonth_cb.SelectedIndex = 0;
            //半年度
            sixmonth_cb.Items.Add("上半年");
            sixmonth_cb.Items.Add("下半年");
            sixmonth_cb.SelectedIndex = 0;
            //年度
            year_dtp.Format = DateTimePickerFormat.Custom;
            year_dtp.CustomFormat = "yyyy年度";
            year_dtp.ShowUpDown = true;
        }

        private void teamSelect_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = teamSelect_cb.SelectedItem.ToString();
            //全部的话不检索
            if (selectedTeam.Equals("全部"))
            {
                selectedTeam = "";
            }
            else
            {
                //转译Team名称与TeamID
                foreach (CustomList _model in teamDic)
                {
                    if (selectedTeam.Equals(_model.name))
                    {
                        selectedTeam = _model.ID;
                        break;
                    }
                }
            }
            refreshMemberListData(allMembers, selectedTeam, searchedText);
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            searchedText = search_tb.Text;
            refreshMemberListData(allMembers, selectedTeam, searchedText);
        }

        private void day_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void month_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void threemonth_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void sixmonth_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void year_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void date_dtp_ValueChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void month_dtp_ValueChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void threemonth_year_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void threemonth_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void sixmonth_year_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void sixmonth_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void year_dtp_ValueChanged(object sender, EventArgs e)
        {
            checkChanged();
        }
    }
}
