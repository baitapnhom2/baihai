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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {

            frmnhanvien frm = new frmnhanvien();
            frm.ShowDialog();
        }

        private void btnphieuxuat_Click(object sender, EventArgs e)
        {
            frmphongban frm = new frmphongban();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmTrogiup frm = new frmTrogiup();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
