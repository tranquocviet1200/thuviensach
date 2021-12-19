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
    public partial class muonsach : Form
    {
        public muonsach()
        {
            InitializeComponent();
        }

        private void muonsach_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();


            cmd = new SqlCommand("select bName from newbook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();
           
            while (Sdr.Read())
            {
                for (int i =0; i< Sdr.FieldCount; i++)
                {
                    comboBoxBook.Items.Add(Sdr.GetString(i));

                }
            }
            Sdr.Close();
            con.Close();
        }
        int count;
        private void btnTimsv_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text != "")
            {
                String smasv = txtMasv.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent13 where masv = '" +smasv+ "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //...............................................
                //code dem bao nhieu sach muon msv
                cmd.CommandText = "select count(mmasv) from muonsach where mmasv = '" + smasv + "' and ngaytra is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //...............................................

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtLop.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtKhoa.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtDiachi.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtSodienthoai.Text = DS.Tables[0].Rows[0][6].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][7].ToString();

                }
                else
                {
                    txtName.Clear();
                    txtLop.Clear();
                    txtKhoa.Clear();
                    txtDiachi.Clear();
                    txtSodienthoai.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Mã sinh viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                if (comboBoxBook.SelectedIndex != -1 && count <= 2)
                {

                    String masv = txtMasv.Text;
                    String name = txtName.Text;
                    String lop = txtLop.Text;
                    String khoa = txtKhoa.Text;
                    String diachi = txtDiachi.Text;
                    Int64 sodienthoai = Int64.Parse(txtSodienthoai.Text);
                    String email = txtEmail.Text;
                    String bookname = comboBoxBook.Text;
                    String ngaymuon = dateTimePicker1.Text;


                    String smasv = txtMasv.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-J2QPCQI\SQLEXPRESS;Initial Catalog=tranquocviet1;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                   

                   

                    cmd.CommandText = cmd.CommandText= "insert into muonsach (mmasv, mname, mlop, mkhoa, mdiachi, msodienthoai, memail, tensach, ngaymuon) values ('" + masv+"','"+name+"','"+lop+"','"+khoa+"', '"+diachi+"', '"+sodienthoai+"', '"+email+"', '"+bookname+"', '"+ngaymuon+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();



                    MessageBox.Show("Mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Chưa mượn sách hoặc đã mượn tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Không tồn tại mã sinh viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtMasv_TextChanged(object sender, EventArgs e)
        {
            if(txtMasv.Text == "")
            {
                txtName.Clear();
                txtLop.Clear();
                txtKhoa.Clear();
                txtDiachi.Clear();
                txtSodienthoai.Clear();
                txtEmail.Clear();

            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMasv.Clear();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
          
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
