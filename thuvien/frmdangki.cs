using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace thuvien
{
    public partial class frmdangki : Form
    {
        
        public frmdangki()
        {
            InitializeComponent();
        }

        

        private void btnNDangki_Click(object sender, EventArgs e)
        {
            if (txtNUser.Text != "" && txtNpassword.Text != "")
            {
                String user = txtNUser.Text;
                String pass = txtNpassword.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " insert into loginTable (username , pass) values ('" + user + "', '" + pass + "')";
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Đã đăng kí thằng công", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNUser.Clear();
                txtNpassword.Clear();

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmdangki_Load(object sender, EventArgs e)
        {

        }

        private void txtNUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNUser.Text == "Nhập Tên tài khoản mới")
            {
                txtNUser.Clear();
            }
        }

        private void txtNpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNpassword.Text == "Nhập Mật khẩu")
            {
                txtNpassword.Clear();
                txtNpassword.PasswordChar = '*';
            }
        }
    }
}
