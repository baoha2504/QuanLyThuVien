using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using DevExpress.XtraReports.Data;
using QLThuVien.DataAccessLayer;

namespace QLThuVien.GUI
{
    public partial class frm_DoiMK : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_DoiMK()
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(DangNhap.quyen == "ThuThu")
            {
                if (txtPass.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtPass.Focus();
                }
                else if (txtNewPass.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNewPass.Focus();
                }
                else if (txtReNewPass.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu mới !", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtReNewPass.Focus();
                }
                else if (txtNewPass.Text != txtReNewPass.Text)
                {
                    MessageBox.Show("Mật khẩu mới không trùng nhau", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNewPass.Focus();
                }
                else if (ComputeSha256Hash(txtPass.Text) != DangNhap.hashpass)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu hiện tại không chính xác", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtPass.Focus();
                }
                else
                {
                    string query = "Update ThuThu set MatKhau = '" + ComputeSha256Hash(txtNewPass.Text) + "' where MaTT ='" + DangNhap.id + "'";
                    DataAccessLayer.DataProvider.ExecuteQuery(query);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (DangNhap.quyen == "DocGia")
            {
                if (txtPass.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtPass.Focus();
                }
                else if (txtNewPass.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNewPass.Focus();
                }
                else if (txtReNewPass.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu mới !", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtReNewPass.Focus();
                }
                else if (txtNewPass.Text != txtReNewPass.Text)
                {
                    MessageBox.Show("Mật khẩu mới không trùng nhau", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtNewPass.Focus();
                }
                else if (ComputeSha256Hash(txtPass.Text) != DangNhap.hashpass)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu hiện tại không chính xác", "Cảnh báo?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtPass.Focus();
                }
                else
                {
                    string query = "Update DocGia set MatKhau = '" + ComputeSha256Hash(txtNewPass.Text) + "' where MaDG ='" + DangNhap.id + "'";
                    DataAccessLayer.DataProvider.ExecuteQuery(query);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
