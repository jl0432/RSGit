using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RandomSelection{
    public partial class FmInput:Form{
        private List<Organ> _list;
        public FmInput(){InitializeComponent();}
        private void btnPath_Click(object sender, EventArgs e){
            var openFile = new OpenFileDialog();
            openFile.FileName = @"选择一个CSV数据文件";
            openFile.Filter = @"CSV数据文件 （*.csv）|*.csv";
            openFile.Title = @"选择一个CSV数据文件";
            if(openFile.ShowDialog() != DialogResult.OK) return;
            txtPath.Text = openFile.FileName;
            ActionCsv();
        }
        private void btnRef_Click(object sender, EventArgs e){ActionCsv();}
        public void ActionCsv(){
            try {
                if(!File.Exists(txtPath.Text)) return;
                var arrays = Operation.LoadFoCsv(txtPath.Text, chkSkipInvalid.Checked ? 8 : 0, chkSkipT1.Checked);
                _list = Operation.GetOrgans(arrays);
                dgvMain.DataSource = _list;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInput_Click(object sender, EventArgs e){
            if(_list == null || _list.Count == 0) return;
            if(MessageBox.Show($@"是否确认导入“{_list.Count}”条数据？", @"提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            if(Caches.Database.Organs == null) Caches.Database.Organs = new List<Organ>();
            int hs = 0, us = 0;
            foreach(var o in _list)
                if(Caches.Database.Organs.Exists(p=>p.Id == o.Id)) {
                    hs++;
                    continue;
                }
                else {
                    us++;
                    Caches.Database.Organs.Add(o);
                }
            Operation.SaveToDb(Caches.Database);
            var msg = string.Empty;
            if (hs != 0) msg = $"其中“{hs}”条重复数据。";
            MessageBox.Show($@"共“{_list.Count}”条数据，已成功导入“{us}”条数据！{msg}",@"提示");
        }
    }
}