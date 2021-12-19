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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text=="Tên đăng nhập")
            {
                txtUsername.Clear();
            }    
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtPassword.Text =="Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM loginTable WHERE username='" + txtUsername.Text + "' AND pass='" + txtPassword.Text + "'", con);
            
            DataTable dt = new DataTable();  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                this.Hide();
                new Form2().Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            frmdangki x = new frmdangki();
            x.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
