using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class frm_QuyDinh : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_QuyDinh()
        {
            InitializeComponent();
        }

        private void frm_QuyDinh_Load(object sender, EventArgs e)
        {
            string a = File.ReadAllText("C:\\Users\\DELL\\Desktop\\code\\QuanLyThuVien\\QLThuVien\\QuyDinh.txt");
            txtNoiDung.Text = a;
        }
    }
}
