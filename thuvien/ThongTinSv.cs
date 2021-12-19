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
    public partial class ThongTinSv : Form
    {
        public ThongTinSv()
        {
            InitializeComponent();
        }

        private void txtTimsv_TextChanged(object sender, EventArgs e)
        {
            if (txtTimsv.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent13 where masv LIKE '" + txtTimsv.Text + "%' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent13 ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                dataGridView1.DataSource = DS.Tables[0];
            }
        }
        private void ThongTinSv_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent13 ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            dataGridView1.DataSource = DS.Tables[0];
        }
        int id;
        Int64 rowid1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent13 where svid = "+id+" ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            rowid1 = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtMasv.Text = DS.Tables[0].Rows[0][1].ToString();
            txtTensv.Text = DS.Tables[0].Rows[0][2].ToString();
            txtLop.Text = DS.Tables[0].Rows[0][3].ToString();
            txtKhoa.Text = DS.Tables[0].Rows[0][4].ToString();
            txtDiachi.Text = DS.Tables[0].Rows[0][5].ToString();
            txtSodt.Text = DS.Tables[0].Rows[0][6].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][7].ToString();

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            String sma = txtMasv.Text;
            String sname = txtTensv.Text;
            String slop = txtLop.Text;
            String skhoa = txtKhoa.Text;
            String sdiachi = txtDiachi.Text;
            Int64 sdienthoai = Int64.Parse(txtSodt.Text);
            String semail = txtEmail.Text;

            if (MessageBox.Show(" Bạn chắc không?", "Update ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent13 set masv  = '" + sma + "', name = '" + sname + "', lop = '" + slop + "', khoa = '" + skhoa + "', diachi = '" + sdiachi + "', sodienthoai = '" + sdienthoai + "', email ='" + semail + "' where svid = " + rowid1 + "    ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //load lai du lieu
                ThongTinSv_Load(this,null);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ThongTinSv_Load(this,null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn chắc không?", "Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent13 where svid = " + rowid1 + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //load lai du lieu
                ThongTinSv_Load(this, null);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ không lưu", "Bạn có chắc muốn thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
