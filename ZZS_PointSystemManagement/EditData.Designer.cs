namespace ZZS_PointSystemManagement
{
    partial class EditData
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
            this.timePicker_dtp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamSelect_cb = new System.Windows.Forms.ComboBox();
            this.memberSelect_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pointChangeInput_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.detailText_tb = new System.Windows.Forms.RichTextBox();
            this.close_btn = new CCWin.SkinControl.SkinButton();
            this.pointChangeDetail_tb = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_btn = new CCWin.SkinControl.SkinButton();
            this.pointChange_lb = new System.Windows.Forms.ListBox();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePicker_dtp
            // 
            this.timePicker_dtp.CalendarForeColor = System.Drawing.Color.OrangeRed;
            this.timePicker_dtp.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.timePicker_dtp.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.timePicker_dtp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timePicker_dtp.Location = new System.Drawing.Point(378, 31);
            this.timePicker_dtp.Name = "timePicker_dtp";
            this.timePicker_dtp.Size = new System.Drawing.Size(200, 26);
            this.timePicker_dtp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(279, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "积分发布日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "班组筛选";
            // 
            // teamSelect_cb
            // 
            this.teamSelect_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamSelect_cb.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teamSelect_cb.FormattingEnabled = true;
            this.teamSelect_cb.Location = new System.Drawing.Point(104, 31);
            this.teamSelect_cb.Name = "teamSelect_cb";
            this.teamSelect_cb.Size = new System.Drawing.Size(135, 28);
            this.teamSelect_cb.TabIndex = 15;
            this.teamSelect_cb.SelectedIndexChanged += new System.EventHandler(this.teamSelect_cb_SelectedIndexChanged);
            // 
            // memberSelect_cb
            // 
            this.memberSelect_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberSelect_cb.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memberSelect_cb.FormattingEnabled = true;
            this.memberSelect_cb.Location = new System.Drawing.Point(104, 69);
            this.memberSelect_cb.Name = "memberSelect_cb";
            this.memberSelect_cb.Size = new System.Drawing.Size(135, 28);
            this.memberSelect_cb.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "姓名";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinGroupBox1.Controls.Add(this.teamSelect_cb);
            this.skinGroupBox1.Controls.Add(this.memberSelect_cb);
            this.skinGroupBox1.Controls.Add(this.timePicker_dtp);
            this.skinGroupBox1.Controls.Add(this.label1);
            this.skinGroupBox1.Controls.Add(this.label5);
            this.skinGroupBox1.Controls.Add(this.label2);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.skinGroupBox1.Location = new System.Drawing.Point(36, 35);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(608, 106);
            this.skinGroupBox1.TabIndex = 18;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "基础信息";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DeepPink;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Enter += new System.EventHandler(this.skinGroupBox1_Enter);
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinGroupBox2.Controls.Add(this.label6);
            this.skinGroupBox2.Controls.Add(this.pointChangeInput_tb);
            this.skinGroupBox2.Controls.Add(this.label4);
            this.skinGroupBox2.Controls.Add(this.detailText_tb);
            this.skinGroupBox2.Controls.Add(this.close_btn);
            this.skinGroupBox2.Controls.Add(this.pointChangeDetail_tb);
            this.skinGroupBox2.Controls.Add(this.label3);
            this.skinGroupBox2.Controls.Add(this.save_btn);
            this.skinGroupBox2.Controls.Add(this.pointChange_lb);
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.DeepPink;
            this.skinGroupBox2.Location = new System.Drawing.Point(36, 147);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(608, 468);
            this.skinGroupBox2.TabIndex = 19;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "积分操作";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DeepPink;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(19, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "详情";
            // 
            // pointChangeInput_tb
            // 
            this.pointChangeInput_tb.Location = new System.Drawing.Point(478, 327);
            this.pointChangeInput_tb.Name = "pointChangeInput_tb";
            this.pointChangeInput_tb.Size = new System.Drawing.Size(111, 26);
            this.pointChangeInput_tb.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "内容";
            // 
            // detailText_tb
            // 
            this.detailText_tb.Location = new System.Drawing.Point(23, 312);
            this.detailText_tb.Name = "detailText_tb";
            this.detailText_tb.Size = new System.Drawing.Size(441, 133);
            this.detailText_tb.TabIndex = 23;
            this.detailText_tb.Text = "";
            this.detailText_tb.TextChanged += new System.EventHandler(this.detailText_tb_TextChanged);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.close_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.close_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.close_btn.DownBack = null;
            this.close_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close_btn.Location = new System.Drawing.Point(477, 405);
            this.close_btn.MouseBack = null;
            this.close_btn.Name = "close_btn";
            this.close_btn.NormlBack = null;
            this.close_btn.Size = new System.Drawing.Size(112, 40);
            this.close_btn.TabIndex = 21;
            this.close_btn.Text = "关闭";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pointChangeDetail_tb
            // 
            this.pointChangeDetail_tb.Location = new System.Drawing.Point(23, 207);
            this.pointChangeDetail_tb.Name = "pointChangeDetail_tb";
            this.pointChangeDetail_tb.ReadOnly = true;
            this.pointChangeDetail_tb.Size = new System.Drawing.Size(566, 79);
            this.pointChangeDetail_tb.TabIndex = 1;
            this.pointChangeDetail_tb.Text = "";
            this.pointChangeDetail_tb.TextChanged += new System.EventHandler(this.pointChangeDetail_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(480, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "分数(扣分用-号)";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_btn.BaseColor = System.Drawing.Color.DeepPink;
            this.save_btn.BorderColor = System.Drawing.Color.DeepPink;
            this.save_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.save_btn.DownBack = null;
            this.save_btn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.save_btn.Location = new System.Drawing.Point(477, 359);
            this.save_btn.MouseBack = null;
            this.save_btn.Name = "save_btn";
            this.save_btn.NormlBack = null;
            this.save_btn.Size = new System.Drawing.Size(112, 40);
            this.save_btn.TabIndex = 20;
            this.save_btn.Text = "保存";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // pointChange_lb
            // 
            this.pointChange_lb.FormattingEnabled = true;
            this.pointChange_lb.ItemHeight = 20;
            this.pointChange_lb.Location = new System.Drawing.Point(23, 37);
            this.pointChange_lb.Name = "pointChange_lb";
            this.pointChange_lb.Size = new System.Drawing.Size(566, 144);
            this.pointChange_lb.TabIndex = 0;
            this.pointChange_lb.SelectedIndexChanged += new System.EventHandler(this.pointChange_lb_SelectedIndexChanged);
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 651);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MdiBackColor = System.Drawing.Color.White;
            this.Name = "EditData";
            this.Text = "编辑积分";
            this.Load += new System.EventHandler(this.EditData_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePicker_dtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teamSelect_cb;
        private System.Windows.Forms.ComboBox memberSelect_cb;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinButton save_btn;
        private System.Windows.Forms.RichTextBox pointChangeDetail_tb;
        private System.Windows.Forms.ListBox pointChange_lb;
        private CCWin.SkinControl.SkinButton close_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pointChangeInput_tb;
        private System.Windows.Forms.RichTextBox detailText_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}