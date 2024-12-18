
namespace RandomSelection
{
    partial class FmMain
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
            RandomSelection.Organ organ1 = new RandomSelection.Organ();
            RandomSelection.Organ organ2 = new RandomSelection.Organ();
            RandomSelection.Organ organ3 = new RandomSelection.Organ();
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInuptData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDataManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ucOrgan3 = new RandomSelection.UcOrgan();
            this.ucOrgan2 = new RandomSelection.UcOrgan();
            this.ucOrgan1 = new RandomSelection.UcOrgan();
            this.msTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTop
            // 
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(1008, 25);
            this.msTop.TabIndex = 0;
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInuptData,
            this.tsmiDataManage,
            this.tsmiLogs});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(44, 21);
            this.tsmiOptions.Text = "选项";
            // 
            // tsmiInuptData
            // 
            this.tsmiInuptData.Name = "tsmiInuptData";
            this.tsmiInuptData.Size = new System.Drawing.Size(124, 22);
            this.tsmiInuptData.Text = "导入数据";
            this.tsmiInuptData.Click += new System.EventHandler(this.tsmiInuptData_Click);
            // 
            // tsmiDataManage
            // 
            this.tsmiDataManage.Name = "tsmiDataManage";
            this.tsmiDataManage.Size = new System.Drawing.Size(124, 22);
            this.tsmiDataManage.Text = "数据管理";
            this.tsmiDataManage.Click += new System.EventHandler(this.tsmiDataManage_Click);
            // 
            // tsmiLogs
            // 
            this.tsmiLogs.Name = "tsmiLogs";
            this.tsmiLogs.Size = new System.Drawing.Size(124, 22);
            this.tsmiLogs.Text = "日志记录";
            this.tsmiLogs.Click += new System.EventHandler(this.tsmiLogs_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(916, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 80);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始抽取";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(916, 114);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 80);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止抽取";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ucOrgan3
            // 
            this.ucOrgan3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucOrgan3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucOrgan3.Location = new System.Drawing.Point(631, 114);
            this.ucOrgan3.Name = "ucOrgan3";
            organ1.Address = null;
            organ1.Id = null;
            organ1.Name = null;
            organ1.Phone = null;
            organ1.RegDate = null;
            organ1.RegLocation = null;
            organ1.Remark = null;
            organ1.Staff = null;
            this.ucOrgan3.Organ = organ1;
            this.ucOrgan3.Size = new System.Drawing.Size(280, 474);
            this.ucOrgan3.TabIndex = 5;
            this.ucOrgan3.Visible = false;
            // 
            // ucOrgan2
            // 
            this.ucOrgan2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucOrgan2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucOrgan2.Location = new System.Drawing.Point(345, 114);
            this.ucOrgan2.Name = "ucOrgan2";
            organ2.Address = null;
            organ2.Id = null;
            organ2.Name = null;
            organ2.Phone = null;
            organ2.RegDate = null;
            organ2.RegLocation = null;
            organ2.Remark = null;
            organ2.Staff = null;
            this.ucOrgan2.Organ = organ2;
            this.ucOrgan2.Size = new System.Drawing.Size(280, 474);
            this.ucOrgan2.TabIndex = 4;
            // 
            // ucOrgan1
            // 
            this.ucOrgan1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucOrgan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucOrgan1.Location = new System.Drawing.Point(59, 114);
            this.ucOrgan1.Name = "ucOrgan1";
            organ3.Address = null;
            organ3.Id = null;
            organ3.Name = null;
            organ3.Phone = null;
            organ3.RegDate = null;
            organ3.RegLocation = null;
            organ3.Remark = null;
            organ3.Staff = null;
            this.ucOrgan1.Organ = organ3;
            this.ucOrgan1.Size = new System.Drawing.Size(280, 474);
            this.ucOrgan1.TabIndex = 3;
            this.ucOrgan1.Visible = false;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ucOrgan3);
            this.Controls.Add(this.ucOrgan2);
            this.Controls.Add(this.ucOrgan1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.msTop);
            this.MainMenuStrip = this.msTop;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小程序";
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiInuptData;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataManage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private UcOrgan ucOrgan1;
        private UcOrgan ucOrgan2;
        private UcOrgan ucOrgan3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogs;
    }
}

