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
            this.importMemberData_btn = new CCWin.SkinControl.SkinButton();
            this.outputData_btn = new CCWin.SkinControl.SkinButton();
            this.importData_btn = new CCWin.SkinControl.SkinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.add_btn = new CCWin.SkinControl.SkinButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.monthlyPicker_dtp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.memberList_lv = new System.Windows.Forms.ListView();
            this.pointDetailView_lv = new System.Windows.Forms.ListView();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.teamSelect_cb = new System.Windows.Forms.ComboBox();
            this.detail_rtb = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.refreshMainData_btn = new CCWin.SkinControl.SkinButton();
            this.orderByPoint_cb = new System.Windows.Forms.CheckBox();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.skinGroupBox1.Controls.Add(this.orderByPoint_cb);
            this.skinGroupBox1.Controls.Add(this.label5);
            this.skinGroupBox1.Controls.Add(this.monthlyPicker_dtp);
            this.skinGroupBox1.Controls.Add(this.teamSelect_cb);
            this.skinGroupBox1.Controls.Add(this.search_tb);
            this.skinGroupBox1.Controls.Add(this.memberList_lv);
            this.skinGroupBox1.Controls.Add(this.importMemberData_btn);
            this.skinGroupBox1.Controls.Add(this.outputData_btn);
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
            // importMemberData_btn
            // 
            this.importMemberData_btn.BackColor = System.Drawing.Color.Transparent;
            this.importMemberData_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.importMemberData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.importMemberData_btn.DownBack = null;
            this.importMemberData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importMemberData_btn.Location = new System.Drawing.Point(134, 504);
            this.importMemberData_btn.MouseBack = null;
            this.importMemberData_btn.Name = "importMemberData_btn";
            this.importMemberData_btn.NormlBack = null;
            this.importMemberData_btn.Size = new System.Drawing.Size(112, 46);
            this.importMemberData_btn.TabIndex = 10;
            this.importMemberData_btn.Text = "导入人员数据";
            this.importMemberData_btn.UseVisualStyleBackColor = false;
            this.importMemberData_btn.Click += new System.EventHandler(this.importMemberData_btn_Click);
            // 
            // outputData_btn
            // 
            this.outputData_btn.BackColor = System.Drawing.Color.Transparent;
            this.outputData_btn.BaseColor = System.Drawing.Color.DarkGreen;
            this.outputData_btn.BorderColor = System.Drawing.Color.Green;
            this.outputData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.outputData_btn.DownBack = null;
            this.outputData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputData_btn.Location = new System.Drawing.Point(358, 504);
            this.outputData_btn.MouseBack = null;
            this.outputData_btn.Name = "outputData_btn";
            this.outputData_btn.NormlBack = null;
            this.outputData_btn.Size = new System.Drawing.Size(112, 46);
            this.outputData_btn.TabIndex = 9;
            this.outputData_btn.Text = "导出月度积分";
            this.outputData_btn.UseVisualStyleBackColor = false;
            // 
            // importData_btn
            // 
            this.importData_btn.BackColor = System.Drawing.Color.Transparent;
            this.importData_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.importData_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.importData_btn.DownBack = null;
            this.importData_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importData_btn.Location = new System.Drawing.Point(16, 504);
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
            // monthlyPicker_dtp
            // 
            this.monthlyPicker_dtp.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.monthlyPicker_dtp.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.monthlyPicker_dtp.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.monthlyPicker_dtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthlyPicker_dtp.Location = new System.Drawing.Point(519, 519);
            this.monthlyPicker_dtp.Name = "monthlyPicker_dtp";
            this.monthlyPicker_dtp.Size = new System.Drawing.Size(128, 26);
            this.monthlyPicker_dtp.TabIndex = 9;
            this.monthlyPicker_dtp.ValueChanged += new System.EventHandler(this.monthlyPicker_dtp_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(476, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "月度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(1000, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Build 20221014";
            // 
            // memberList_lv
            // 
            this.memberList_lv.HideSelection = false;
            this.memberList_lv.Location = new System.Drawing.Point(16, 67);
            this.memberList_lv.Name = "memberList_lv";
            this.memberList_lv.Size = new System.Drawing.Size(631, 416);
            this.memberList_lv.TabIndex = 11;
            this.memberList_lv.UseCompatibleStateImageBehavior = false;
            this.memberList_lv.SelectedIndexChanged += new System.EventHandler(this.memberList_lv_SelectedIndexChanged);
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
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(519, 29);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(128, 26);
            this.search_tb.TabIndex = 12;
            this.search_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // orderByPoint_cb
            // 
            this.orderByPoint_cb.AutoSize = true;
            this.orderByPoint_cb.Checked = true;
            this.orderByPoint_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.orderByPoint_cb.Location = new System.Drawing.Point(535, 489);
            this.orderByPoint_cb.Name = "orderByPoint_cb";
            this.orderByPoint_cb.Size = new System.Drawing.Size(112, 24);
            this.orderByPoint_cb.TabIndex = 15;
            this.orderByPoint_cb.Text = "按照分数排序";
            this.orderByPoint_cb.UseVisualStyleBackColor = true;
            this.orderByPoint_cb.CheckedChanged += new System.EventHandler(this.orderByPoint_cb_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 707);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Name = "Main";
            this.Text = "郑州航空港站积分制管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker monthlyPicker_dtp;
        private System.Windows.Forms.Label label5;
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
    }
}

