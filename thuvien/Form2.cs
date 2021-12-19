using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuvien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void returnBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sachmuon sm = new sachmuon();
            sm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    Application.Exit();
                }
            
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbook abs = new Addbook();
            abs.Show();
        }

        private void xemSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemsach xs = new xemsach();
            xs.Show();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSinhVien tsv = new ThemSinhVien();
            tsv.Show();

        }

        private void xemThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSv a = new ThongTinSv();
            a.Show();

        }

        private void MuonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muonsach ms = new muonsach();
            ms.Show();

        }
    }
}
