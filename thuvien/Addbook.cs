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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTensach.Text != "" && txtTacgia.Text != "" && txtXuatban.Text != "" && txtGia.Text != "" && txtSoluong.Text != "")
            {
                String bName = txtTensach.Text;
                string bAuthor = txtTacgia.Text;
                string Nhaxuatban = txtXuatban.Text;
                string Ngay = dateTimePicker1.Text;
                Int64 Gia = Int64.Parse(txtGia.Text);
                Int64 soluong = Int64.Parse(txtSoluong.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into newbook (bName, bAuthor, bXuatban, bPdate, bGia, bSoluong) values ( '" + bName + "','" + bAuthor + "', '" + Nhaxuatban + "', '" + Ngay + "', " + Gia + ", " + soluong + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Đã lưu thông tin", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTensach.Clear();
                txtTacgia.Clear();
                txtXuatban.Clear();
                txtGia.Clear();
                txtSoluong.Clear();

            }
            else
            {
                MessageBox.Show("Bạn không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show ("Bạn có chắc muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }    
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTensach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
