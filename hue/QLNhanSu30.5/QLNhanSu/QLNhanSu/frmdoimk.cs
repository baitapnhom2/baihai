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
    public partial class frmdoimk : Form
    {
        public frmdoimk()
        {
            InitializeComponent();
        }

        BUS_dangnhap bus = new BUS_dangnhap();
        SQL_dangnhap sql = new SQL_dangnhap();
        EC_dangnhap ec = new EC_dangnhap();
        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (sql.kiemtra(txtname.Text, txtmkcu.Text) == 0)
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau cu!");
            }
            else
            {
                ec.Username = txtname.Text;
                ec.Pass = txtmkmoi.Text;
                bus.doimatkhau(txtname.Text, txtmkmoi.Text, ec);
                MessageBox.Show("Doi thanh cong!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
