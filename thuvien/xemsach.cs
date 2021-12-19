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
    public partial class xemsach : Form
    {
        public xemsach()
        {
            InitializeComponent();
        }

        private void xemsach_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select *from newbook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];



            
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
             
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select *from newbook where bid = "+bid+" ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtTenSach.Text = ds.Tables[0].Rows[0][1].ToString();
            txtTacgia.Text = ds.Tables[0].Rows[0][2].ToString();
            txtNhaxb.Text = ds.Tables[0].Rows[0][3].ToString();
            txtNgay.Text = ds.Tables[0].Rows[0][4].ToString();
            txtGia.Text = ds.Tables[0].Rows[0][5].ToString();
            txtSoluong.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void txtStensach_TextChanged(object sender, EventArgs e)
        {
            if (txtStensach.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select *from newbook where bName LIKE '"+txtStensach.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select *from newbook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtStensach.Clear();
            panel2.Visible = false;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn chắc không?", "Update ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String tensach = txtTenSach.Text;
                String tacgia = txtTacgia.Text;
                String nhaxb = txtNhaxb.Text;
                String ngay = txtNgay.Text;
                Int64 gia = Int64.Parse(txtGia.Text);
                Int64 soluong = Int64.Parse(txtSoluong.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " update newbook set bName ='" + tensach + "' ,bAuthor = '" + tacgia + "', bXuatban = '" + nhaxb + "', bPdate = '" + ngay + "', bGia = " + gia + " , bSoluong =" + soluong + " where bid = " + rowid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn chắc không?", " Delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String tensach = txtTenSach.Text;
                String tacgia = txtTacgia.Text;
                String nhaxb = txtNhaxb.Text;
                String ngay = txtNgay.Text;
                Int64 gia = Int64.Parse(txtGia.Text);
                Int64 soluong = Int64.Parse(txtSoluong.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from newbook where bid = "+rowid+" ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
