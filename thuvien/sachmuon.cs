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
    public partial class sachmuon : Form
    {
        public sachmuon()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from muonsach where mmasv = '"+txtMasv.Text+"' and ngaytra IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("Sinh Viên Chưa Mượn Sách Hoặc Mã Sinh Viên Không Tồn Tại", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void sachmuon_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            txtMasv.Clear();

        }

        String name;
        String ngay;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                name = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                ngay = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
            txtTensach.Text = name;
            txtNgaymuon.Text = ngay;

        }

        private void btnTra_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "update muonsach set ngaytra = '" + dateTimePicker1.Text + "' where mmasv = '" + txtMasv.Text + "' and id = "+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Đã Trả", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sachmuon_Load(this, null);

        }

        private void txtMasv_TextChanged(object sender, EventArgs e)
        {
            if (txtMasv.Text == "")
            {
                panel3.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMasv.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void txtTensach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
