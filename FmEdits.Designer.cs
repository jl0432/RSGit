
namespace RandomSelection
{
    partial class FmEdits
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gupRight = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRegLocation = new System.Windows.Forms.TextBox();
            this.lblRegLocation = new System.Windows.Forms.Label();
            this.txtRegDate = new System.Windows.Forms.TextBox();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gupMain = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gupRight.SuspendLayout();
            this.gupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20000;
            // 
            // gupRight
            // 
            this.gupRight.Controls.Add(this.btnNew);
            this.gupRight.Controls.Add(this.btnDelete);
            this.gupRight.Controls.Add(this.btnSave);
            this.gupRight.Controls.Add(this.txtRemark);
            this.gupRight.Controls.Add(this.lblRemark);
            this.gupRight.Controls.Add(this.txtRegLocation);
            this.gupRight.Controls.Add(this.lblRegLocation);
            this.gupRight.Controls.Add(this.txtRegDate);
            this.gupRight.Controls.Add(this.lblRegDate);
            this.gupRight.Controls.Add(this.txtAddress);
            this.gupRight.Controls.Add(this.lblAddress);
            this.gupRight.Controls.Add(this.txtPhone);
            this.gupRight.Controls.Add(this.lblPhone);
            this.gupRight.Controls.Add(this.txtStaff);
            this.gupRight.Controls.Add(this.lblStaff);
            this.gupRight.Controls.Add(this.txtName);
            this.gupRight.Controls.Add(this.lblName);
            this.gupRight.Controls.Add(this.txtId);
            this.gupRight.Controls.Add(this.lblId);
            this.gupRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.gupRight.Location = new System.Drawing.Point(738, 0);
            this.gupRight.Name = "gupRight";
            this.gupRight.Size = new System.Drawing.Size(270, 729);
            this.gupRight.TabIndex = 0;
            this.gupRight.TabStop = false;
            this.gupRight.Text = "编辑";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(102, 332);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "新增数据";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "删除数据";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(8, 305);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(250, 21);
            this.txtRemark.TabIndex = 15;
            this.txtRemark.Tag = "8";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(6, 290);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(35, 12);
            this.lblRemark.TabIndex = 14;
            this.lblRemark.Tag = "8";
            this.lblRemark.Text = "备注:";
            // 
            // txtRegLocation
            // 
            this.txtRegLocation.Location = new System.Drawing.Point(8, 266);
            this.txtRegLocation.Name = "txtRegLocation";
            this.txtRegLocation.Size = new System.Drawing.Size(250, 21);
            this.txtRegLocation.TabIndex = 13;
            this.txtRegLocation.Tag = "7";
            // 
            // lblRegLocation
            // 
            this.lblRegLocation.AutoSize = true;
            this.lblRegLocation.Location = new System.Drawing.Point(6, 251);
            this.lblRegLocation.Name = "lblRegLocation";
            this.lblRegLocation.Size = new System.Drawing.Size(59, 12);
            this.lblRegLocation.TabIndex = 12;
            this.lblRegLocation.Tag = "7";
            this.lblRegLocation.Text = "登记地点:";
            // 
            // txtRegDate
            // 
            this.txtRegDate.Location = new System.Drawing.Point(8, 227);
            this.txtRegDate.Name = "txtRegDate";
            this.txtRegDate.Size = new System.Drawing.Size(250, 21);
            this.txtRegDate.TabIndex = 11;
            this.txtRegDate.Tag = "6";
            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.Location = new System.Drawing.Point(6, 212);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(59, 12);
            this.lblRegDate.TabIndex = 10;
            this.lblRegDate.Tag = "6";
            this.lblRegDate.Text = "登记日期:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(8, 188);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 21);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Tag = "5";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 173);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 12);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Tag = "5";
            this.lblAddress.Text = "注册地址:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(8, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 21);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Tag = "4";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 134);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 12);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Tag = "4";
            this.lblPhone.Text = "联系电话:";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(8, 110);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(250, 21);
            this.txtStaff.TabIndex = 5;
            this.txtStaff.Tag = "3";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(6, 95);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(47, 12);
            this.lblStaff.TabIndex = 4;
            this.lblStaff.Tag = "3";
            this.lblStaff.Text = "联系人:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(8, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 21);
            this.txtName.TabIndex = 3;
            this.txtName.Tag = "2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Tag = "2";
            this.lblName.Text = "机构名称*:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(8, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(250, 21);
            this.txtId.TabIndex = 1;
            this.txtId.Tag = "1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(113, 12);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "1";
            this.lblId.Text = "统一社会信用代码*:";
            // 
            // gupMain
            // 
            this.gupMain.Controls.Add(this.dgvMain);
            this.gupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gupMain.Location = new System.Drawing.Point(0, 0);
            this.gupMain.Name = "gupMain";
            this.gupMain.Size = new System.Drawing.Size(738, 729);
            this.gupMain.TabIndex = 2;
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
            this.dgvMain.Size = new System.Drawing.Size(732, 709);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
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
            // FmEdits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gupMain);
            this.Controls.Add(this.gupRight);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FmEdits";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑信息";
            this.Load += new System.EventHandler(this.FmEdits_Load);
            this.gupRight.ResumeLayout(false);
            this.gupRight.PerformLayout();
            this.gupMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gupRight;
        private System.Windows.Forms.GroupBox gupMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtRegDate;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.TextBox txtRegLocation;
        private System.Windows.Forms.Label lblRegLocation;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegLocation;
    }
}