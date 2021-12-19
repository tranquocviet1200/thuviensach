using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuvien
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLop.Clear();
            txtMasv.Clear();
            txtDiachi.Clear();
            txtSodienthoai.Clear();
            txtEmail.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLop.Text != "" && txtMasv.Text != "" && txtDiachi.Text != "" && txtSodienthoai.Text != "" && txtEmail.Text != "")
            {
                String masv = txtMasv.Text;
                String name = txtName.Text;
                String lop = txtLop.Text;
                String khoa = txtMasv.Text;
                String diachi = txtDiachi.Text;
                Int64 mobile = Int64.Parse(txtSodienthoai.Text);
                String email = txtEmail.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "  insert into NewStudent13 (masv, name, lop, khoa, diachi, sodienthoai, email) values ('"+masv+"','" + name + "', '" + lop + "','" + khoa + "','" + diachi + "','" + mobile + "','" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bạn muốn lưu không?", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtMasv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
