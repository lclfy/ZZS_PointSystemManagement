namespace ZZS_PointSystemManagement
{
    partial class DataAnalyse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.month_dtp = new System.Windows.Forms.DateTimePicker();
            this.teamSelect_cb = new System.Windows.Forms.ComboBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.memberList_lv = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.year_dtp = new System.Windows.Forms.DateTimePicker();
            this.date_dtp = new System.Windows.Forms.DateTimePicker();
            this.threemonth_radioButton = new System.Windows.Forms.RadioButton();
            this.month_radioButton = new System.Windows.Forms.RadioButton();
            this.day_radioButton = new System.Windows.Forms.RadioButton();
            this.year_radioButton = new System.Windows.Forms.RadioButton();
            this.sixmonth_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.star_member_lb = new System.Windows.Forms.Label();
            this.star_leader_lb = new System.Windows.Forms.Label();
            this.star_member_point_lb = new System.Windows.Forms.Label();
            this.star_leader_point_lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputData_btn = new CCWin.SkinControl.SkinButton();
            this.memberRank_btn = new CCWin.SkinControl.SkinButton();
            this.leaderRank_btn = new CCWin.SkinControl.SkinButton();
            this.teamRank_btn = new CCWin.SkinControl.SkinButton();
            this.selectedPicker_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.threemonth_year_cb = new System.Windows.Forms.ComboBox();
            this.threemonth_cb = new System.Windows.Forms.ComboBox();
            this.sixmonth_cb = new System.Windows.Forms.ComboBox();
            this.sixmonth_year_cb = new System.Windows.Forms.ComboBox();
            this.skinGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.skinGroupBox1.Controls.Add(this.outputData_btn);
            this.skinGroupBox1.Controls.Add(this.groupBox1);
            this.skinGroupBox1.Controls.Add(this.teamSelect_cb);
            this.skinGroupBox1.Controls.Add(this.search_tb);
            this.skinGroupBox1.Controls.Add(this.memberList_lv);
            this.skinGroupBox1.Controls.Add(this.label4);
            this.skinGroupBox1.Controls.Add(this.label3);
            this.skinGroupBox1.Controls.Add(this.label1);
            this.skinGroupBox1.Controls.Add(this.skinGroupBox2);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.skinGroupBox1.Location = new System.Drawing.Point(34, 57);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(1019, 570);
            this.skinGroupBox1.TabIndex = 3;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "人员检索";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // month_dtp
            // 
            this.month_dtp.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.month_dtp.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.month_dtp.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.month_dtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month_dtp.Location = new System.Drawing.Point(129, 57);
            this.month_dtp.Name = "month_dtp";
            this.month_dtp.Size = new System.Drawing.Size(128, 26);
            this.month_dtp.TabIndex = 9;
            this.month_dtp.ValueChanged += new System.EventHandler(this.month_dtp_ValueChanged);
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
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // memberList_lv
            // 
            this.memberList_lv.HideSelection = false;
            this.memberList_lv.Location = new System.Drawing.Point(16, 67);
            this.memberList_lv.Name = "memberList_lv";
            this.memberList_lv.Size = new System.Drawing.Size(631, 424);
            this.memberList_lv.TabIndex = 11;
            this.memberList_lv.UseCompatibleStateImageBehavior = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sixmonth_cb);
            this.groupBox1.Controls.Add(this.sixmonth_year_cb);
            this.groupBox1.Controls.Add(this.threemonth_cb);
            this.groupBox1.Controls.Add(this.threemonth_year_cb);
            this.groupBox1.Controls.Add(this.year_radioButton);
            this.groupBox1.Controls.Add(this.sixmonth_radioButton);
            this.groupBox1.Controls.Add(this.date_dtp);
            this.groupBox1.Controls.Add(this.threemonth_radioButton);
            this.groupBox1.Controls.Add(this.year_dtp);
            this.groupBox1.Controls.Add(this.month_radioButton);
            this.groupBox1.Controls.Add(this.day_radioButton);
            this.groupBox1.Controls.Add(this.month_dtp);
            this.groupBox1.Location = new System.Drawing.Point(669, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 198);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选方式";
            // 
            // year_dtp
            // 
            this.year_dtp.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.year_dtp.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.year_dtp.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.year_dtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.year_dtp.Location = new System.Drawing.Point(129, 156);
            this.year_dtp.Name = "year_dtp";
            this.year_dtp.Size = new System.Drawing.Size(128, 26);
            this.year_dtp.TabIndex = 13;
            this.year_dtp.ValueChanged += new System.EventHandler(this.year_dtp_ValueChanged);
            // 
            // date_dtp
            // 
            this.date_dtp.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.date_dtp.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.date_dtp.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.date_dtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_dtp.Location = new System.Drawing.Point(129, 25);
            this.date_dtp.Name = "date_dtp";
            this.date_dtp.Size = new System.Drawing.Size(128, 26);
            this.date_dtp.TabIndex = 15;
            this.date_dtp.ValueChanged += new System.EventHandler(this.date_dtp_ValueChanged);
            // 
            // threemonth_radioButton
            // 
            this.threemonth_radioButton.AutoSize = true;
            this.threemonth_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.threemonth_radioButton.Location = new System.Drawing.Point(70, 92);
            this.threemonth_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.threemonth_radioButton.Name = "threemonth_radioButton";
            this.threemonth_radioButton.Size = new System.Drawing.Size(50, 21);
            this.threemonth_radioButton.TabIndex = 24;
            this.threemonth_radioButton.TabStop = true;
            this.threemonth_radioButton.Text = "季度";
            this.threemonth_radioButton.UseVisualStyleBackColor = true;
            this.threemonth_radioButton.CheckedChanged += new System.EventHandler(this.threemonth_radioButton_CheckedChanged);
            // 
            // month_radioButton
            // 
            this.month_radioButton.AutoSize = true;
            this.month_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.month_radioButton.Location = new System.Drawing.Point(70, 58);
            this.month_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.month_radioButton.Name = "month_radioButton";
            this.month_radioButton.Size = new System.Drawing.Size(50, 21);
            this.month_radioButton.TabIndex = 23;
            this.month_radioButton.TabStop = true;
            this.month_radioButton.Text = "月度";
            this.month_radioButton.UseVisualStyleBackColor = true;
            this.month_radioButton.CheckedChanged += new System.EventHandler(this.month_radioButton_CheckedChanged);
            // 
            // day_radioButton
            // 
            this.day_radioButton.AutoSize = true;
            this.day_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.day_radioButton.Location = new System.Drawing.Point(70, 25);
            this.day_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.day_radioButton.Name = "day_radioButton";
            this.day_radioButton.Size = new System.Drawing.Size(50, 21);
            this.day_radioButton.TabIndex = 22;
            this.day_radioButton.TabStop = true;
            this.day_radioButton.Text = "日期";
            this.day_radioButton.UseVisualStyleBackColor = true;
            this.day_radioButton.CheckedChanged += new System.EventHandler(this.day_radioButton_CheckedChanged);
            // 
            // year_radioButton
            // 
            this.year_radioButton.AutoSize = true;
            this.year_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.year_radioButton.Location = new System.Drawing.Point(70, 157);
            this.year_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.year_radioButton.Name = "year_radioButton";
            this.year_radioButton.Size = new System.Drawing.Size(50, 21);
            this.year_radioButton.TabIndex = 25;
            this.year_radioButton.TabStop = true;
            this.year_radioButton.Text = "年度";
            this.year_radioButton.UseVisualStyleBackColor = true;
            this.year_radioButton.CheckedChanged += new System.EventHandler(this.year_radioButton_CheckedChanged);
            // 
            // sixmonth_radioButton
            // 
            this.sixmonth_radioButton.AutoSize = true;
            this.sixmonth_radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sixmonth_radioButton.Location = new System.Drawing.Point(70, 124);
            this.sixmonth_radioButton.Margin = new System.Windows.Forms.Padding(6);
            this.sixmonth_radioButton.Name = "sixmonth_radioButton";
            this.sixmonth_radioButton.Size = new System.Drawing.Size(50, 21);
            this.sixmonth_radioButton.TabIndex = 26;
            this.sixmonth_radioButton.TabStop = true;
            this.sixmonth_radioButton.Text = "半年";
            this.sixmonth_radioButton.UseVisualStyleBackColor = true;
            this.sixmonth_radioButton.CheckedChanged += new System.EventHandler(this.sixmonth_radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(178, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "港站之星-班组长";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(27, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "港站之星-客运员";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox2.Controls.Add(this.label9);
            this.skinGroupBox2.Controls.Add(this.selectedPicker_lbl);
            this.skinGroupBox2.Controls.Add(this.teamRank_btn);
            this.skinGroupBox2.Controls.Add(this.leaderRank_btn);
            this.skinGroupBox2.Controls.Add(this.memberRank_btn);
            this.skinGroupBox2.Controls.Add(this.label6);
            this.skinGroupBox2.Controls.Add(this.label7);
            this.skinGroupBox2.Controls.Add(this.label8);
            this.skinGroupBox2.Controls.Add(this.star_leader_point_lb);
            this.skinGroupBox2.Controls.Add(this.star_member_point_lb);
            this.skinGroupBox2.Controls.Add(this.star_leader_lb);
            this.skinGroupBox2.Controls.Add(this.star_member_lb);
            this.skinGroupBox2.Controls.Add(this.label5);
            this.skinGroupBox2.Controls.Add(this.label2);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.skinGroupBox2.Location = new System.Drawing.Point(669, 229);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(322, 328);
            this.skinGroupBox2.TabIndex = 19;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "评比";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // star_member_lb
            // 
            this.star_member_lb.AutoSize = true;
            this.star_member_lb.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_member_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_member_lb.Location = new System.Drawing.Point(49, 42);
            this.star_member_lb.Name = "star_member_lb";
            this.star_member_lb.Size = new System.Drawing.Size(79, 33);
            this.star_member_lb.TabIndex = 19;
            this.star_member_lb.Text = "汪洋";
            // 
            // star_leader_lb
            // 
            this.star_leader_lb.AutoSize = true;
            this.star_leader_lb.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_leader_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_leader_lb.Location = new System.Drawing.Point(196, 42);
            this.star_leader_lb.Name = "star_leader_lb";
            this.star_leader_lb.Size = new System.Drawing.Size(79, 33);
            this.star_leader_lb.TabIndex = 20;
            this.star_leader_lb.Text = "任远";
            // 
            // star_member_point_lb
            // 
            this.star_member_point_lb.AutoSize = true;
            this.star_member_point_lb.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_member_point_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_member_point_lb.Location = new System.Drawing.Point(51, 75);
            this.star_member_point_lb.Name = "star_member_point_lb";
            this.star_member_point_lb.Size = new System.Drawing.Size(70, 24);
            this.star_member_point_lb.TabIndex = 21;
            this.star_member_point_lb.Text = "112分";
            // 
            // star_leader_point_lb
            // 
            this.star_leader_point_lb.AutoSize = true;
            this.star_leader_point_lb.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.star_leader_point_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.star_leader_point_lb.Location = new System.Drawing.Point(198, 75);
            this.star_leader_point_lb.Name = "star_leader_point_lb";
            this.star_leader_point_lb.Size = new System.Drawing.Size(70, 24);
            this.star_leader_point_lb.TabIndex = 22;
            this.star_leader_point_lb.Text = "165分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(126, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "106分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(90, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 33);
            this.label7.TabIndex = 24;
            this.label7.Text = "综控班组";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(126, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "港站之冠";
            // 
            // outputData_btn
            // 
            this.outputData_btn.BackColor = System.Drawing.Color.Transparent;
            this.outputData_btn.BaseColor = System.Drawing.Color.DarkGreen;
            this.outputData_btn.BorderColor = System.Drawing.Color.Green;
            this.outputData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.outputData_btn.DownBack = null;
            this.outputData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputData_btn.Location = new System.Drawing.Point(157, 499);
            this.outputData_btn.MouseBack = null;
            this.outputData_btn.Name = "outputData_btn";
            this.outputData_btn.NormlBack = null;
            this.outputData_btn.Size = new System.Drawing.Size(356, 46);
            this.outputData_btn.TabIndex = 10;
            this.outputData_btn.Text = "导出所选条目至表格";
            this.outputData_btn.UseVisualStyleBackColor = false;
            // 
            // memberRank_btn
            // 
            this.memberRank_btn.BackColor = System.Drawing.Color.Transparent;
            this.memberRank_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.memberRank_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.memberRank_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.memberRank_btn.DownBack = null;
            this.memberRank_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.memberRank_btn.Location = new System.Drawing.Point(31, 122);
            this.memberRank_btn.MouseBack = null;
            this.memberRank_btn.Name = "memberRank_btn";
            this.memberRank_btn.NormlBack = null;
            this.memberRank_btn.Size = new System.Drawing.Size(109, 35);
            this.memberRank_btn.TabIndex = 20;
            this.memberRank_btn.Text = "客运员排名";
            this.memberRank_btn.UseVisualStyleBackColor = false;
            // 
            // leaderRank_btn
            // 
            this.leaderRank_btn.BackColor = System.Drawing.Color.Transparent;
            this.leaderRank_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.leaderRank_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.leaderRank_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.leaderRank_btn.DownBack = null;
            this.leaderRank_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leaderRank_btn.Location = new System.Drawing.Point(182, 122);
            this.leaderRank_btn.MouseBack = null;
            this.leaderRank_btn.Name = "leaderRank_btn";
            this.leaderRank_btn.NormlBack = null;
            this.leaderRank_btn.Size = new System.Drawing.Size(109, 35);
            this.leaderRank_btn.TabIndex = 26;
            this.leaderRank_btn.Text = "班组长排名";
            this.leaderRank_btn.UseVisualStyleBackColor = false;
            // 
            // teamRank_btn
            // 
            this.teamRank_btn.BackColor = System.Drawing.Color.Transparent;
            this.teamRank_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.teamRank_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.teamRank_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.teamRank_btn.DownBack = null;
            this.teamRank_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teamRank_btn.Location = new System.Drawing.Point(96, 270);
            this.teamRank_btn.MouseBack = null;
            this.teamRank_btn.Name = "teamRank_btn";
            this.teamRank_btn.NormlBack = null;
            this.teamRank_btn.Size = new System.Drawing.Size(129, 38);
            this.teamRank_btn.TabIndex = 27;
            this.teamRank_btn.Text = "班组季度排名";
            this.teamRank_btn.UseVisualStyleBackColor = false;
            // 
            // selectedPicker_lbl
            // 
            this.selectedPicker_lbl.AutoSize = true;
            this.selectedPicker_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectedPicker_lbl.Location = new System.Drawing.Point(123, 22);
            this.selectedPicker_lbl.Name = "selectedPicker_lbl";
            this.selectedPicker_lbl.Size = new System.Drawing.Size(85, 20);
            this.selectedPicker_lbl.TabIndex = 28;
            this.selectedPicker_lbl.Text = "2022年10月";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(111, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "2022年四季度";
            // 
            // threemonth_year_cb
            // 
            this.threemonth_year_cb.FormattingEnabled = true;
            this.threemonth_year_cb.Location = new System.Drawing.Point(129, 88);
            this.threemonth_year_cb.Name = "threemonth_year_cb";
            this.threemonth_year_cb.Size = new System.Drawing.Size(79, 28);
            this.threemonth_year_cb.TabIndex = 27;
            this.threemonth_year_cb.SelectedIndexChanged += new System.EventHandler(this.threemonth_year_cb_SelectedIndexChanged);
            // 
            // threemonth_cb
            // 
            this.threemonth_cb.FormattingEnabled = true;
            this.threemonth_cb.Location = new System.Drawing.Point(214, 88);
            this.threemonth_cb.Name = "threemonth_cb";
            this.threemonth_cb.Size = new System.Drawing.Size(79, 28);
            this.threemonth_cb.TabIndex = 28;
            this.threemonth_cb.SelectedIndexChanged += new System.EventHandler(this.threemonth_cb_SelectedIndexChanged);
            // 
            // sixmonth_cb
            // 
            this.sixmonth_cb.FormattingEnabled = true;
            this.sixmonth_cb.Location = new System.Drawing.Point(214, 122);
            this.sixmonth_cb.Name = "sixmonth_cb";
            this.sixmonth_cb.Size = new System.Drawing.Size(79, 28);
            this.sixmonth_cb.TabIndex = 30;
            this.sixmonth_cb.SelectedIndexChanged += new System.EventHandler(this.sixmonth_cb_SelectedIndexChanged);
            // 
            // sixmonth_year_cb
            // 
            this.sixmonth_year_cb.FormattingEnabled = true;
            this.sixmonth_year_cb.Location = new System.Drawing.Point(129, 122);
            this.sixmonth_year_cb.Name = "sixmonth_year_cb";
            this.sixmonth_year_cb.Size = new System.Drawing.Size(79, 28);
            this.sixmonth_year_cb.TabIndex = 29;
            this.sixmonth_year_cb.SelectedIndexChanged += new System.EventHandler(this.sixmonth_year_cb_SelectedIndexChanged);
            // 
            // DataAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 669);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataAnalyse";
            this.Text = "数据统计与导出";
            this.Load += new System.EventHandler(this.DataAnalyse_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton year_radioButton;
        private System.Windows.Forms.RadioButton sixmonth_radioButton;
        private System.Windows.Forms.DateTimePicker date_dtp;
        private System.Windows.Forms.RadioButton threemonth_radioButton;
        private System.Windows.Forms.DateTimePicker year_dtp;
        private System.Windows.Forms.RadioButton month_radioButton;
        private System.Windows.Forms.RadioButton day_radioButton;
        private System.Windows.Forms.DateTimePicker month_dtp;
        private System.Windows.Forms.ComboBox teamSelect_cb;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.ListView memberList_lv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private System.Windows.Forms.Label star_leader_point_lb;
        private System.Windows.Forms.Label star_member_point_lb;
        private System.Windows.Forms.Label star_leader_lb;
        private System.Windows.Forms.Label star_member_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CCWin.SkinControl.SkinButton outputData_btn;
        private CCWin.SkinControl.SkinButton teamRank_btn;
        private CCWin.SkinControl.SkinButton leaderRank_btn;
        private CCWin.SkinControl.SkinButton memberRank_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label selectedPicker_lbl;
        private System.Windows.Forms.ComboBox sixmonth_cb;
        private System.Windows.Forms.ComboBox sixmonth_year_cb;
        private System.Windows.Forms.ComboBox threemonth_cb;
        private System.Windows.Forms.ComboBox threemonth_year_cb;
    }
}