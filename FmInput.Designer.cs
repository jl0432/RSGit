
namespace RandomSelection
{
    partial class FmInput
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
            this.gupTop = new System.Windows.Forms.GroupBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.chkSkipInvalid = new System.Windows.Forms.CheckBox();
            this.chkSkipT1 = new System.Windows.Forms.CheckBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.gupMain = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gupTop.SuspendLayout();
            this.gupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gupTop
            // 
            this.gupTop.Controls.Add(this.btnRef);
            this.gupTop.Controls.Add(this.chkSkipInvalid);
            this.gupTop.Controls.Add(this.chkSkipT1);
            this.gupTop.Controls.Add(this.btnInput);
            this.gupTop.Controls.Add(this.btnPath);
            this.gupTop.Controls.Add(this.txtPath);
            this.gupTop.Controls.Add(this.lblPath);
            this.gupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gupTop.Location = new System.Drawing.Point(0, 0);
            this.gupTop.Name = "gupTop";
            this.gupTop.Size = new System.Drawing.Size(784, 45);
            this.gupTop.TabIndex = 0;
            this.gupTop.TabStop = false;
            this.gupTop.Text = "操作";
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(370, 12);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 23);
            this.btnRef.TabIndex = 6;
            this.btnRef.Text = "刷新预览";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // chkSkipInvalid
            // 
            this.chkSkipInvalid.AutoSize = true;
            this.chkSkipInvalid.Checked = true;
            this.chkSkipInvalid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipInvalid.Location = new System.Drawing.Point(529, 15);
            this.chkSkipInvalid.Name = "chkSkipInvalid";
            this.chkSkipInvalid.Size = new System.Drawing.Size(84, 16);
            this.chkSkipInvalid.TabIndex = 5;
            this.chkSkipInvalid.Text = "无效行跳过";
            this.chkSkipInvalid.UseVisualStyleBackColor = true;
            // 
            // chkSkipT1
            // 
            this.chkSkipT1.AutoSize = true;
            this.chkSkipT1.Checked = true;
            this.chkSkipT1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipT1.Location = new System.Drawing.Point(451, 15);
            this.chkSkipT1.Name = "chkSkipT1";
            this.chkSkipT1.Size = new System.Drawing.Size(72, 16);
            this.chkSkipT1.TabIndex = 4;
            this.chkSkipT1.Text = "首行跳过";
            this.chkSkipT1.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.Location = new System.Drawing.Point(697, 12);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "导入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(289, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "选择文件";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(83, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(200, 21);
            this.txtPath.TabIndex = 1;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(65, 12);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "选择文件：";
            // 
            // gupMain
            // 
            this.gupMain.Controls.Add(this.dgvMain);
            this.gupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gupMain.Location = new System.Drawing.Point(0, 45);
            this.gupMain.Name = "gupMain";
            this.gupMain.Size = new System.Drawing.Size(784, 516);
            this.gupMain.TabIndex = 1;
            this.gupMain.TabStop = false;
            this.gupMain.Text = "浏览数据";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colStaff,
            this.colPhone,
            this.colAddress,
            this.colRegDate,
            this.colRegLocation});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 17);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(778, 496);
            this.dgvMain.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "统一社会信用代码";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "机构名称";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colStaff
            // 
            this.colStaff.DataPropertyName = "Staff";
            this.colStaff.HeaderText = "联系人";
            this.colStaff.Name = "colStaff";
            this.colStaff.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "联系电话";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "注册地址";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colRegDate
            // 
            this.colRegDate.DataPropertyName = "RegDate";
            this.colRegDate.HeaderText = "登记日期";
            this.colRegDate.Name = "colRegDate";
            this.colRegDate.ReadOnly = true;
            // 
            // colRegLocation
            // 
            this.colRegLocation.DataPropertyName = "RegLocation";
            this.colRegLocation.HeaderText = "登记地点";
            this.colRegLocation.Name = "colRegLocation";
            this.colRegLocation.ReadOnly = true;
            // 
            // FmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gupMain);
            this.Controls.Add(this.gupTop);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FmInput";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入";
            this.gupTop.ResumeLayout(false);
            this.gupTop.PerformLayout();
            this.gupMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gupTop;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.GroupBox gupMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.CheckBox chkSkipT1;
        private System.Windows.Forms.CheckBox chkSkipInvalid;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegLocation;
    }
}