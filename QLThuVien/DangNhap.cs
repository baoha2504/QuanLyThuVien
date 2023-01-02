using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLThuVien.GUI;
using System.Collections;
using DevExpress.XtraEditors;
using System.Windows.Forms.VisualStyles;
using QLThuVien.DataAccessLayer;
using System.Security.Cryptography;

namespace QLThuVien
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap login;
        public static string name;
        public static string id;
        
        public DangNhap()
        {
            InitializeComponent();
        }

        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            string User = txt_user.Text;
            string Password = txt_pass.Text;
            DataTable log1 = new DataTable();
            string sql1 = "select *from ThuThu where MaTT= '" + User + "'" + "and MatKhau = '" + ComputeSha256Hash(Password) + "'";
            log1 = DataProvider.GetData(sql1);
            int i = 0;
            i = log1.Rows.Count;
            if (i == 1)
            {
                foreach (DataRow dr in log1.Rows)
                {
                    name = dr["TenTT"].ToString();
                    id = dr["MaTT"].ToString();
                }
                this.Hide();
                frmThuThu frmThuThu = new frmThuThu();
                frmThuThu.Show();
            }
            else
            {
                DataTable log2 = new DataTable();
                string sql2 = "select *from DocGia where MaDG= '" + User + "'" + "and MatKhau = '" + ComputeSha256Hash(Password) + "'";
                log2 = DataProvider.GetData(sql2);
                int j = log2.Rows.Count;
                if (j == 1)
                {
                    foreach (DataRow dr in log2.Rows)
                    {
                        name = dr["TenDG"].ToString();
                        id = dr["MaDG"].ToString();
                    }
                    this.Hide();
                    frmDocGia frmDocGia = new frmDocGia();
                    frmDocGia.Show();
                }
                else
                {
                    lbl_TTlogin.Text = "Thông tin sai!!";
                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void chk_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show.Checked) txt_pass.UseSystemPasswordChar = false;
            
            else txt_pass.UseSystemPasswordChar = true;
        }
    }
}