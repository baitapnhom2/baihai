using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanSu_BUS;
using QLNhanSu_DAL;
using QLNhanS_Entity;
namespace QLNhanSu
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        
        BUS_dangnhap bus = new BUS_dangnhap();
        SQL_dangnhap sql = new SQL_dangnhap();
        EC_dangnhap ec = new EC_dangnhap();
      

        
        private void btndangnhap_Click_1(object sender, EventArgs e)
        {

            if (sql.kiemtra(txtname.Text, txtpass.Text) == 0)
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau!");
            }
            else
            {
                frmmain frm = new frmmain();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btndoimk_Click_1(object sender, EventArgs e)
        {

            frmdoimk frm = new frmdoimk();
            frm.ShowDialog();
        }

        private void rdocheck_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdocheck.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
    }
}