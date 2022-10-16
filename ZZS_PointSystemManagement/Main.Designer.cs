namespace ZZS_PointSystemManagement
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sixmonth_cb = new System.Windows.Forms.ComboBox();
            this.sixmonth_year_cb = new System.Windows.Forms.ComboBox();
            this.threemonth_cb = new System.Windows.Forms.ComboBox();
            this.threemonth_year_cb = new System.Windows.Forms.ComboBox();
            this.year_radioButton = new System.Windows.Forms.RadioButton();
            this.outputData_btn = new CCWin.SkinControl.SkinButton();
            this.sixmonth_radioButton = new System.Windows.Forms.RadioButton();
            this.threemonth_radioButton = new System.Windows.Forms.RadioButton();
            this.year_dtp = new System.Windows.Forms.DateTimePicker();
            this.month_radioButton = new System.Windows.Forms.RadioButton();
            this.month_dtp = new System.Windows.Forms.DateTimePicker();
            this.orderByPoint_cb = new System.Windows.Forms.CheckBox();
            this.teamSelect_cb = new System.Windows.Forms.ComboBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.memberList_lv = new System.Windows.Forms.ListView();
            this.importMemberData_btn = new CCWin.SkinControl.SkinButton();
            this.importData_btn = new CCWin.SkinControl.SkinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.refreshMainData_btn = new CCWin.SkinControl.SkinButton();
            this.label9 = new System.Windows.Forms.Label();
            this.detail_rtb = new System.Windows.Forms.RichTextBox();
            this.pointDetailView_lv = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.add_btn = new CCWin.SkinControl.SkinButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.threeMonth_lbl = new System.Windows.Forms.Label();
            this.monthly_lbl = new System.Windows.Forms.Label();
            this.teamRank_btn = new CCWin.SkinControl.SkinButton();
            this.leaderRank_btn = new CCWin.SkinControl.SkinButton();
            this.memberRank_btn = new CCWin.SkinControl.SkinButton();
            this.crown_team_point_lbl = new System.Windows.Forms.Label();
            this.crownTeam_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.star_leader_point_lb = new System.Windows.Forms.Label();
            this.star_member_point_lb = new System.Windows.Forms.Label();
            this.star_leader_lb = new System.Windows.Forms.Label();
            this.star_member_lb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.starTimer = new System.Windows.Forms.Timer(this.components);
            this.starleaderTimer = new System.Windows.Forms.Timer(this.components);
            this.crownTimer = new System.Windows.Forms.Timer(this.components);
            this.withoutNO26_cb = new System.Windows.Forms.CheckBox();
            this.skinGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.skinGroupBox1.Controls.Add(this.groupBox1);
            this.skinGroupBox1.Controls.Add(this.orderByPoint_cb);
            this.skinGroupBox1.Controls.Add(this.teamSelect_cb);
            this.skinGroupBox1.Controls.Add(this.search_tb);
            this.skinGroupBox1.Controls.Add(this.memberList_lv);
            this.skinGroupBox1.Controls.Add(this.importMemberData_btn);
            this.skinGroupBox1.Controls.Add(this.importData_btn);
            this.skinGroupBox1.Controls.Add(this.label4);
            this.skinGroupBox1.Controls.Add(this.label3);
            this.skinGroupBox1.Controls.Add(this.label1);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.skinGroupBox1.Location = new System.Drawing.Point(42, 76);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(671, 570);
            this.skinGroupBox1.TabIndex = 2;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "人员检索";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withoutNO26_cb);
            this.groupBox1.Controls.Add(this.sixmonth_cb);
            this.groupBox1.Controls.Add(this.sixmonth_year_cb);
            this.groupBox1.Controls.Add(this.threemonth_cb);
            this.groupBox1.Controls.Add(this.threemonth_year_cb);
            this.groupBox1.Controls.Add(this.year_radioButton);
            this.groupBox1.Controls.Add(this.outputData_btn);
            this.groupBox1.Controls.Add(this.sixmonth_radioButton);
            this.groupBox1.Controls.Add(this.threemonth_radioButton);
            this.groupBox1.Controls.Add(this.year_dtp);
            this.groupBox1.Controls.Add(this.month_radioButton);
            this.groupBox1.Controls.Add(this.month_dtp);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(161, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 145);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选方式";
            // 
            // sixmonth_cb
            // 
            this.sixmonth_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sixmonth_cb.FormattingEnabled = true;
            this.sixmonth_cb.Location = new System.Drawing.Point(380, 59);
            this.sixmonth_cb.Name = "sixmonth_cb";
            this.sixmonth_cb.Size = new System.Drawing.Size(79, 28);
            this.sixmonth_cb.TabIndex = 30;
            this.sixmonth_cb.SelectedIndexChanged += new System.EventHandler(this.sixmonth_cb_SelectedIndexChanged);
            // 
            // sixmonth_year_cb
            // 
            this.sixmonth_year_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sixmonth_year_cb.FormattingEnabled = true;
            this.sixmonth_year_cb.Location = new System.Drawing.Point(295, 59);
            this.sixmonth_year_cb.Name = "sixmonth_year_cb";
            this.sixmonth_year_cb.Size = new System.Drawing.Size(79, 28);
            this.sixmonth_year_cb.TabIndex = 29;
            this.sixmonth_year_cb.SelectedIndexChanged += new System.EventHandler(this.sixmonth_year_cb_SelectedIndexChanged);
            // 
            // threemonth_cb
            // 
            this.threemonth_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threemonth_cb.FormattingEnabled = true;
            this.threemonth_cb.Location = new System.Drawing.Point(380, 25);
            this.threemonth_cb.Name = "threemonth_cb";
            this.threemonth_cb.Size = new System.Drawing.Size(79, 28);
            this.threemonth_cb.TabIndex = 28;
            this.threemonth_cb.SelectedIndexChanged += new System.EventHandler(this.threemonth_cb_SelectedIndexChanged);
            // 
            // threemonth_year_cb
            // 
            this.threemonth_year_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threemonth_year_cb.FormattingEnabled = true;
            this.threemonth_year_cb.Location = new System.Drawing.Point(295, 25);
            this.threemonth_year_cb.Name = "threemonth_year_cb";
            this.threemonth_year_cb.Size = new System.Drawing.Size(79, 28);
            this.threemonth_year_cb.TabIndex = 27;
            this.threemonth_year_cb.SelectedIndexChanged += new System.EventHandler(this.threemonth_year_cb_SelectedIndexChanged);
            // 
            // year_radioButton
            // 
            this.year_radioButton.AutoSize = true;
            this.year_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.year_radioButton.Location = new System.Drawing.Point(40, 60);
            this.year_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.year_radioButton.Name = "year_radioButton";
            this.year_radioButton.Size = new System.Drawing.Size(50, 21);
            this.year_radioButton.TabIndex = 25;
            this.year_radioButton.TabStop = true;
            this.year_radioButton.Text = "年度";
            this.year_radioButton.UseVisualStyleBackColor = true;
            this.year_radioButton.CheckedChanged += new System.EventHandler(this.year_radioButton_CheckedChanged);
            // 
            // outputData_btn
            // 
            this.outputData_btn.BackColor = System.Drawing.Color.Transparent;
            this.outputData_btn.BaseColor = System.Drawing.Color.DarkGreen;
            this.outputData_btn.BorderColor = System.Drawing.Color.Green;
            this.outputData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.outputData_btn.DownBack = null;
            this.outputData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputData_btn.Location = new System.Drawing.Point(63, 96);
            this.outputData_btn.MouseBack = null;
            this.outputData_btn.Name = "outputData_btn";
            this.outputData_btn.NormlBack = null;
            this.outputData_btn.Size = new System.Drawing.Size(260, 42);
            this.outputData_btn.TabIndex = 9;
            this.outputData_btn.Text = "选定数据导出";
            this.outputData_btn.UseVisualStyleBackColor = false;
            this.outputData_btn.Click += new System.EventHandler(this.outputData_btn_Click);
            // 
            // sixmonth_radioButton
            // 
            this.sixmonth_radioButton.AutoSize = true;
            this.sixmonth_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sixmonth_radioButton.Location = new System.Drawing.Point(236, 61);
            this.sixmonth_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.sixmonth_radioButton.Name = "sixmonth_radioButton";
            this.sixmonth_radioButton.Size = new System.Drawing.Size(50, 21);
            this.sixmonth_radioButton.TabIndex = 26;
            this.sixmonth_radioButton.TabStop = true;
            this.sixmonth_radioButton.Text = "半年";
            this.sixmonth_radioButton.UseVisualStyleBackColor = true;
            this.sixmonth_radioButton.CheckedChanged += new System.EventHandler(this.sixmonth_radioButton_CheckedChanged);
            // 
            // threemonth_radioButton
            // 
            this.threemonth_radioButton.AutoSize = true;
            this.threemonth_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.threemonth_radioButton.Location = new System.Drawing.Point(236, 29);
            this.threemonth_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.threemonth_radioButton.Name = "threemonth_radioButton";
            this.threemonth_radioButton.Size = new System.Drawing.Size(50, 21);
            this.threemonth_radioButton.TabIndex = 24;
            this.threemonth_radioButton.TabStop = true;
            this.threemonth_radioButton.Text = "季度";
            this.threemonth_radioButton.UseVisualStyleBackColor = true;
            this.threemonth_radioButton.CheckedChanged += new System.EventHandler(this.threemonth_radioButton_CheckedChanged);
            // 
            // year_dtp
            // 
            this.year_dtp.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.year_dtp.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.year_dtp.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.year_dtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.year_dtp.Location = new System.Drawing.Point(99, 59);
            this.year_dtp.Name = "year_dtp";
            this.year_dtp.Size = new System.Drawing.Size(128, 26);
            this.year_dtp.TabIndex = 13;
            this.year_dtp.ValueChanged += new System.EventHandler(this.year_dtp_ValueChanged);
            // 
            // month_radioButton
            // 
            this.month_radioButton.AutoSize = true;
            this.month_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month_radioButton.Location = new System.Drawing.Point(40, 26);
            this.month_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.month_radioButton.Name = "month_radioButton";
            this.month_radioButton.Size = new System.Drawing.Size(50, 21);
            this.month_radioButton.TabIndex = 23;
            this.month_radioButton.TabStop = true;
            this.month_radioButton.Text = "月度";
            this.month_radioButton.UseVisualStyleBackColor = true;
            this.month_radioButton.CheckedChanged += new System.EventHandler(this.month_radioButton_CheckedChanged);
            // 
            // month_dtp
            // 
            this.month_dtp.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.month_dtp.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.month_dtp.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.month_dtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month_dtp.Location = new System.Drawing.Point(99, 25);
            this.month_dtp.Name = "month_dtp";
            this.month_dtp.Size = new System.Drawing.Size(128, 26);
            this.month_dtp.TabIndex = 9;
            this.month_dtp.ValueChanged += new System.EventHandler(this.month_dtp_ValueChanged);
            // 
            // orderByPoint_cb
            // 
            this.orderByPoint_cb.AutoSize = true;
            this.orderByPoint_cb.Checked = true;
            this.orderByPoint_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.orderByPoint_cb.Location = new System.Drawing.Point(27, 423);
            this.orderByPoint_cb.Name = "orderByPoint_cb";
            this.orderByPoint_cb.Size = new System.Drawing.Size(112, 24);
            this.orderByPoint_cb.TabIndex = 15;
            this.orderByPoint_cb.Text = "按照分数排序";
            this.orderByPoint_cb.UseVisualStyleBackColor = true;
            this.orderByPoint_cb.CheckedChanged += new System.EventHandler(this.orderByPoint_cb_CheckedChanged);
            // 
            // teamSelect_cb
            // 
            this.teamSelect_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamSelect_cb.FormattingEnabled = true;
            this.teamSelect_cb.Location = new System.Drawing.Point(83, 29);
            this.teamSelect_cb.Name = "teamSelect_cb";
            this.teamSelect_cb.Size = new System.Drawing.Size(135, 28);
            this.teamSelect_cb.TabIndex = 14;
            this.teamSelect_cb.SelectedIndexChanged += new System.EventHandler(this.teamSelect_cb_SelectedIndexChanged);
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(519, 29);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(128, 26);
            this.search_tb.TabIndex = 12;
            this.search_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // memberList_lv
            // 
            this.memberList_lv.HideSelection = false;
            this.memberList_lv.Location = new System.Drawing.Point(16, 67);
            this.memberList_lv.Name = "memberList_lv";
            this.memberList_lv.Size = new System.Drawing.Size(631, 333);
            this.memberList_lv.TabIndex = 11;
            this.memberList_lv.UseCompatibleStateImageBehavior = false;
            this.memberList_lv.SelectedIndexChanged += new System.EventHandler(this.memberList_lv_SelectedIndexChanged);
            // 
            // importMemberData_btn
            // 
            this.importMemberData_btn.BackColor = System.Drawing.Color.Transparent;
            this.importMemberData_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.importMemberData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.importMemberData_btn.DownBack = null;
            this.importMemberData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importMemberData_btn.Location = new System.Drawing.Point(27, 509);
            this.importMemberData_btn.MouseBack = null;
            this.importMemberData_btn.Name = "importMemberData_btn";
            this.importMemberData_btn.NormlBack = null;
            this.importMemberData_btn.Size = new System.Drawing.Size(112, 46);
            this.importMemberData_btn.TabIndex = 10;
            this.importMemberData_btn.Text = "导入字典数据";
            this.importMemberData_btn.UseVisualStyleBackColor = false;
            this.importMemberData_btn.Click += new System.EventHandler(this.importMemberData_btn_Click);
            // 
            // importData_btn
            // 
            this.importData_btn.BackColor = System.Drawing.Color.Transparent;
            this.importData_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.importData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.importData_btn.DownBack = null;
            this.importData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importData_btn.Location = new System.Drawing.Point(27, 453);
            this.importData_btn.MouseBack = null;
            this.importData_btn.Name = "importData_btn";
            this.importData_btn.NormlBack = null;
            this.importData_btn.Size = new System.Drawing.Size(112, 46);
            this.importData_btn.TabIndex = 8;
            this.importData_btn.Text = "导入积分数据";
            this.importData_btn.UseVisualStyleBackColor = false;
            this.importData_btn.Click += new System.EventHandler(this.importData_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(448, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "搜索人员";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "班组选择";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.skinGroupBox2.Controls.Add(this.refreshMainData_btn);
            this.skinGroupBox2.Controls.Add(this.label9);
            this.skinGroupBox2.Controls.Add(this.detail_rtb);
            this.skinGroupBox2.Controls.Add(this.pointDetailView_lv);
            this.skinGroupBox2.Controls.Add(this.label2);
            this.skinGroupBox2.Controls.Add(this.skinButton2);
            this.skinGroupBox2.Controls.Add(this.skinButton1);
            this.skinGroupBox2.Controls.Add(this.add_btn);
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.skinGroupBox2.Location = new System.Drawing.Point(731, 76);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(404, 570);
            this.skinGroupBox2.TabIndex = 3;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "积分操作";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // refreshMainData_btn
            // 
            this.refreshMainData_btn.BackColor = System.Drawing.Color.Transparent;
            this.refreshMainData_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.refreshMainData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.refreshMainData_btn.DownBack = null;
            this.refreshMainData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshMainData_btn.Location = new System.Drawing.Point(263, 29);
            this.refreshMainData_btn.MouseBack = null;
            this.refreshMainData_btn.Name = "refreshMainData_btn";
            this.refreshMainData_btn.NormlBack = null;
            this.refreshMainData_btn.Size = new System.Drawing.Size(112, 28);
            this.refreshMainData_btn.TabIndex = 15;
            this.refreshMainData_btn.Text = "显示全部条目";
            this.refreshMainData_btn.UseVisualStyleBackColor = false;
            this.refreshMainData_btn.Click += new System.EventHandler(this.refreshMainData_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(24, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "详情";
            // 
            // detail_rtb
            // 
            this.detail_rtb.Location = new System.Drawing.Point(28, 320);
            this.detail_rtb.Name = "detail_rtb";
            this.detail_rtb.ReadOnly = true;
            this.detail_rtb.Size = new System.Drawing.Size(348, 163);
            this.detail_rtb.TabIndex = 9;
            this.detail_rtb.Text = "";
            this.detail_rtb.TextChanged += new System.EventHandler(this.detail_rtb_TextChanged);
            // 
            // pointDetailView_lv
            // 
            this.pointDetailView_lv.HideSelection = false;
            this.pointDetailView_lv.Location = new System.Drawing.Point(28, 67);
            this.pointDetailView_lv.Name = "pointDetailView_lv";
            this.pointDetailView_lv.Size = new System.Drawing.Size(348, 218);
            this.pointDetailView_lv.TabIndex = 8;
            this.pointDetailView_lv.UseCompatibleStateImageBehavior = false;
            this.pointDetailView_lv.SelectedIndexChanged += new System.EventHandler(this.pointDetailView_lv_SelectedIndexChanged);
            this.pointDetailView_lv.DoubleClick += new System.EventHandler(this.pointDetailView_lv_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "积分变动情况";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.OrangeRed;
            this.skinButton2.BorderColor = System.Drawing.Color.OrangeRed;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.skinButton2.Location = new System.Drawing.Point(263, 504);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(112, 46);
            this.skinButton2.TabIndex = 7;
            this.skinButton2.Text = "删除";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.DeepPink;
            this.skinButton1.BorderColor = System.Drawing.Color.DeepPink;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.skinButton1.Location = new System.Drawing.Point(145, 504);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(112, 46);
            this.skinButton1.TabIndex = 6;
            this.skinButton1.Text = "修改";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.add_btn.DownBack = null;
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_btn.Location = new System.Drawing.Point(27, 504);
            this.add_btn.MouseBack = null;
            this.add_btn.Name = "add_btn";
            this.add_btn.NormlBack = null;
            this.add_btn.Size = new System.Drawing.Size(112, 46);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "新增条目";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(1339, 662);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Build 20221016";
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox3.Controls.Add(this.threeMonth_lbl);
            this.skinGroupBox3.Controls.Add(this.monthly_lbl);
            this.skinGroupBox3.Controls.Add(this.teamRank_btn);
            this.skinGroupBox3.Controls.Add(this.leaderRank_btn);
            this.skinGroupBox3.Controls.Add(this.memberRank_btn);
            this.skinGroupBox3.Controls.Add(this.crown_team_point_lbl);
            this.skinGroupBox3.Controls.Add(this.crownTeam_lbl);
            this.skinGroupBox3.Controls.Add(this.label11);
            this.skinGroupBox3.Controls.Add(this.star_leader_point_lb);
            this.skinGroupBox3.Controls.Add(this.star_member_point_lb);
            this.skinGroupBox3.Controls.Add(this.star_leader_lb);
            this.skinGroupBox3.Controls.Add(this.star_member_lb);
            this.skinGroupBox3.Controls.Add(this.label12);
            this.skinGroupBox3.Controls.Add(this.label13);
            this.skinGroupBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.skinGroupBox3.Location = new System.Drawing.Point(1141, 76);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(322, 570);
            this.skinGroupBox3.TabIndex = 21;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "评比";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // threeMonth_lbl
            // 
            this.threeMonth_lbl.AutoSize = true;
            this.threeMonth_lbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.threeMonth_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.threeMonth_lbl.Location = new System.Drawing.Point(111, 394);
            this.threeMonth_lbl.Name = "threeMonth_lbl";
            this.threeMonth_lbl.Size = new System.Drawing.Size(13, 19);
            this.threeMonth_lbl.TabIndex = 29;
            this.threeMonth_lbl.Text = " ";
            // 
            // monthly_lbl
            // 
            this.monthly_lbl.AutoSize = true;
            this.monthly_lbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthly_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.monthly_lbl.Location = new System.Drawing.Point(121, 45);
            this.monthly_lbl.Name = "monthly_lbl";
            this.monthly_lbl.Size = new System.Drawing.Size(91, 19);
            this.monthly_lbl.TabIndex = 28;
            this.monthly_lbl.Text = "2022年10月";
            // 
            // teamRank_btn
            // 
            this.teamRank_btn.BackColor = System.Drawing.Color.Transparent;
            this.teamRank_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.teamRank_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.teamRank_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.teamRank_btn.DownBack = null;
            this.teamRank_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teamRank_btn.Location = new System.Drawing.Point(96, 495);
            this.teamRank_btn.MouseBack = null;
            this.teamRank_btn.Name = "teamRank_btn";
            this.teamRank_btn.NormlBack = null;
            this.teamRank_btn.Size = new System.Drawing.Size(129, 38);
            this.teamRank_btn.TabIndex = 27;
            this.teamRank_btn.Text = "班组季度排名";
            this.teamRank_btn.UseVisualStyleBackColor = false;
            // 
            // leaderRank_btn
            // 
            this.leaderRank_btn.BackColor = System.Drawing.Color.Transparent;
            this.leaderRank_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.leaderRank_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.leaderRank_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.leaderRank_btn.DownBack = null;
            this.leaderRank_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leaderRank_btn.Location = new System.Drawing.Point(111, 310);
            this.leaderRank_btn.MouseBack = null;
            this.leaderRank_btn.Name = "leaderRank_btn";
            this.leaderRank_btn.NormlBack = null;
            this.leaderRank_btn.Size = new System.Drawing.Size(109, 35);
            this.leaderRank_btn.TabIndex = 26;
            this.leaderRank_btn.Text = "班组长排名";
            this.leaderRank_btn.UseVisualStyleBackColor = false;
            // 
            // memberRank_btn
            // 
            this.memberRank_btn.BackColor = System.Drawing.Color.Transparent;
            this.memberRank_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.memberRank_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.memberRank_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.memberRank_btn.DownBack = null;
            this.memberRank_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.memberRank_btn.Location = new System.Drawing.Point(106, 156);
            this.memberRank_btn.MouseBack = null;
            this.memberRank_btn.Name = "memberRank_btn";
            this.memberRank_btn.NormlBack = null;
            this.memberRank_btn.Size = new System.Drawing.Size(109, 35);
            this.memberRank_btn.TabIndex = 20;
            this.memberRank_btn.Text = "评选排名";
            this.memberRank_btn.UseVisualStyleBackColor = false;
            // 
            // crown_team_point_lbl
            // 
            this.crown_team_point_lbl.AutoSize = true;
            this.crown_team_point_lbl.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crown_team_point_lbl.ForeColor = System.Drawing.Color.DeepPink;
            this.crown_team_point_lbl.Location = new System.Drawing.Point(126, 447);
            this.crown_team_point_lbl.Name = "crown_team_point_lbl";
            this.crown_team_point_lbl.Size = new System.Drawing.Size(70, 24);
            this.crown_team_point_lbl.TabIndex = 25;
            this.crown_team_point_lbl.Text = "106分";
            // 
            // crownTeam_lbl
            // 
            this.crownTeam_lbl.AutoSize = true;
            this.crownTeam_lbl.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crownTeam_lbl.ForeColor = System.Drawing.Color.DeepPink;
            this.crownTeam_lbl.Location = new System.Drawing.Point(109, 423);
            this.crownTeam_lbl.Name = "crownTeam_lbl";
            this.crownTeam_lbl.Size = new System.Drawing.Size(106, 24);
            this.crownTeam_lbl.TabIndex = 24;
            this.crownTeam_lbl.Text = "选择季度";
            this.crownTeam_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(126, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "港站之冠";
            // 
            // star_leader_point_lb
            // 
            this.star_leader_point_lb.AutoSize = true;
            this.star_leader_point_lb.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_leader_point_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_leader_point_lb.Location = new System.Drawing.Point(127, 263);
            this.star_leader_point_lb.Name = "star_leader_point_lb";
            this.star_leader_point_lb.Size = new System.Drawing.Size(70, 24);
            this.star_leader_point_lb.TabIndex = 22;
            this.star_leader_point_lb.Text = "165分";
            // 
            // star_member_point_lb
            // 
            this.star_member_point_lb.AutoSize = true;
            this.star_member_point_lb.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_member_point_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_member_point_lb.Location = new System.Drawing.Point(126, 109);
            this.star_member_point_lb.Name = "star_member_point_lb";
            this.star_member_point_lb.Size = new System.Drawing.Size(70, 24);
            this.star_member_point_lb.TabIndex = 21;
            this.star_member_point_lb.Text = "112分";
            // 
            // star_leader_lb
            // 
            this.star_leader_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.star_leader_lb.AutoSize = true;
            this.star_leader_lb.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_leader_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_leader_lb.Location = new System.Drawing.Point(133, 239);
            this.star_leader_lb.Name = "star_leader_lb";
            this.star_leader_lb.Size = new System.Drawing.Size(58, 24);
            this.star_leader_lb.TabIndex = 20;
            this.star_leader_lb.Text = "任远";
            this.star_leader_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // star_member_lb
            // 
            this.star_member_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.star_member_lb.AutoSize = true;
            this.star_member_lb.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_member_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_member_lb.Location = new System.Drawing.Point(127, 85);
            this.star_member_lb.Name = "star_member_lb";
            this.star_member_lb.Size = new System.Drawing.Size(142, 24);
            this.star_member_lb.TabIndex = 19;
            this.star_member_lb.Text = "汪洋,陈进度";
            this.star_member_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(127, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "港站之星";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(107, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "港站之星-班组长";
            // 
            // starTimer
            // 
            this.starTimer.Interval = 300;
            this.starTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // starleaderTimer
            // 
            this.starleaderTimer.Interval = 300;
            this.starleaderTimer.Tick += new System.EventHandler(this.starleaderTimer_Tick);
            // 
            // crownTimer
            // 
            this.crownTimer.Interval = 300;
            this.crownTimer.Tick += new System.EventHandler(this.crownTimer_Tick);
            // 
            // withoutNO26_cb
            // 
            this.withoutNO26_cb.AutoSize = true;
            this.withoutNO26_cb.Location = new System.Drawing.Point(329, 106);
            this.withoutNO26_cb.Name = "withoutNO26_cb";
            this.withoutNO26_cb.Size = new System.Drawing.Size(140, 24);
            this.withoutNO26_cb.TabIndex = 31;
            this.withoutNO26_cb.Text = "公休除月度不统计";
            this.withoutNO26_cb.UseVisualStyleBackColor = true;
            this.withoutNO26_cb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1510, 707);
            this.Controls.Add(this.skinGroupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "郑州航空港站积分制管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton add_btn;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinButton importMemberData_btn;
        private CCWin.SkinControl.SkinButton outputData_btn;
        private CCWin.SkinControl.SkinButton importData_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView memberList_lv;
        private System.Windows.Forms.ListView pointDetailView_lv;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.ComboBox teamSelect_cb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox detail_rtb;
        private CCWin.SkinControl.SkinButton refreshMainData_btn;
        private System.Windows.Forms.CheckBox orderByPoint_cb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sixmonth_cb;
        private System.Windows.Forms.ComboBox sixmonth_year_cb;
        private System.Windows.Forms.ComboBox threemonth_cb;
        private System.Windows.Forms.ComboBox threemonth_year_cb;
        private System.Windows.Forms.RadioButton year_radioButton;
        private System.Windows.Forms.RadioButton sixmonth_radioButton;
        private System.Windows.Forms.RadioButton threemonth_radioButton;
        private System.Windows.Forms.DateTimePicker year_dtp;
        private System.Windows.Forms.RadioButton month_radioButton;
        private System.Windows.Forms.DateTimePicker month_dtp;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private CCWin.SkinControl.SkinButton teamRank_btn;
        private CCWin.SkinControl.SkinButton leaderRank_btn;
        private CCWin.SkinControl.SkinButton memberRank_btn;
        private System.Windows.Forms.Label crown_team_point_lbl;
        private System.Windows.Forms.Label crownTeam_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label star_leader_point_lb;
        private System.Windows.Forms.Label star_member_point_lb;
        private System.Windows.Forms.Label star_leader_lb;
        private System.Windows.Forms.Label star_member_lb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer starTimer;
        private System.Windows.Forms.Timer starleaderTimer;
        private System.Windows.Forms.Timer crownTimer;
        private System.Windows.Forms.Label threeMonth_lbl;
        private System.Windows.Forms.Label monthly_lbl;
        private System.Windows.Forms.CheckBox withoutNO26_cb;
    }
}

