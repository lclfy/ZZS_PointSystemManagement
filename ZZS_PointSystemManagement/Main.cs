using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin;
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using ZZS_PointSystemManagement.Model;

namespace ZZS_PointSystemManagement
{
    public partial class Main : Skin_Mac
    {
        //基础数据-人员信息
        public List<Member> allMembers;
        //主数据（每人每项加分数）
        public List<MainData> allMainData;
        //统计数据-每人每月分数统计
        public List<Statistics> allStatistics;
        //字典-班组
        public List<CustomList> teamDic;
        //字典-岗位
        public List<CustomList> jobDic;
        //字典-职务
        public List<CustomList> postDic;
        //基础数据-修改时间
        public List<RevisionTime> revisionTime;
        //基础数据-加减分表
        public List<PointControl> allPointControl;
        //基础数据-用户账户
        public List<UserData> allAccounts;
        //基础数据表
        public IWorkbook baseDataWB;
        public string baseDataFileName;
        //统计数据表，注意修改格式时，保存的表格也需要修改
        public IWorkbook MainDataWB;
        //临时存储的Excel
        public string ExcelFile;
        public string statisticDataFileName;
        public bool hasGotFiles;
        //搜索，分组
        public string searchedText;
        public string selectedTeam;
        //当前帐户
        public UserData currentUser;
        //日期筛选模式,2月份，3季度，4半年，5一年
        public int dateMode = 0;
        //选定的港站之星评比月份
        public string selectedRankMonth;
        //季度评比的季度
        public string selectedRankThreeMonth;
        //选定的日期，用来计算当前日期在某季度、某半年内，并距离开始有多少个月
        public DateTime selected_startDate;
        public DateTime selected_stopDate;

        public Main()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            allMembers = new List<Member>();
            allMainData = new List<MainData>();
            allStatistics = new List<Statistics>();
            teamDic = new List<CustomList>();
            jobDic = new List<CustomList>();
            postDic = new List<CustomList>();
            revisionTime = new List<RevisionTime>();
            allPointControl = new List<PointControl>();
            allAccounts = new List<UserData>();
            hasGotFiles = false;
            baseDataFileName = "";
            statisticDataFileName = "";
            ExcelFile = "";
            searchedText = "";
            selectedTeam = "";
            currentUser = new UserData();
            selectedRankMonth = "";
            selectedRankThreeMonth = "";
            selected_startDate = DateTime.Now;
            selected_stopDate = DateTime.Now;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            initList();
            initDateTimePicker();
            //具体班组选框在添加源数据时添加内容
            teamSelect_cb.Items.Add("全部");
            teamSelect_cb.SelectedIndex = 0;
            //读取文件
            baseDataWB = loadExcel(Application.StartupPath + "\\BaseData.data");
            MainDataWB = loadExcel(Application.StartupPath + "\\MainData.data");
            if (baseDataWB == null || MainDataWB == null)
            {
                this.Close();
            }
            loadBaseData(baseDataWB);
            loadStatisticData(MainDataWB);
            //refreshData:包含五个方法，匹配每个人和职位/基础分，更新所有人的分数，更新成员表UI，更新积分变动表UI，统计港站之星/冠
            refreshData();
            //找当前日期位于哪里
            //默认显示月度
            month_radioButton.Checked = true;

            getStarAndCrown(0);
        }

        //改变选框，改变datetimepicker
        private void checkChanged()
        {
            //月度
            if (month_radioButton.Checked)
            {
                dateMode = 2;
                month_dtp.Enabled = true;
                threemonth_cb.Enabled = false;
                threemonth_year_cb.Enabled = false;
                sixmonth_cb.Enabled = false;
                sixmonth_year_cb.Enabled = false;
                year_dtp.Enabled = false;
                selectedRankMonth = month_dtp.Value.Year.ToString() + "年" + month_dtp.Value.Month.ToString() + "月";
                monthly_lbl.Text = selectedRankMonth;
            }
            //三个月
            else if (threemonth_radioButton.Checked)
            {
                dateMode = 3;
                month_dtp.Enabled = false;
                threemonth_cb.Enabled = true;
                threemonth_year_cb.Enabled = true;
                sixmonth_cb.Enabled = false;
                sixmonth_year_cb.Enabled = false;
                year_dtp.Enabled = false;
                selectedRankThreeMonth = threemonth_year_cb.Text + threemonth_cb.Text;
                threeMonth_lbl.Text = selectedRankThreeMonth;
            }
            //六个月
            else if (sixmonth_radioButton.Checked)
            {
                dateMode = 4;
                month_dtp.Enabled = false;
                threemonth_cb.Enabled = false;
                threemonth_year_cb.Enabled = false;
                sixmonth_cb.Enabled = true;
                sixmonth_year_cb.Enabled = true;
                year_dtp.Enabled = false;
            }
            //一年
            else if (year_radioButton.Checked)
            {
                dateMode = 5;
                month_dtp.Enabled = false;
                threemonth_cb.Enabled = false;
                threemonth_year_cb.Enabled = false;
                sixmonth_cb.Enabled = false;
                sixmonth_year_cb.Enabled = false;
                year_dtp.Enabled = true;
            }
            //选好了，最后更新一波大家的分数
            refreshData();
        }

        private void initList()
        {
            memberList_lv.View = View.Details;
            memberList_lv.ShowGroups = false;
            string[] memberTitle = new string[] { "序号","工号","姓名","班组","岗位","职务","固定分","总分" };
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

            pointDetailView_lv.View = View.Details;
            pointDetailView_lv.ShowGroups = true;
            pointDetailView_lv.FullRowSelect = true;
            string[] pointDetailViewTitle = new string[] { "序号","姓名","分数", "事由", "修改时间","ID","成员ID" };
            for (int i = 0; i < pointDetailViewTitle.Length; i++)
            {
                ColumnHeader ch = new ColumnHeader();
                ch.Text = pointDetailViewTitle[i];   //设置列标题 
                if (i ==0 || i == 2)
                {
                    ch.Width = 40;
                }
                else if(i == 1)
                {
                    ch.Width = 60;
                }
                else if (i==3 || i ==4)
                {
                    ch.Width = 100;
                }
                else if (i >= 5)
                {
                    ch.Width = 0;
                }

                this.pointDetailView_lv.Columns.Add(ch);    //将列头添加到ListView控件。
            }
        }

