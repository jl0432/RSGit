using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RandomSelection{
    public partial class FmMain:Form{
        private readonly RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();
        private int _idx1, _idx2 = 1, _idx3 = 2;
        public FmMain(){InitializeComponent();}
        private void tsmiInuptData_Click(object sender, EventArgs e){new FmInput().ShowDialog();}
        private void tsmiDataManage_Click(object sender, EventArgs e){new FmEdits().ShowDialog();}
        private void btnStart_Click(object sender, EventArgs e){
            if (timer.Enabled) return;
            if (Caches.Database.Organs.Count == 0) return;
            ucOrgan1.Visible = true;
            ucOrgan3.Visible = true;
            timer.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled) return;
            ucOrgan1.Visible = false;
            ucOrgan3.Visible = false;
            timer.Enabled = false;
           
                var array = new[] { _idx1, _idx2, _idx3 };
                var idx = GenerateRandomInt(0, 2);
#if DEBUG
                Console.WriteLine($@"{_idx1}|{_idx2}|{_idx3}|{idx}");
#endif
                ucOrgan2.Organ = Caches.Database.Organs[array[idx]];
#if DEBUG
            Console.WriteLine($@"{ucOrgan2.Organ.Name}|{ucOrgan2.Organ.Id}");
#endif
            Caches.Database.Log.Add(new Log
            {
                Id = ucOrgan2.Organ.Id,
                Name = ucOrgan2.Organ.Name,
                Phone = ucOrgan2.Organ.Phone,
                Staff = ucOrgan2.Organ.Staff,
                DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            });
            Operation.SaveToDb(Caches.Database);
        }
        public int GenerateRandomInt(int min, int max){
            var bytes = new byte[4];
            _rng.GetBytes(bytes);
            var seed = BitConverter.ToInt32(bytes, 0);
            var rand = new Random(seed);
            return rand.Next(min, max);
        }

        private void tsmiLogs_Click(object sender, EventArgs e)
        {
            new FmLogs().ShowDialog();
        }

        private void Random(){
            var idxb = 0;
            var idxe = Caches.Database.Organs.Count - 1;
            for(var i = 0;i < 3;i++) {
                again:
                var idx = GenerateRandomInt(idxb, idxe);
                switch(i) {
                    case 0:
                        _idx1 = idx;
                        break;
                    case 1:
                        if(_idx1 == idx) goto again;
                        _idx2 = idx;
                        break;
                    default:
                        if(_idx1 == idx || _idx2 == idx) goto again;
                        _idx3 = idx;
                        break;
                }
            }
            ucOrgan1.Organ = Caches.Database.Organs[_idx1];
            ucOrgan2.Organ = Caches.Database.Organs[_idx2];
            ucOrgan3.Organ = Caches.Database.Organs[_idx3];
        }
        private void timer_Tick(object sender, EventArgs e){Random();}
    }
}