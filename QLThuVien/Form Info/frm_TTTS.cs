using QLThuVien.BUSLayer;
using System;
using System.Data;
namespace QLThuVien.Form_Info
{
    public partial class frm_TTTS : DevExpress.XtraEditors.XtraForm
    {
        public static string MaTS;
        public frm_TTTS()
        {
            InitializeComponent();
        }

        private void frm_TTTS_Load(object sender, EventArgs e)
        {
            //if (MaTS != string.Empty)
            //{
            //    char MaTS1 = Convert.ToChar(MaTS);
            //    DataTable dt = BUS.Get_TS(MaTS1);
            //    txt_MaTS.Text = MaTS;
            //}
        }
    }
}