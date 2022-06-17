namespace DeReport
{
    partial class 实验报告生成器
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(实验报告生成器));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.UID_Box = new System.Windows.Forms.TextBox();
            this.Report_Name_Box = new System.Windows.Forms.TextBox();
            this.Report_Where_Box = new System.Windows.Forms.TextBox();
            this.Report_Teacher_Box = new System.Windows.Forms.TextBox();
            this.Report_Item_Box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Class_List_Box = new System.Windows.Forms.ComboBox();
            this.Major_List_Box = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Report_Time_Box = new System.Windows.Forms.DateTimePicker();
            this.Item_List_Box = new System.Windows.Forms.ComboBox();
            this.ReView_Button = new System.Windows.Forms.Button();
            this.Report_Item_Box_2 = new System.Windows.Forms.RichTextBox();
            this.Report_Item_Box_3 = new System.Windows.Forms.RichTextBox();
            this.Report_Item_Box_4 = new System.Windows.Forms.RichTextBox();
            this.Report_Item_Box_5 = new System.Windows.Forms.RichTextBox();
            this.Report_Item_Box_6 = new System.Windows.Forms.RichTextBox();
            this.Report_Item_Box_7 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.协议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("思源黑体 CN Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(727, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(67, 3);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(153, 21);
            this.Name_Box.TabIndex = 2;
            // 
            // UID_Box
            // 
            this.UID_Box.Location = new System.Drawing.Point(67, 30);
            this.UID_Box.Name = "UID_Box";
            this.UID_Box.Size = new System.Drawing.Size(153, 21);
            this.UID_Box.TabIndex = 3;
            // 
            // Report_Name_Box
            // 
            this.Report_Name_Box.Location = new System.Drawing.Point(99, 3);
            this.Report_Name_Box.Name = "Report_Name_Box";
            this.Report_Name_Box.Size = new System.Drawing.Size(121, 21);
            this.Report_Name_Box.TabIndex = 6;
            // 
            // Report_Where_Box
            // 
            this.Report_Where_Box.Location = new System.Drawing.Point(99, 30);
            this.Report_Where_Box.Name = "Report_Where_Box";
            this.Report_Where_Box.Size = new System.Drawing.Size(121, 21);
            this.Report_Where_Box.TabIndex = 8;
            // 
            // Report_Teacher_Box
            // 
            this.Report_Teacher_Box.Location = new System.Drawing.Point(99, 84);
            this.Report_Teacher_Box.Name = "Report_Teacher_Box";
            this.Report_Teacher_Box.Size = new System.Drawing.Size(121, 21);
            this.Report_Teacher_Box.TabIndex = 9;
            // 
            // Report_Item_Box
            // 
            this.Report_Item_Box.Location = new System.Drawing.Point(250, 28);
            this.Report_Item_Box.Name = "Report_Item_Box";
            this.Report_Item_Box.Size = new System.Drawing.Size(703, 178);
            this.Report_Item_Box.TabIndex = 10;
            this.Report_Item_Box.Text = "此处填写：一、实验目的";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "班级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "专业：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "实验名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "实验时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "实验地点：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "教师姓名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("思源黑体 CN Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(250, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "大项选择：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Name_Box);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.UID_Box);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.Class_List_Box);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.Major_List_Box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 107);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // Class_List_Box
            // 
            this.Class_List_Box.FormattingEnabled = true;
            this.Class_List_Box.Items.AddRange(new object[] {
            "计科20211901",
            "计科20211902"});
            this.Class_List_Box.Location = new System.Drawing.Point(67, 57);
            this.Class_List_Box.Name = "Class_List_Box";
            this.Class_List_Box.Size = new System.Drawing.Size(153, 20);
            this.Class_List_Box.TabIndex = 23;
            this.Class_List_Box.Text = "计科20211901";
            // 
            // Major_List_Box
            // 
            this.Major_List_Box.FormattingEnabled = true;
            this.Major_List_Box.Items.AddRange(new object[] {
            "计算机科学与技术"});
            this.Major_List_Box.Location = new System.Drawing.Point(67, 83);
            this.Major_List_Box.Name = "Major_List_Box";
            this.Major_List_Box.Size = new System.Drawing.Size(153, 20);
            this.Major_List_Box.TabIndex = 23;
            this.Major_List_Box.Text = "计算机科学与技术";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.Report_Name_Box);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.Report_Where_Box);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.Report_Time_Box);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.Report_Teacher_Box);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 137);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(237, 112);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // Report_Time_Box
            // 
            this.Report_Time_Box.Location = new System.Drawing.Point(99, 57);
            this.Report_Time_Box.Name = "Report_Time_Box";
            this.Report_Time_Box.Size = new System.Drawing.Size(121, 21);
            this.Report_Time_Box.TabIndex = 17;
            // 
            // Item_List_Box
            // 
            this.Item_List_Box.DisplayMember = "0";
            this.Item_List_Box.FormattingEnabled = true;
            this.Item_List_Box.Items.AddRange(new object[] {
            "一、实验目的",
            "二、实验原理",
            "三、实验步骤及内容",
            "四、表格及数据",
            "五、数据处理及结果分析",
            "六、误差分析",
            "七、总结"});
            this.Item_List_Box.Location = new System.Drawing.Point(329, 213);
            this.Item_List_Box.Name = "Item_List_Box";
            this.Item_List_Box.Size = new System.Drawing.Size(145, 20);
            this.Item_List_Box.TabIndex = 23;
            this.Item_List_Box.Text = "一、实验目的";
            this.Item_List_Box.SelectedIndexChanged += new System.EventHandler(this.Item_List_Box_SelectedIndexChanged);
            // 
            // ReView_Button
            // 
            this.ReView_Button.AutoSize = true;
            this.ReView_Button.Enabled = false;
            this.ReView_Button.Font = new System.Drawing.Font("思源黑体 CN Heavy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReView_Button.Location = new System.Drawing.Point(480, 214);
            this.ReView_Button.Name = "ReView_Button";
            this.ReView_Button.Size = new System.Drawing.Size(241, 71);
            this.ReView_Button.TabIndex = 24;
            this.ReView_Button.Text = "预览";
            this.ReView_Button.UseVisualStyleBackColor = true;
            this.ReView_Button.Visible = false;
            // 
            // Report_Item_Box_2
            // 
            this.Report_Item_Box_2.Location = new System.Drawing.Point(250, 28);
            this.Report_Item_Box_2.Name = "Report_Item_Box_2";
            this.Report_Item_Box_2.Size = new System.Drawing.Size(703, 178);
            this.Report_Item_Box_2.TabIndex = 26;
            this.Report_Item_Box_2.Text = "此处填写：二、实验原理";
            this.Report_Item_Box_2.Visible = false;
            // 
            // Report_Item_Box_3
            // 
            this.Report_Item_Box_3.Location = new System.Drawing.Point(250, 29);
            this.Report_Item_Box_3.Name = "Report_Item_Box_3";
            this.Report_Item_Box_3.Size = new System.Drawing.Size(703, 178);
            this.Report_Item_Box_3.TabIndex = 27;
            this.Report_Item_Box_3.Text = "此处填写：三、实验步骤及内容";
            this.Report_Item_Box_3.Visible = false;
            // 
            // Report_Item_Box_4
            // 
            this.Report_Item_Box_4.Location = new System.Drawing.Point(250, 28);
            this.Report_Item_Box_4.Name = "Report_Item_Box_4";
            this.Report_Item_Box_4.Size = new System.Drawing.Size(703, 178);
            this.Report_Item_Box_4.TabIndex = 28;
            this.Report_Item_Box_4.Text = "此处填写大项：四、表格及数据";
            this.Report_Item_Box_4.Visible = false;
            // 
            // Report_Item_Box_5
            // 
            this.Report_Item_Box_5.Location = new System.Drawing.Point(250, 28);
            this.Report_Item_Box_5.Name = "Report_Item_Box_5";
            this.Report_Item_Box_5.Size = new System.Drawing.Size(703, 178);
            this.Report_Item_Box_5.TabIndex = 29;
            this.Report_Item_Box_5.Text = "此处填写：五、数据处理及结果分析";
            this.Report_Item_Box_5.Visible = false;
            // 
            // Report_Item_Box_6
            // 
            this.Report_Item_Box_6.Location = new System.Drawing.Point(250, 28);
            this.Report_Item_Box_6.Name = "Report_Item_Box_6";
            this.Report_Item_Box_6.Size = new System.Drawing.Size(703, 178);
            this.Report_Item_Box_6.TabIndex = 30;
            this.Report_Item_Box_6.Text = "此处填写：六、误差分析";
            this.Report_Item_Box_6.Visible = false;
            // 
            // Report_Item_Box_7
            // 
            this.Report_Item_Box_7.Location = new System.Drawing.Point(250, 28);
            this.Report_Item_Box_7.Name = "Report_Item_Box_7";
            this.Report_Item_Box_7.Size = new System.Drawing.Size(703, 178);
            this.Report_Item_Box_7.TabIndex = 31;
            this.Report_Item_Box_7.Text = "此处填写：七、总结";
            this.Report_Item_Box_7.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("思源黑体 CN Heavy", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(10, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(578, 63);
            this.label11.TabIndex = 32;
            this.label11.Text = "由于换行转义符限制，暂无法自动换行，程序将会在需要换行的区域自动添加换行标记 {FP} \r\n生成完成后，在Word中打开生成的文件，利用替换功能，将 {FP} 替" +
    "换为 ^p 即可恢复换行\r\n大项内容编辑无需特别添加换行标记           暂不支持图片添加\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 25);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1,
            this.协议ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // 协议ToolStripMenuItem
            // 
            this.协议ToolStripMenuItem.Name = "协议ToolStripMenuItem";
            this.协议ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.协议ToolStripMenuItem.Text = "协议";
            this.协议ToolStripMenuItem.Click += new System.EventHandler(this.协议ToolStripMenuItem_Click);
            // 
            // 实验报告生成器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 326);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Report_Item_Box_7);
            this.Controls.Add(this.Report_Item_Box_6);
            this.Controls.Add(this.Report_Item_Box_5);
            this.Controls.Add(this.Report_Item_Box_4);
            this.Controls.Add(this.Report_Item_Box_3);
            this.Controls.Add(this.Report_Item_Box_2);
            this.Controls.Add(this.ReView_Button);
            this.Controls.Add(this.Report_Item_Box);
            this.Controls.Add(this.Item_List_Box);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "实验报告生成器";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeReport - 实验报告生成器";
            this.Load += new System.EventHandler(this.实验报告生成器_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox UID_Box;
        private System.Windows.Forms.TextBox Report_Name_Box;
        private System.Windows.Forms.TextBox Report_Where_Box;
        private System.Windows.Forms.TextBox Report_Teacher_Box;
        public System.Windows.Forms.RichTextBox Report_Item_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Item_List_Box;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox Class_List_Box;
        private System.Windows.Forms.ComboBox Major_List_Box;
        private System.Windows.Forms.DateTimePicker Report_Time_Box;
        private System.Windows.Forms.Button ReView_Button;
        public System.Windows.Forms.RichTextBox Report_Item_Box_7;
        public System.Windows.Forms.RichTextBox Report_Item_Box_6;
        public System.Windows.Forms.RichTextBox Report_Item_Box_5;
        public System.Windows.Forms.RichTextBox Report_Item_Box_4;
        public System.Windows.Forms.RichTextBox Report_Item_Box_3;
        public System.Windows.Forms.RichTextBox Report_Item_Box_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 协议ToolStripMenuItem;
    }
}

