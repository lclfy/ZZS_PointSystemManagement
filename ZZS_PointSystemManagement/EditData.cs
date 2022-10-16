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
    public partial class EditData : Skin_Mac
    {
        //0新建，1修改
        public int currentMode = -1;
        public MainData selectedData;
        //班组字典，姓名字典，加减分条目字典
        public List<Member> allMembers;
        public List<CustomList> allTeams;
        public List<PointControl> allPointControls;
        //新的数据
        public MainData targetData;
        //模式，新增还是编辑
        int mode;
        //设置使用的账号
        public UserData userID;
        //自己打的详情，避免被冲掉了
        string tempText;

        public EditData(MainData _m,int _mode,List<Member> _allmember,List<CustomList> _allteam,List<PointControl> _pointControls,UserData _udID)
        {

            InitializeComponent();
            selectedData = _m;
            currentMode = mode;
            allMembers = _allmember;
            allTeams = _allteam;
            allPointControls = _pointControls;
            mode = _mode;
            userID = _udID;
            tempText = "";
            //设置按钮形态
            //save_btn.DialogResult = DialogResult.OK;
            //close_btn.DialogResult = DialogResult.Cancel;
            //如果是修改的话，人就不能变了，其他东西可以变
            if (mode == 1)
            {
                memberSelect_cb.Enabled = false;
                teamSelect_cb.Enabled = false;
            }
        }

        private void EditData_Load(object sender, EventArgs e)
        {
            //班组默认显示“全部”
            teamSelect_cb.Items.Add("全部");
            teamSelect_cb.SelectedIndex = 0;
            loadUI();
        }

        private void loadUI()
        {
            //班组字典
            foreach(CustomList _model in allTeams)
            {
                teamSelect_cb.Items.Add(_model.ID + "." + _model.name);
            }
            //人名字典
            foreach(Member _model in allMembers)
            {
                memberSelect_cb.Items.Add(_model.name + "-" + _model.ID);
            }
            //条目字典
            foreach(PointControl _model in allPointControls)
            {
                string text = _model.ID + "." + _model.name + ",";

                if (_model.defaultPointChange.ToString().Contains("-"))
                {
                    text = text + "扣" + _model.defaultPointChange.ToString().Replace("-","") + "分";
                }
                else
                {
                    text = text + "加" + _model.defaultPointChange.ToString() + "分";
                }
                pointChange_lb.Items.Add(text);
            }
            //如果新增的时候在主界面选了人名，就把人名填上
            memberSelect_cb.Text = findMemberByID(selectedData.targetMemberID) + "-" + selectedData.targetMemberID;
            //如果是修改的话，把所有东西都提前选好
            if (mode == 1)
            {
                //时间
                try
                {
                    timePicker_dtp.Value = selectedData.originalDate;
                }catch(Exception e)
                {
                    timePicker_dtp.Value = DateTime.Now;
                }
                //选中的加减分ID
                int targetPointChangeID = 0;
                int.TryParse(selectedData.targetPointChangeID, out targetPointChangeID);
                pointChange_lb.SelectedIndex = targetPointChangeID - 1;
                //加减分详情
                detailText_tb.Text = selectedData.pointChangeDetails;
                //加减分数
                pointChangeInput_tb.Text = selectedData.pointChange.ToString();
            }
        }

        //通过工号找姓名,再反过来
        private string findMemberByID(string id)
        {
            string name = "";
            foreach (Member _model in allMembers)
            {
                if (_model.ID.Equals(id))
                {
                    name = _model.name;
                    break;
                }
            }
            return name;
        }
        //从班组选出来对应的人
        private void findMemberListByTeam(string teamID)
        {
            memberSelect_cb.Items.Clear();
            //人名字典
            foreach (Member _model in allMembers)
            {
                if(_model.teamID.Equals(teamID))
                    memberSelect_cb.Items.Add(_model.name + "-" + _model.ID);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //校验一下有没有选择人，选择内容，输入正确的分数
            if(memberSelect_cb.SelectedItem == null ||
                memberSelect_cb.SelectedItem.ToString().Trim().Length == 0)
            {
                MessageBox.Show("请选择加减分的人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(pointChange_lb.SelectedItem == null)
            {
                MessageBox.Show("请选择加减分项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pointChangeDetail_tb.Text.Length == 0)
            {
                MessageBox.Show("请填写加减分详情", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pointChangeInput_tb.Text.Length == 0)
            {
                MessageBox.Show("请填写加减分分数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double temp = 1000;
            double.TryParse(pointChangeInput_tb.Text, out temp);
            if(temp == 1000)
            {
                MessageBox.Show("填写的加减分分数格式有误，仅支持数字，小数点，+号，-号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //开始保存工作
            save(selectedData);
        }

        private void save(MainData targetData)
        {
            //新建
            if(mode == 0)
            {
                targetData = new MainData();
                string ID = DateTime.Now.ToString("yyMMddHHmmss") + memberSelect_cb.SelectedItem.ToString().Trim().Split('-')[1];
                targetData.ID = ID;
                targetData.originalDate = timePicker_dtp.Value;
                targetData.createUserID = userID.ID;
                targetData.targetMemberID = memberSelect_cb.SelectedItem.ToString().Trim().Split('-')[1];
                targetData.targetPointChangeID = pointChange_lb.SelectedItem.ToString().Split('.')[0];
                targetData.pointChangeDetails = detailText_tb.Text;
                targetData.pointChange = double.Parse(pointChangeInput_tb.Text);
                targetData.revisionTime = DateTime.Now;
                targetData.hasBeenDeleted = false;
            }
            else
            {
                targetData.originalDate = timePicker_dtp.Value;
                targetData.targetPointChangeID = pointChange_lb.SelectedItem.ToString().Split('.')[0];
                targetData.pointChangeDetails = detailText_tb.Text;
                targetData.pointChange = double.Parse(pointChangeInput_tb.Text);
                targetData.revisionTime = DateTime.Now;
                targetData.hasBeenDeleted = false;
            }
            //直接传回去保存
            Main mainForm = (Main)this.Owner;
            mainForm.EditComplete(targetData, mode);
            this.Close();
        }

        private void pointChange_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pointChange_lb.SelectedItem != null)
            {
                pointChangeDetail_tb.Text = pointChange_lb.SelectedItem.ToString();
                pointChangeInput_tb.Text = pointChange_lb.SelectedItem.ToString().Split(',')[1].Replace("分", "").Replace("加", "+").Replace("扣", "-");
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pointChangeDetail_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void detailText_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamSelect_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(teamSelect_cb.SelectedItem != null)
            {
                if (teamSelect_cb.SelectedItem.ToString().Contains("全部"))
                {
                    //人名字典
                    foreach (Member _model in allMembers)
                    {
                        memberSelect_cb.Items.Add(_model.name + "-" + _model.ID);
                    }
                }
                else
                {
                    findMemberListByTeam(teamSelect_cb.SelectedItem.ToString().Split('.')[0]);
                }

            }
        }
    }
}
