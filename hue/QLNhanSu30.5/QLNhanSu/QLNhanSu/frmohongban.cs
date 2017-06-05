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
using System.Data.SqlClient;

namespace QLNhanSu
{
    public partial class frmphongban : Form
    {
        public frmphongban()
        {
            InitializeComponent();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.ShowDialog();
        }
        EC_phongban ec = new EC_phongban();
        BUS_phongban bus = new BUS_phongban();
        SQL_Phongban sql = new SQL_Phongban();
        DataTable dt = new DataTable();
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlConnection connect = new SqlConnection();

        bool themmoi;
        void khoadieukien()
        {
            txtmapb.Enabled = false;

            txttenpb.Enabled = false;

            txtsdt.Enabled = false;
            txtdiachi.Enabled = false;
       

            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btncapnhat.Enabled = false;
        }
        void modieukien()
        {
            txtmapb.Enabled = true;

            txttenpb.Enabled = true;

            txtsdt.Enabled = true;
            txtdiachi.Enabled = true;

          
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btncapnhat.Enabled = true;
        }
        void setnull()
        {
            txtmapb.Text = "";

            txttenpb.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";

           
        }
        void hienthi(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvphongban.DataSource = dt;
        }
        public static string map;

        private void frmphongban_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            modieukien();
            setnull();
            themmoi = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            modieukien();
            txtmapb.Enabled = false;
            themmoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Ma = txtmapb.Text;
                bus.xoadulieu(ec);
                MessageBox.Show("Da xoa!");
                khoadieukien();
                setnull();
                hienthi("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            if (themmoi == true)
            {
                try
                {
                    ec.Ma = txtmapb.Text;

                    ec.Ten = txttenpb.Text;

                    ec.Sdt = txtsdt.Text;
                    ec.Diachi = txtdiachi.Text;

                   

                    bus.themdulieu(ec);
                    MessageBox.Show("Them thanh cong!");
                    khoadieukien();
                    setnull();
                    hienthi("");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            else
            {
                try
                {
                    ec.Ma = txtmapb.Text;

                    ec.Ten = txttenpb.Text;

                    ec.Sdt = txtsdt.Text;
                    ec.Diachi = txtdiachi.Text;
                 
                    bus.suadulieu(ec);
                    MessageBox.Show("Sua thanh cong!");
                    khoadieukien();
                    setnull();
                    hienthi("");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmapb.Text = dgvphongban.Rows[e.RowIndex].Cells[0].Value.ToString();

                txttenpb.Text = dgvphongban.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdiachi.Text = dgvphongban.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsdt.Text = dgvphongban.Rows[e.RowIndex].Cells[3].Value.ToString();
              
              


            }
            catch
            {

            }
        }


    }
}