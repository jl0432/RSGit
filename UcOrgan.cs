using System.Windows.Forms;

namespace RandomSelection{
    public partial class UcOrgan:UserControl{
        private Organ _organ;
        public UcOrgan(){InitializeComponent();}
        public Organ Organ{
            get=>_organ ?? (_organ = new Organ());
            set{
                _organ = value ?? new Organ();
                txtId.Text = _organ.Id;
                txtName.Text = _organ.Name;
                txtAddress.Text = _organ.Address;
                txtStaff.Text = _organ.Staff;
                txtPhone.Text = _organ.Phone;
                txtRegDate.Text = _organ.RegDate;
                txtRegLocation.Text = _organ.RegLocation;
                txtRemark.Text = _organ.Remark;
            }
        }
    }
}