        //导入人员数据，导入动态数据时用到的选框
        private string SelectPath(int mode)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();   //显示选择文件对话框 
            openFileDialog1.Filter = "Excel 2003 文件 (*.xls)|*.xls";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExcelFile = openFileDialog1.FileName;
                return openFileDialog1.FileName;
            }
            else
            {
                return "";
            }
        }

        //获取excel
        private IWorkbook loadExcel(string fileType)
        {
            //fileType:base,statistic两种
            //读取文件
            IWorkbook workBook;
            string fileName = fileType;
            baseDataFileName = fileName;
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                workBook = new HSSFWorkbook(fileStream);  //xlsx数据读入workbook  
                if (workBook == null)
                {
                    if (fileType.Contains("Main"))
                    {
                        DialogResult result = MessageBox.Show("读取积分数据时出现错误，是否自动创建新数据？\n", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            return new HSSFWorkbook();
                        }
                        else
                        {
                            return null;
                        }

                    }
                    else
                    {
                        MessageBox.Show("读取数据时出现错误\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return null;
                    }
                }
                else
                {
                    return workBook;
                }

            }
            catch (Exception e)
            {

                if (fileType.Contains("Main"))
                {
                    DialogResult result = MessageBox.Show("读取积分数据时出现错误，是否自动创建新数据？\n错误内容：" + e.ToString().Split('在')[0], "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        return new HSSFWorkbook();
                    }
                    else
                    {
                        return null;
                    }

                }
                else
                {
                    MessageBox.Show("读取数据时出现错误\n错误内容：" + e.ToString().Split('在')[0], "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }

            }
        }

        //读基础数据
        private bool loadBaseData(IWorkbook WorkBook)
        {
            //偷懒。。在这里面更新班组列表了。。
            try
            {
                teamSelect_cb.Items.Clear();
                teamSelect_cb.Items.Add("全部");
                teamSelect_cb.SelectedIndex = 0;
                if (WorkBook == null)
                {
                    return false;
                }
                List<ISheet> allSheets = new List<ISheet>();
                ISheet sheet_Members = WorkBook.GetSheet("Members");
                ISheet sheet_Teams = WorkBook.GetSheet("Teams");
                ISheet sheet_Jobs = WorkBook.GetSheet("Jobs");
                ISheet sheet_Posts = WorkBook.GetSheet("Posts");
                ISheet sheet_Accounts = WorkBook.GetSheet("Accounts");
                ISheet sheet_PointRules = WorkBook.GetSheet("PointRules");
                ISheet sheet_RevisionTime = WorkBook.GetSheet("RevisionTime");
                allSheets.Add(sheet_Members);
                allSheets.Add(sheet_Teams);
                allSheets.Add(sheet_Jobs);
                allSheets.Add(sheet_Posts);
                allSheets.Add(sheet_Accounts);
                allSheets.Add(sheet_PointRules);
                allSheets.Add(sheet_RevisionTime);

                List<Member> _members = new List<Member>();
                List<CustomList> _teamDic = new List<CustomList>();
                List<CustomList> _jobDic = new List<CustomList>();
                List<CustomList> _postDic = new List<CustomList>();
                List<RevisionTime> _revisionTime = new List<RevisionTime>();
                List<PointControl> _allPointControl = new List<PointControl>();
                List<UserData> _allAccounts = new List<UserData>();
                bool titleRow;
                foreach (ISheet sheet in allSheets)
                {
                    if (sheet == null)
                    {
                        MessageBox.Show("选择了错误的字典文件，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    titleRow = true;
                    foreach (IRow row in sheet)
                    {
                        //首行跳过
                        if (titleRow)
                        {
                            titleRow = false;
                            continue;
                        }
                        if (row.GetCell(0) == null || row.GetCell(0).ToString().Trim().Length == 0)
                        {
                            continue;
                        }
                        if (sheet.SheetName.Equals("Members"))
                        {
                            Member _model = new Member();
                            _model.ID = row.GetCell(0).ToString().Trim();
                            if (row.GetCell(1) != null && row.GetCell(1).ToString().Trim().Length != 0)
                                _model.name = row.GetCell(1).ToString().Trim();
                            if (row.GetCell(2) != null && row.GetCell(2).ToString().Trim().Length != 0)
                                _model.teamName = row.GetCell(2).ToString().Trim();
                            if (row.GetCell(3) != null && row.GetCell(3).ToString().Trim().Length != 0)
                                _model.postName = row.GetCell(3).ToString().Trim();
                            if (row.GetCell(4) != null && row.GetCell(4).ToString().Trim().Length != 0)
                                _model.jobName = row.GetCell(4).ToString().Trim();
                            _members.Add(_model);
                        }
                        else if (sheet.SheetName.Equals("Accounts"))
                        {
                            UserData _model = new UserData();
                            _model.ID = row.GetCell(0).ToString().Trim();
                            if (row.GetCell(1) != null && row.GetCell(1).ToString().Trim().Length != 0)
                                _model.name = row.GetCell(1).ToString().Trim();
                            if (row.GetCell(2) != null && row.GetCell(2).ToString().Trim().Length != 0)
                                _model.password = row.GetCell(2).ToString().Trim();
                            if (row.GetCell(3) != null && row.GetCell(3).ToString().Trim().Length != 0)
                                //管理的班组ID需要以英文逗号区分
                                _model.managedTeamID = row.GetCell(3).ToString().Trim().Split(',').ToList();
                            _allAccounts.Add(_model);
                        }
                        else if (sheet.SheetName.Equals("PointRules"))
                        {
                            PointControl _model = new PointControl();
                            _model.ID = row.GetCell(0).ToString().Trim();
                            if (row.GetCell(1) != null && row.GetCell(1).ToString().Trim().Length != 0)
                                _model.name = row.GetCell(1).ToString().Trim();
                            if (row.GetCell(2) != null && row.GetCell(2).ToString().Trim().Length != 0)
                            {
                                double temp = 0;
                                double.TryParse(row.GetCell(2).ToString().Trim(), out temp);
                                _model.defaultPointChange = temp;
                            }
                            _allPointControl.Add(_model);
                        }
                        else if (sheet.SheetName.Equals("RevisionTime"))
                        {
                            RevisionTime _model = new RevisionTime();
                            _model.ID = row.GetCell(0).ToString().Trim();
                            if (row.GetCell(1) != null && row.GetCell(1).ToString().Trim().Length != 0)
                            {
                                DateTime temp = DateTime.Now;
                                DateTime.TryParse(row.GetCell(1).ToString().Trim(), out temp);
                                _model.revisionTime = temp;
                            }
                            if (row.GetCell(2) != null && row.GetCell(2).ToString().Trim().Length != 0)
                                _model.memberID = row.GetCell(2).ToString().Trim();

                            _revisionTime.Add(_model);
                        }
                        //剩下三个teams jobs posts都一样
                        else
                        {
                            CustomList _model = new CustomList();
                            _model.ID = row.GetCell(0).ToString().Trim();
                            if (row.GetCell(1) != null && row.GetCell(1).ToString().Trim().Length != 0)
                                _model.name = row.GetCell(1).ToString().Trim();
                            if (row.GetCell(2) != null && row.GetCell(2).ToString().Trim().Length != 0)
                                _model.customText = row.GetCell(2).ToString().Trim();
                            if (sheet.SheetName.Equals("Teams"))
                            {
                                //添加分组信息到界面
                                teamSelect_cb.Items.Add(_model.name);
                                _teamDic.Add(_model);
                            }
                            else if (sheet.SheetName.Equals("Jobs"))
                            {
                                _jobDic.Add(_model);
                            }
                            else if (sheet.SheetName.Equals("Posts"))
                            {
                                _postDic.Add(_model);
                            }
                        }
                    }
                }

                allMembers = _members;
                teamDic = _teamDic;
                jobDic = _jobDic;
                postDic = _postDic;
                revisionTime = _revisionTime;
                allPointControl = _allPointControl;
                allAccounts = _allAccounts;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("读取字典数据出现问题\n" + e.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
         
        }


        //判断某个日期是否位于选定的某个时间区间内，分日期，月度，三个月，六个月，年度
        private bool targetDateIsInSelected(DateTime targetDT, int selectedYear = 0, string selectedText = "")
        {
            bool hasGot = false;
            //日期
            /*
            if (dateMode == 1)
            {
                DateTime selectedDate = date_dtp.Value;
                if (targetDT.Year.ToString().Equals(selectedDate.Year.ToString()) &&
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
            */
            //月度
            if (dateMode == 2)
            {
                DateTime selectedDate = month_dtp.Value;
                DateTime dtStart = Convert.ToDateTime(selectedDate.AddMonths(-1).Year.ToString() + "/" + (selectedDate.AddMonths(-1).Month).ToString() + "/26");
                DateTime dtStop = Convert.ToDateTime(selectedDate.Year.ToString() + "/" + (selectedDate.Month).ToString() + "/25");
                //加个全局参数
                selected_startDate = dtStart;
                selected_stopDate = dtStop;
                return targetDT.CompareTo(dtStart) >= 0 && targetDT.CompareTo(dtStop) <= 0;
            }
            //三个月
            else if (dateMode == 3)
            {
                //先对字符串进行识别
                //结算日期为26日至次月25日
                int year = Convert.ToInt32(threemonth_year_cb.SelectedItem.ToString().Replace("年", ""));
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
                selected_startDate = dtStart;
                selected_stopDate = dtStop;
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
                selected_startDate = dtStart;
                selected_stopDate = dtStop;
                return targetDT.CompareTo(dtStart) >= 0 && targetDT.CompareTo(dtStop) <= 0;
            }
            //年度
            else if (dateMode == 5)
            {
                DateTime selectedDate = year_dtp.Value;
                selected_startDate = Convert.ToDateTime(selectedDate.AddYears(-1).Year.ToString()+"/"+"12/26");
                selected_stopDate = Convert.ToDateTime(selectedDate.Year.ToString() + "/" + "12/25");
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
            for (int i = 0; i < 10; i++)
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

        //滚动字幕用的
        private void textScroll_Star()
        {
            star_member_lb.Left = star_member_lb.Left + 10;
            if (star_member_lb.Left > 250)
                star_member_lb.Left = -150;
        }

        private void textScroll_StarLeader()
        {
            star_leader_lb.Left = star_leader_lb.Left + 10;
            if (star_leader_lb.Left > 250)
                star_leader_lb.Left = -150;
        }

        private void textScroll_Crown()
        {
            crownTeam_lbl.Left = crownTeam_lbl.Left + 10;
            if (crownTeam_lbl.Left > 250)
                crownTeam_lbl.Left = -150;
        }

        //算港站之星/冠
        private void getStarAndCrown(int starOrCrown)
        {
            //0星，1冠
            string star = "";
            double starPoint = 0;
            string starLeader = "";
            double starLeaderPoint = 0;
            string crown = "";
            double crownPoint = 0;
            if(starOrCrown == 0 && dateMode == 2)
            {
                //先找第一名班组长
                foreach (Member _model in allMembers)
                {
                    if (_model.postName.Equals("班组长"))
                    {
                        starLeader = _model.name;
                        starLeaderPoint = _model.currentPoint;
                        break;
                    }
                }
                //再找有没有跟第一名班组长分数一样的
                foreach(Member _model in allMembers)
                {
                    if (_model.postName.Equals("班组长"))
                    {
                        //名字不一样
                        if (!_model.name.Equals(starLeader))
                        {
                            if(_model.currentPoint == starLeaderPoint)
                            {
                                starLeader = starLeader + "," + _model.name;
                            }
                        }

                    }
                }
                //确定要不要滚动
                if (starLeader.Split(',').Length >= 3)
                {
                    this.starleaderTimer.Start();
                    star_leader_lb.Left = -150;
                }
                else
                {
                    this.starleaderTimer.Stop();
                    star_leader_lb.Left = 125;
                }
                if (starLeader.Split(',').Length == 2)
                {
                    star_leader_lb.Left = 60;
                }
                //职工同理
                //先找第一名
                foreach (Member _model in allMembers)
                {
                    if (!_model.postName.Equals("班组长"))
                    {
                        star = _model.name;
                        starPoint = _model.currentPoint;
                        break;
                    }
                }
                //再找有没有跟第一名分数一样的
                foreach (Member _model in allMembers)
                {
                    if (!_model.postName.Equals("班组长"))
                    {
                        //名字不一样
                        if (!_model.name.Equals(star))
                        {
                            if (_model.currentPoint == starPoint)
                            {
                                star = star + ","+ _model.name;
                            }
                        }

                    }
                }
                //确定要不要滚动
                if(star.Split(',').Length >= 3)
                {
                    this.starTimer.Start();
                    star_member_lb.Left = -150;
                }
                else
                {
                    this.starTimer.Stop();
                    star_member_lb.Left = 125;
                }
                if(star.Split(',').Length == 2)
                {
                    star_member_lb.Left = 60;
                }
                star_member_lb.Text = star;
                star_member_point_lb.Text = starPoint.ToString() + "分";
                star_leader_lb.Text = starLeader;
                star_leader_point_lb.Text = starLeaderPoint.ToString()+"分";
            }
            else if(starOrCrown == 1 && dateMode == 3)
            {
                //各班组平均分数
                //应该算季度的,限制一下
                for(int j = 0; j < teamDic.Count; j++)
                {
                    double allPoints = 0;
                    double avgPoints = 0;
                    double membersCount = 0;
                    foreach(Member _m in allMembers)
                    {
                        //每个人的实际得分加起来除以人数
                        if (_m.teamName.Equals(teamDic[j].name))
                        {
                            allPoints = allPoints + _m.currentPoint;
                        }
                    }
                    membersCount = Convert.ToDouble(teamDic[j].customText);
                    avgPoints = Math.Round(allPoints / membersCount, 2);
                    teamDic[j].customDemical = avgPoints;
                }
                //比比谁的高
                double maxPoints = 0;
                string highestTeam = "";
                foreach(CustomList _model in teamDic)
                {
                    if(_model.customDemical > maxPoints)
                    {
                        maxPoints = _model.customDemical;
                        highestTeam = _model.name;
                    }
                }
                crownTeam_lbl.Text = highestTeam;
                crown_team_point_lbl.Text = maxPoints.ToString() + "分";
            }

        }

        //同步计算所有人分数
        private bool updateMembersPoint(List<Member> _allMembers,List<MainData> _allMainData)
        {
            try
            {
                for (int i = 0; i < _allMembers.Count; i++)
                {
                    _allMembers[i].currentPoint = _allMembers[i].basePoint;
                    foreach (MainData _model in _allMainData)
                    {
                        if (targetDateIsInSelected(_model.originalDate))
                        {
                            //公休不计入的情况：不以月度查看，按钮勾上了
                            if (withoutNO26_cb.Checked && dateMode != 2)
                            {

                                if (findPointControlByID(_model.targetPointChangeID).Contains("公休"))
                                {
                                    continue;
                                }
                            }
                            if (_allMembers[i].ID.Equals(_model.targetMemberID))
                            {
                                _allMembers[i].currentPoint = _allMembers[i].currentPoint + _model.pointChange;
                            }
                        }
                    }
                }
                //按照分数排模型
                if (orderByPoint_cb.Checked)
                {
                    allMembers = _allMembers.OrderByDescending(a => a.currentPoint).ToList();//降序
                }
                else
                {
                    allMembers = _allMembers;
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
          

        }

        //算加分和减分的量，导出的时候用
        private double calculateAddAndMinusPoint(Member _member, List<MainData> _allMainData,bool addOrMinus)
        {
            //加是true，减是false
            double targetPoint = 0;
            try
                {
                    foreach (MainData _model in _allMainData)
                    {
                        if (targetDateIsInSelected(_model.originalDate))
                        {
                            if (_member.ID.Equals(_model.targetMemberID))
                            {
                            //只算加分的
                            if (addOrMinus)
                            {
                                if(_model.pointChange > 0)
                                {
                                    targetPoint = targetPoint + _model.pointChange;
                                }
                            }
                            //算减分的
                            else
                            {
                                if (_model.pointChange < 0)
                                {
                                    targetPoint = targetPoint + _model.pointChange;
                                }
                            }

                            }
                        }
                    }
                return targetPoint;
            }
            catch (Exception e)
            {
                return 0;
            }


        }

        //读动态数据
        private bool loadStatisticData(IWorkbook WorkBook)
        {
            try
            {
                if (WorkBook == null)
                {
                    return false;
                }
                if (WorkBook.NumberOfSheets == 0)
                {
                    WorkBook.CreateSheet("主数据");
                }
                ISheet sheet = WorkBook.GetSheetAt(0);
                if(WorkBook.NumberOfSheets > 3)
                {
                    MessageBox.Show("选择了错误的积分文件，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                List<MainData> _mainData = new List<MainData>();
                bool titleRow = true;
                {
                    foreach (IRow row in sheet)
                    {
                        //首行跳过
                        if (titleRow)
                        {
                            titleRow = false;
                            continue;
                        }
                        if (row.GetCell(0) == null || row.GetCell(0).ToString().Trim().Length == 0)
                        {
                            continue;
                        }
                        MainData _model = new MainData();
                        _model.ID = row.GetCell(0).ToString().Trim();
                        if (row.GetCell(1) != null && row.GetCell(1).ToString().Trim().Length != 0)
                        {
                            DateTime temp = DateTime.Now;
                            DateTime.TryParse(row.GetCell(1).ToString().Trim(), out temp);
                            _model.originalDate = temp;
                        }
                        if (row.GetCell(2) != null && row.GetCell(2).ToString().Trim().Length != 0)
                            _model.createUserID = row.GetCell(2).ToString().Trim();
                        if (row.GetCell(3) != null && row.GetCell(3).ToString().Trim().Length != 0)
                            _model.targetMemberID = row.GetCell(3).ToString().Trim();
                        if (row.GetCell(4) != null && row.GetCell(4).ToString().Trim().Length != 0)
                            _model.targetPointChangeID = row.GetCell(4).ToString().Trim();
                        if (row.GetCell(5) != null && row.GetCell(5).ToString().Trim().Length != 0)
                            _model.pointChangeDetails = row.GetCell(5).ToString().Trim();
                        if (row.GetCell(6) != null && row.GetCell(6).ToString().Trim().Length != 0)
                        {
                            double temp = 0;
                            double.TryParse(row.GetCell(6).ToString().Trim(), out temp);
                            _model.pointChange = temp;
                        }
                        if (row.GetCell(7) != null && row.GetCell(7).ToString().Trim().Length != 0)
                        {
                            DateTime temp = DateTime.Now;
                            DateTime.TryParse(row.GetCell(7).ToString().Trim(), out temp);
                            _model.revisionTime = temp;
                        }
                        if (row.GetCell(8) != null && row.GetCell(8).ToString().Trim().Length != 0)
                        {
                            bool temp = false;
                            bool.TryParse(row.GetCell(8).ToString().Trim(), out temp);
                            _model.hasBeenDeleted = temp;
                        }
                        _mainData.Add(_model);
                    }
                }

                allMainData = _mainData;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("读取积分数据出现问题。\n" + e.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
       
        }

        //计算选择的开始日期距离当前有几个月，加基础分用
        private int getTargetMonthsByNow()
        {
            targetDateIsInSelected(DateTime.Now);
            DateTime dtStart = selected_startDate;
            DateTime dtStop = selected_stopDate;
            //如果当前日子在结束日之后了，那就返回-1，如果当前日子连开始日都没到，就返回0，如果6月看下半年，9月看四季度，算出来应该是0
            if((DateTime.Now - dtStop).Days >= 0)
            {
                return -1;
            }
            else if((DateTime.Now - dtStart).Days <= 0)
            {
                return 0;
            }
            else
            {
                int count = (Math.Abs((DateTime.Now - dtStart).Days) / 30) + 1;
                return count;
            }

        }

        //在字典中匹配输入的基础数据与ID，匹配基础分和人员，如果在当前季度/当前半年，先计算出需要几个月，再乘基础分
        private List<Member> getPairedWithMemberAndDic(List<Member> _allMembers)
        {
            for(int i = 0; i < _allMembers.Count; i++)
            {
                foreach(CustomList _model in teamDic)
                {
                    if (_allMembers[i].teamName.Equals(_model.name))
                        _allMembers[i].teamID = _model.ID;
                }
                foreach (CustomList _model in jobDic)
                {
                    if (_allMembers[i].jobName.Equals(_model.name))
                        _allMembers[i].jobID = _model.ID;
                }
                foreach (CustomList _model in postDic)
                {
                    if (_allMembers[i].postName.Equals(_model.name))
                    {
                        _allMembers[i].postID = _model.ID;
                        //基础分
                        double temp = 100;
                        double.TryParse(_model.customText, out temp);
                        //根据选了几个月来算,2月份3季度4半年5一年，选定的季度/半年距离当前月份的月份数加一个全局参数,selected_StartDate/StopDate
                        if(dateMode > 2)
                        {
                            int month = getTargetMonthsByNow();
                            if(month > 0)
                            {
                                temp = temp * month;
                            }
                            else if(month == -1)
                            {
                                if (dateMode == 3) 
                                {
                                    temp = temp * 3;
                                }
                                else if(dateMode == 4)
                                {
                                    temp = temp * 6;
                                }
                                else if(dateMode == 5)
                                {
                                    temp = temp * 12;
                                }
                            }
                            else
                            {
                                temp = 0;
                            }

                        }
                        _allMembers[i].basePoint = temp;
                        _allMembers[i].currentPoint = temp;
                    }

                }
            }
            //统计每个班组有多少人，算冠用
            for(int j = 0; j < teamDic.Count; j++)
            {
                int count = 0;
                foreach(Member _m in _allMembers)
                {
                    if (_m.teamName.Equals(teamDic[j].name)){
                        count++;
                    }
                }
                teamDic[j].customText = count.ToString();
            }
            return _allMembers;
        }
        //刷新数据操作
        private bool refreshData()
        {
            bool success = false;
            bool final = true;
            //加上大家的分数，排序勾上的话会进行排序,按选择的月份进行显示
            //一个月，三个月，六个月，一年的基础分乘相应数字
            allMembers = getPairedWithMemberAndDic(allMembers);
            //更新分数
            success = updateMembersPoint(allMembers, allMainData);
            if (!success)
            {
                final = false;
            }
            //刷新主数据
            success = refreshMainListData(allMainData);
            if (!success)
            {
                final = false;
            }
            //刷新成员数据
            success = refreshMemberListData(allMembers);
            if (!success)
            {
                final = false;
            }

            return final;
        }
        
        //刷新成员列表显示
        private bool refreshMemberListData(List<Member> _allMembers,string selectedTeamID="",string searchedMember = "")
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
            catch(Exception e)
            {
                return false;
            }
        }

        //通过工号找姓名,再反过来
        private string findMemberByID(string id)
        {
            string name = "";
            foreach(Member _model in allMembers)
            {
                if (_model.ID.Equals(id))
                {
                    name = _model.name;
                    break;
                }
            }
            return name;
        }

        private string findIDByName(string name)
        {
            string ID = "";
            foreach (Member _model in allMembers)
            {
                if (_model.name.Equals(name))
                {
                    ID = _model.ID;
                    break;
                }
            }
            return ID;
        }

        //通过条目ID找条目
        private string findPointControlByID(string id)
        {
            string name = "";
            foreach (PointControl _model in allPointControl)
            {
                if (_model.ID.Equals(id))
                {
                    name = _model.name;
                    break;
                }
            }
            return name;
        }

        //刷新单项列表显示
        private bool refreshMainListData(List<MainData> _mainData,string targetMemberID = "")
        {
            try
            {
                pointDetailView_lv.Items.Clear();
                pointDetailView_lv.Groups.Clear();
                this.pointDetailView_lv.BeginUpdate();
                int counter = 1;
                foreach (MainData _m in _mainData)
                {
                    if (targetDateIsInSelected(_m.originalDate))
                    {
                        if (targetMemberID.Length != 0)
                        {
                            if (!_m.targetMemberID.Equals(targetMemberID))
                            {
                                continue;
                            }
                        }

                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = counter.ToString();
                            item.SubItems.Add(findMemberByID(_m.targetMemberID));
                            item.SubItems.Add(_m.pointChange.ToString());
                            item.SubItems.Add(_m.pointChangeDetails);
                            item.SubItems.Add(_m.revisionTime.ToString("yyyy-MM-dd HH:mm"));
                            //隐藏的ID和memberID，好找
                            item.SubItems.Add(_m.ID);
                            item.SubItems.Add(_m.targetMemberID);

                            pointDetailView_lv.Items.Add(item);
                            counter++;
                        }
                    }
                }
                ImageList imgList = new ImageList();
                imgList.ImageSize = new Size(1, 20);// 设置行高 20 //分别是宽和高 
                pointDetailView_lv.SmallImageList = imgList; //这里设置listView的SmallImageList ,用imgList将其撑大 
                this.pointDetailView_lv.EndUpdate();
                detail_rtb.Text = "";
                //最后刷新一下星、冠
                getStarAndCrown(0);
                getStarAndCrown(1);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //导入单项数据
        private void importData_btn_Click(object sender, EventArgs e)
        {
            string sourceFilePath = SelectPath(1);
            string fileName = Path.GetFileName(sourceFilePath);
            if(fileName.Length == 0)
            {
                return;
            }
            //先导入一下看看有没有问题，没问题的话问要不要覆盖现有数据
            IWorkbook tempWB = loadExcel(sourceFilePath);
            if (tempWB == null)
            {
                MessageBox.Show("读取数据时出现错误，将不会修改源数据\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MainDataWB = tempWB;
                bool success = loadStatisticData(MainDataWB);
                if (success)
                {
                    success = refreshData();
                    if (success)
                    {
                        DialogResult dr;
                        dr = MessageBox.Show("已确认新的数据可用，确认覆盖吗？", "提醒", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (dr == DialogResult.Yes)
                        {
                            //把文件拷过来改个名
                            try
                            {
                                File.Copy(sourceFilePath, Application.StartupPath + "\\MainData.data", true);
                                MainDataWB = loadExcel(Application.StartupPath + "\\MainData.data");
                                loadStatisticData(MainDataWB);
                                refreshData();
                            }
                            catch (Exception ex)
                            {
                                MainDataWB = loadExcel(Application.StartupPath + "\\MainData.data");
                                loadStatisticData(MainDataWB);
                                return;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("读取数据时出现错误，将不会修改源数据\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MainDataWB=loadExcel(Application.StartupPath + "\\MainData.data");
                        loadStatisticData(MainDataWB);
                    }
                }
                else
                {
                    MessageBox.Show("读取数据时出现错误，将不会修改源数据\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MainDataWB=loadExcel(Application.StartupPath + "\\MainData.data");
                    loadStatisticData(MainDataWB);
                }



            }
        }

        //导入人员数据
        private void importMemberData_btn_Click(object sender, EventArgs e)
        {
            string sourceFilePath = SelectPath(1);
            string fileName = Path.GetFileName(sourceFilePath);
            if (fileName.Length == 0)
            {
                return;
            }
            //先导入一下看看有没有问题，没问题的话问要不要覆盖现有数据
            IWorkbook tempWB = loadExcel(sourceFilePath);
            if (tempWB == null)
            {
                MessageBox.Show("读取数据时出现错误，将不会修改源数据\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                baseDataWB = tempWB;
                bool success = loadBaseData(baseDataWB);
                if (success)
                {
                    success = refreshData();
                    if (success)
                    {
                        DialogResult dr;
                        dr = MessageBox.Show("已确认新的数据可用，确认覆盖吗？", "提醒", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (dr == DialogResult.Yes)
                        {
                            //把文件拷过来改个名
                            try
                            {
                                File.Copy(sourceFilePath, Application.StartupPath + "\\BaseData.data", true);
                                baseDataWB = loadExcel(Application.StartupPath + "\\BaseData.data");
                                loadBaseData(baseDataWB);
                                refreshData();
                            }
                            catch (Exception ex)
                            {
                                baseDataWB = loadExcel(Application.StartupPath + "\\BaseData.data");
                                loadBaseData(baseDataWB);
                                return;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("读取数据时出现错误，将不会修改源数据\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        baseDataWB = loadExcel(Application.StartupPath + "\\BaseData.data");
                        loadBaseData(baseDataWB);
                    }
                }
                else
                {
                    MessageBox.Show("读取数据时出现错误，将不会修改源数据\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    baseDataWB = loadExcel(Application.StartupPath + "\\BaseData.data");
                    loadBaseData(baseDataWB);
                }



            }
        }

        //搜索框
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchedText = search_tb.Text;
            refreshMemberListData(allMembers, selectedTeam, searchedText);
        }
        //班组
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
        //增删改
        private void AddData()
        {
                MainData _tempModel = new MainData();
            if(memberList_lv.SelectedItems.Count == 1)
                _tempModel.targetMemberID = memberList_lv.SelectedItems[0].SubItems[1].Text;
            //0是新建，1是编辑
            EditData _ed = new EditData(_tempModel,0,allMembers,teamDic,allPointControl,currentUser);
                _ed.Owner = this;
            _ed.Show();
        }
        private void EditData()
        {
            if (pointDetailView_lv.SelectedItems.Count != 0)
            {
                MainData _tempModel = new MainData();
                for (int i=0;i<allMainData.Count;i++)
                {
                    MainData _m = allMainData[i];
                    if (_m.ID.Equals(pointDetailView_lv.SelectedItems[0].SubItems[5].Text.Trim()))
                    {
                        _tempModel = _m;
                    }
                }
                //0是新建，1是编辑
                EditData _ed = new EditData(_tempModel,1, allMembers, teamDic, allPointControl,currentUser);
                _ed.Owner = this;
                _ed.Show();
            }
        }

        private void DeleteData()
        {
            DialogResult dr;
            dr = MessageBox.Show("确认删除吗？", "提醒", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                MainData _tempModel = new MainData();
                bool hasGot = false;
                foreach (MainData _m in allMainData)
                {
                    if (_m.ID.Equals(pointDetailView_lv.SelectedItems[0].SubItems[5].Text.Trim()))
                    {
                        _tempModel = _m;
                        hasGot = true;
                        break;
                    }
                }
                if (hasGot)
                {
                    allMainData.Remove(_tempModel);
                }
                //刷新列表
                refreshData();
            }

        }

        //在子窗口调用这个方法，保存一下数据
        public void EditComplete(MainData _model, int mode)
        {
            //新建0修改1
            if(mode == 0)
            {
                //把模型添加进去
                allMainData.Add(_model);
                refreshData();
            }
            //修改，找到对应条目，内容更新一下
            else if(mode == 1)
            {
                for (int i=0;i<allMainData.Count;i++)
                {
                    if (allMainData[i].ID.Equals(_model.ID))
                    {
                        allMainData[i].originalDate = _model.originalDate;
                        allMainData[i].targetPointChangeID = _model.targetPointChangeID;
                        allMainData[i].pointChangeDetails = _model.pointChangeDetails;
                        allMainData[i].pointChange = _model.pointChange;
                        allMainData[i].revisionTime = _model.revisionTime;
                        break;
                    }
                }
                //刷新列表
                refreshData();
            }

        }

        //关闭时候保存
        protected override void OnClosing(CancelEventArgs e)
        {
            if(MainDataWB != null)
            {
                SaveMainDataToExcel();
            }

            base.OnClosing(e);
        }

        //导出表格，按照选择的时间和班组导出
        private void OutputMainData()
        {
            FileStream fs;
            string title = "";
            if (dateMode == 2)
            {
                fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + selected_startDate.AddMonths(1).ToString("yyyy年MM月") + "积分统计.xls");
                title = selected_startDate.AddMonths(1).ToString("yyyy年MM月") + "积分统计";
            }
            else
            {
                fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + selected_startDate.AddMonths(1).ToString("yyyy年MM月-") + selected_stopDate.ToString("yyyy年MM月") + "积分统计.xls");
                title = selected_startDate.ToString("yyyy年MM月-") + selected_stopDate.ToString("yyyy年MM月") + "积分统计";
            }

            IWorkbook wbMainData = new HSSFWorkbook();
            ICellStyle normalStyle = wbMainData.CreateCellStyle();
            normalStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            normalStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            normalStyle.WrapText = true;
            normalStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            normalStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            normalStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            normalStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;//垂直
            normalStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("@");
            //创建sheet
            ISheet sheet = wbMainData.CreateSheet("积分");
            //弄个标题出来
            IRow row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue(title);
            row.GetCell(0).CellStyle = normalStyle;
            for (int i = 1; i < 10; i++)
            {
                row.CreateCell(i);

            }
            sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, 9));
            //标题行
            IRow titleRow = sheet.CreateRow(1);
            titleRow.CreateCell(0).SetCellValue("序号");
            titleRow.CreateCell(1).SetCellValue("姓名");
            titleRow.CreateCell(2).SetCellValue("工号");
            titleRow.CreateCell(3).SetCellValue("班组");
            titleRow.CreateCell(4).SetCellValue("岗位");
            titleRow.CreateCell(5).SetCellValue("职务");
            titleRow.CreateCell(6).SetCellValue("固定分");
            titleRow.CreateCell(7).SetCellValue("奖励分（加分）");
            titleRow.CreateCell(8).SetCellValue("考核分（扣分）");
            titleRow.CreateCell(9).SetCellValue("总得分");
            for(int j = 0; j < 10; j++)
            {
                titleRow.GetCell(j).CellStyle = normalStyle;
            }
            List<Member> _allMembers = getPairedWithMemberAndDic(allMembers);

            for (int i = 0; i < _allMembers.Count; i++)
            {
                IRow dataRow = sheet.CreateRow(i + 2);
                dataRow.CreateCell(0).SetCellValue((i+1).ToString());
                dataRow.CreateCell(1).SetCellValue(_allMembers[i].name);
                dataRow.CreateCell(2).SetCellValue(_allMembers[i].ID);
                dataRow.CreateCell(3).SetCellValue(_allMembers[i].teamName);
                dataRow.CreateCell(4).SetCellValue(_allMembers[i].jobName);
                dataRow.CreateCell(5).SetCellValue(_allMembers[i].postName);
                dataRow.CreateCell(6).SetCellValue(_allMembers[i].basePoint);
                //算分
                dataRow.CreateCell(7).SetCellValue(calculateAddAndMinusPoint(_allMembers[i],allMainData,true));
                dataRow.CreateCell(8).SetCellValue(calculateAddAndMinusPoint(_allMembers[i], allMainData, false));
                dataRow.CreateCell(9).SetCellValue(_allMembers[i].currentPoint);
                for(int k = 0; k < 10; k++)
                {
                    dataRow.GetCell(k).CellStyle = normalStyle;
                }
            }

            //再导入第二个sheet，显示每个人每个月的加减分情况
            ISheet sheetDetails = wbMainData.CreateSheet("详单");
            //弄个标题出来
            IRow row2 = sheetDetails.CreateRow(0);
            row2.CreateCell(0).SetCellValue("加减分明细");
            row2.GetCell(0).CellStyle = normalStyle;
            //序号，姓名，工号，加减分数，加减分条目，加减分详情
            row2.CreateCell(1);
            row2.CreateCell(2);
            row2.CreateCell(3);
            row2.CreateCell(4);
            row2.CreateCell(5);
            sheetDetails.AddMergedRegion(new CellRangeAddress(0, 0, 0, 5));
            //标题行
            IRow titleRowDetail = sheetDetails.CreateRow(1);
            titleRowDetail.CreateCell(0).SetCellValue("序号");
            titleRowDetail.CreateCell(1).SetCellValue("姓名");
            titleRowDetail.CreateCell(2).SetCellValue("工号");
            titleRowDetail.CreateCell(3).SetCellValue("加减分数");
            titleRowDetail.CreateCell(4).SetCellValue("加减分条目");
            titleRowDetail.CreateCell(5).SetCellValue("加减分详情");
            for (int j = 0; j < 6; j++)
            {
                titleRowDetail.GetCell(j).CellStyle = normalStyle;
            }
            int counter = 1;
            for (int i = 0; i < allMainData.Count; i++)
            {
                if (targetDateIsInSelected(allMainData[i].originalDate))
                {
                    IRow dataRow = sheetDetails.CreateRow(counter+1);
                    dataRow.CreateCell(0).SetCellValue(counter.ToString());
                    dataRow.CreateCell(1).SetCellValue(findMemberByID(allMainData[i].targetMemberID));
                    dataRow.CreateCell(2).SetCellValue(allMainData[i].targetMemberID);
                    dataRow.CreateCell(3).SetCellValue(allMainData[i].pointChange);
                    dataRow.CreateCell(4).SetCellValue(findPointControlByID(allMainData[i].targetPointChangeID));
                    dataRow.CreateCell(5).SetCellValue(allMainData[i].pointChangeDetails);
                    for (int k = 0; k < 6; k++)
                    {
                        dataRow.GetCell(k).CellStyle = normalStyle;
                    }
                    counter++;
                }

            }


            //向excel文件中写入数据并保存
            wbMainData.Write(fs);
            fs.Close();
            MessageBox.Show("文件："+title+".xls 已导出至桌面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            //info.WorkingDirectory = Application.StartupPath;
            info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + title + ".xls";

        }

        //把模型数据导出成Excel保存，在关闭窗口时自动保存，注意主表修改格式这里也要修改
        private void SaveMainDataToExcel()
        {
            FileStream fs = File.Create(Application.StartupPath + "\\" + "MainData.data");
            IWorkbook wbMainData = new HSSFWorkbook();
            //创建sheet
            ISheet sheet = wbMainData.CreateSheet("主数据");
            //弄个标题出来
            IRow row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue("ID");
            row.CreateCell(1).SetCellValue("添加时间");
            row.CreateCell(2).SetCellValue("添加账户ID");
            row.CreateCell(3).SetCellValue("目标人员ID");
            row.CreateCell(4).SetCellValue("加减分ID");
            row.CreateCell(5).SetCellValue("加减分详情");
            row.CreateCell(6).SetCellValue("实际加减分");
            row.CreateCell(7).SetCellValue("最后修订时间");
            row.CreateCell(8).SetCellValue("是否删除");

            for(int i = 0; i < allMainData.Count; i++)
            {
                IRow dataRow = sheet.CreateRow(i + 1);
                dataRow.CreateCell(0).SetCellValue(allMainData[i].ID);
                dataRow.CreateCell(1).SetCellValue(allMainData[i].originalDate.ToString());
                dataRow.CreateCell(2).SetCellValue(allMainData[i].createUserID);
                dataRow.CreateCell(3).SetCellValue(allMainData[i].targetMemberID);
                dataRow.CreateCell(4).SetCellValue(allMainData[i].targetPointChangeID);
                dataRow.CreateCell(5).SetCellValue(allMainData[i].pointChangeDetails);
                dataRow.CreateCell(6).SetCellValue(allMainData[i].pointChange);
                dataRow.CreateCell(7).SetCellValue(allMainData[i].revisionTime.ToString());
                dataRow.CreateCell(8).SetCellValue(allMainData[i].hasBeenDeleted);
            }

            //向excel文件中写入数据并保存
            wbMainData.Write(fs);
            fs.Close();

}

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void pointDetailView_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pointDetailView_lv.SelectedItems.Count == 1)
            {
                detail_rtb.Text = "时间：" + pointDetailView_lv.SelectedItems[0].SubItems[4].Text +
    "\n条目：" + pointDetailView_lv.SelectedItems[0].SubItems[3].Text;
            }
            else
            {
                detail_rtb.Text = "";
            }

        }

        //点击条目
        private void memberList_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(memberList_lv.SelectedItems.Count == 1)
            {
                //去右边找到对应的人的条目
                refreshMainListData(allMainData, memberList_lv.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                refreshMainListData(allMainData);
            }
        }

        private void refreshMainData_btn_Click(object sender, EventArgs e)
        {
            refreshMainListData(allMainData);
        }

        private void detail_rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointDetailView_lv_DoubleClick(object sender, EventArgs e)
        {
            EditData();
        }

        //是否按分数排序
        private void orderByPoint_cb_CheckedChanged(object sender, EventArgs e)
        {

            loadBaseData(baseDataWB);
            //在里面方法有控制
            refreshData();
        }

        private void monthlyPicker_dtp_ValueChanged(object sender, EventArgs e)
        {
            refreshData();
        }
        //子窗口回调方法
        //public void outputComplete()
        //{

        //}
        //功能重复 换为导出功能
        private void outputData_btn_Click(object sender, EventArgs e)
        {
            //进入数据统计分析
            //DataAnalyse da = new DataAnalyse(allMainData,allMembers,teamDic,jobDic,postDic);
            //da.Owner = this;
            //da.Show();
            //导出
            OutputMainData();
        }

        private void day_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void date_dtp_ValueChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void month_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void month_dtp_ValueChanged(object sender, EventArgs e)
        {
            checkChanged();
            //港站之星/冠刷新
            getStarAndCrown(0);
        }

        private void threemonth_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void threemonth_year_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanged();
            //港站之星/冠刷新
            getStarAndCrown(1);
        }

        private void threemonth_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanged();
            //港站之星/冠刷新
            getStarAndCrown(1);
        }

        private void sixmonth_year_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void sixmonth_cb_SelectedIndexChanged(object sender, EventArgs e)
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

        private void year_dtp_ValueChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textScroll_Star();
        }

        private void starleaderTimer_Tick(object sender, EventArgs e)
        {
            textScroll_StarLeader();
        }

        private void crownTimer_Tick(object sender, EventArgs e)
        {
            textScroll_Crown();
        }

        //公休
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
