using System;
using System.Linq;
using System.Windows.Forms;

namespace RandomSelection{
    public partial class FmEdits:Form{
        private bool _isNew;
        private Organ _organ;
        public FmEdits(){InitializeComponent();}
        private void FmEdits_Load(object sender, EventArgs e){dgvMain.DataSource = Caches.Database.Organs;}
        private void ClearEdits(){
            _organ = null;
            _isNew = false;
            txtId.ReadOnly = true;
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtStaff.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtRegDate.Text = string.Empty;
            txtRegLocation.Text = string.Empty;
            txtRemark.Text = string.Empty;
        }
        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            ClearEdits();
            var row = dgvMain.Rows[e.RowIndex];
            var idx = -1;
            foreach(DataGridViewColumn col in dgvMain.Columns) {
                if(col.DataPropertyName != "Id") continue;
                idx = col.Index;
                break;
            }
            if(idx < 0) return;
            var cell = row.Cells[idx];
            var id   = cell.Value.ToString();
            _organ = Caches.Database.Organs.FirstOrDefault(p=>p.Id == id);
            if(_organ == null) return;
            txtId.Text = _organ.Id;
            txtName.Text = _organ.Name;
            txtAddress.Text = _organ.Address;
            txtStaff.Text = _organ.Staff;
            txtPhone.Text = _organ.Phone;
            txtRegDate.Text = _organ.RegDate;
            txtRegLocation.Text = _organ.RegLocation;
            txtRemark.Text = _organ.Remark;
        }
        private void btnSave_Click(object sender, EventArgs e){
            if(_isNew) {
                _organ = new Organ{
                    Id = txtId.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Staff = txtStaff.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    RegDate = txtRegDate.Text.Trim(),
                    RegLocation = txtRegLocation.Text.Trim(),
                    Remark = txtRemark.Text.Trim()
                };
                if(Caches.Database.Organs.Exists(p=>p.Id == _organ.Id)) {
                    MessageBox.Show($@"存在相同统一社会信用代码[{_organ.Id}]无法正常添加！");
                    return;
                }
                if(string.IsNullOrEmpty(_organ.Id) || string.IsNullOrEmpty(_organ.Name)) {
                    MessageBox.Show(@"*关键字段为空，无法插入数据！");
                    return;
                }
                if(MessageBox.Show($@"确认添加“{_organ.Name}-[{_organ.Id}]”该条数据？", @"提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                Caches.Database.Organs.Insert(0, _organ);
            }
            else {
                if(_organ == null) return;
                if(MessageBox.Show($@"确认修改“{_organ.Name}-[{_organ.Id}]”该条数据？", @"提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                var index = Caches.Database.Organs.IndexOf(_organ);
                Caches.Database.Organs[index] = new Organ(_organ){
                    Name = txtName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Staff = txtStaff.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    RegDate = txtRegDate.Text.Trim(),
                    RegLocation = txtRegLocation.Text.Trim(),
                    Remark = txtRemark.Text.Trim()
                };
            }
            Operation.SaveToDb(Caches.Database);
            ClearEdits();
            dgvMain.DataSource = Caches.Database.Organs;
            dgvMain.Refresh();
        }
        private void btnDelete_Click(object sender, EventArgs e){
            if(_organ == null) return;
            if(MessageBox.Show($@"确认删除“{_organ.Name}-[{_organ.Id}]”该条数据？", @"提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            Caches.Database.Organs.Remove(_organ);
            Operation.SaveToDb(Caches.Database);
            ClearEdits();
            dgvMain.DataSource = Caches.Database.Organs;
            dgvMain.Refresh();
        }
        private void btnNew_Click(object sender, EventArgs e){
            ClearEdits();
            txtId.ReadOnly = false;
            _isNew = true;
        }
    }
}