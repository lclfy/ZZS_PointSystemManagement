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
        }

        private void Main_Load(object sender, EventArgs e)
        {
            initList();
            initMonthlyDateTimePicker();
            //具体班组选框在添加源数据时添加内容
            teamSelect_cb.Items.Add("全部");
            teamSelect_cb.SelectedIndex = 0;
            //读取文件
            baseDataWB = loadExcel("\\BaseData.data");
            MainDataWB = loadExcel("\\MainData.data");
            loadBaseData(baseDataWB);
            loadStatisticData(MainDataWB);
            allMembers = getPairedWithMemberAndDic(allMembers);
            //refreshData:包含三个方法，更新所有人的分数，更新成员表UI，更新积分变动表UI
            refreshData();
        }

        private void initMonthlyDateTimePicker()
        {
            monthlyPicker_dtp.Format = DateTimePickerFormat.Custom;
            monthlyPicker_dtp.CustomFormat = "yyyy年MMMM";
            monthlyPicker_dtp.ShowUpDown = true;
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

        private void importBaseData()
        {

        }

        //导入人员数据，导入动态数据时用到的选框
        private void SelectPath(int mode)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();   //显示选择文件对话框 
            openFileDialog1.Filter = "Excel 2003 文件 (*.xls)|*.xls";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExcelFile = openFileDialog1.FileName;
            }
        }

        //获取excel
        private IWorkbook loadExcel(string fileType)
        {
            //fileType:base,statistic两种
            //读取文件
            IWorkbook workBook;
            string fileName = Application.StartupPath + fileType;
            baseDataFileName = fileName;
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            try
            {
                workBook = new HSSFWorkbook(fileStream);  //xlsx数据读入workbook  
                if (workBook == null)
                {
                    MessageBox.Show("读取数据时出现错误\n" + fileName + "\n错误内容：", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
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
                    MessageBox.Show("读取单项数据时出现错误，是否自动创建新数据？\n" + fileName + "\n错误内容：" + e.ToString().Split('在')[0], "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return new HSSFWorkbook();
                }
                else
                {
                    MessageBox.Show("读取名单数据时出现错误\n" + fileName + "\n错误内容：" + e.ToString().Split('在')[0], "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }

            }
        }

        //读基础数据
        private void loadBaseData(IWorkbook WorkBook)
        {
            //偷懒。。在这里面更新班组列表了。。
            teamSelect_cb.Items.Clear();
            teamSelect_cb.Items.Add("全部");
            teamSelect_cb.SelectedIndex = 0;
            if (WorkBook == null)
            {
                return;
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
            foreach(ISheet sheet in allSheets)
            {
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
                        if(row.GetCell(1) != null && row.GetCell(1).ToString().Trim().Length != 0)
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
        }

        //是否在选定月份日期内
        private bool DateIsInTargetMonth(DateTime targetDT)
        {
            DateTime selectedDate = monthlyPicker_dtp.Value;
            DateTime dtStart = Convert.ToDateTime(selectedDate.AddMonths(-1).Year.ToString() + "/" + (selectedDate.AddMonths(-1).Month - 1).ToString() + "/26");
            DateTime dtStop = Convert.ToDateTime(selectedDate.Year.ToString() + "/" + (selectedDate.Month).ToString() + "/25");
            return targetDT.CompareTo(dtStart) >= 0 && targetDT.CompareTo(dtStop) <= 0;
        }
        //同步计算所有人分数
        private void updateMembersPoint(List<Member> _allMembers,List<MainData> _allMainData,DateTime selectedDate)
        {
            //日期为上月26日至选定月份的25日
            for (int i =0;i< _allMembers.Count; i++)
            {
                _allMembers[i].currentPoint = _allMembers[i].basePoint;
                foreach (MainData _model in _allMainData)
                {
                    if(DateIsInTargetMonth(_model.originalDate))
                    {
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

        }

        //读动态数据
        private void loadStatisticData(IWorkbook WorkBook)
        {
            if (WorkBook == null)
            {
                return;
            }
            ISheet sheet = WorkBook.GetSheetAt(0);
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
        }

        //在字典中匹配输入的基础数据与ID，匹配基础分和人员
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

                        _allMembers[i].basePoint = temp;
                        _allMembers[i].currentPoint = temp;
                    }

                }
            }
            return _allMembers;
        }
        //刷新数据操作
        private void refreshData()
        {
            //加上大家的分数，排序勾上的话会进行排序,按选择的月份进行显示
            updateMembersPoint(allMembers, allMainData,monthlyPicker_dtp.Value);
            refreshMainListData(allMainData);
            refreshMemberListData(allMembers);
        }
        //刷新显示
        private void refreshMemberListData(List<Member> _allMembers,string selectedTeamID="",string searchedMember = "")
        {
            memberList_lv.Items.Clear();
            memberList_lv.Groups.Clear();
            this.memberList_lv.BeginUpdate();
            int counter = 1;
            foreach(Member _m in _allMembers)
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

        //刷新单项列表显示
        private void refreshMainListData(List<MainData> _mainData,string targetMemberID = "")
        {
            pointDetailView_lv.Items.Clear();
            pointDetailView_lv.Groups.Clear();
            this.pointDetailView_lv.BeginUpdate();
            int counter = 1;
            foreach (MainData _m in _mainData)
            {
                if (DateIsInTargetMonth(_m.originalDate))
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
        }
        //导入单项数据
        private void importData_btn_Click(object sender, EventArgs e)
        {
            SelectPath(0);

        }

        //导入人员数据
        private void importMemberData_btn_Click(object sender, EventArgs e)
        {
            SelectPath(1);
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
            SaveMainDataToExcel();
            base.OnClosing(e);
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
            allMembers = getPairedWithMemberAndDic(allMembers);
            //在里面方法有控制
            refreshData();
        }

        private void monthlyPicker_dtp_ValueChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
