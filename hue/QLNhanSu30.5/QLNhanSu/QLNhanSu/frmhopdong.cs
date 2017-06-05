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
    public partial class frmhopdong : Form
    {
        public frmhopdong()
        {
            InitializeComponent();
        }
        private void btnhienthi_Click(object sender, EventArgs e)
        {
            frmhopdong frm = new frmhopdong();
            frm.ShowDialog();
        }
        EC_hopdong ec = new EC_hopdong();
        BUS_hopdong bus = new BUS_hopdong();
        SQL_hopdong sql = new SQL_hopdong();
        DataTable dt = new DataTable();
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlConnection connect = new SqlConnection();


        bool themmoi;
        void khoadieukien()
        {
            txtmahd.Enabled = false;

           
            txtmanhanvien.Enabled = false;
            dtpngayky.Enabled = false;
            dtpngayhet.Enabled = false;


            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btncapnhat.Enabled = false;
        }
        void modieukien()
        {

            txtmahd.Enabled = true;

            txtmanhanvien.Enabled = true;
            dtpngayky.Enabled = true;
            dtpngayhet.Enabled = true;

           
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btncapnhat.Enabled = true;
        }
        void setnull()
        {
            txtmahd.Text = "";

       
            txtmanhanvien.Text = "";
            dtpngayhet.Text = "";
            dtpngayky.Text = "";
        }
        void hienthi(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvhopdong.DataSource = dt;
        }
        public static string map;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmhopdong_Load(object sender, EventArgs e)
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
            txtmahd.Enabled = false;
            themmoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Ma = txtmahd.Text;
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
                    ec.Ma = txtmahd.Text;
                    ec.Nhanvienma = txtmanhanvien.Text;
                
                    ec.Ngayki = Convert.ToDateTime(dtpngayky.Text);
                    ec.Ngayhethan = Convert.ToDateTime(dtpngayhet.Text);
                 

                    bus.themdulieu(ec);
                    MessageBox.Show("Them thanh cong!");
                    setnull();
                    khoadieukien();
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
                    

                    ec.Ma = txtmahd.Text;
                    ec.Nhanvienma = txtmanhanvien.Text;
                
                    ec.Ngayki = Convert.ToDateTime(dtpngayky.Text);
                    ec.Ngayhethan = Convert.ToDateTime(dtpngayhet.Text);

                    bus.suadulieu(ec);
                    MessageBox.Show("Sua thanh cong!");
                    setnull();
                    khoadieukien();
                    hienthi("");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
           
        }

        private void dgvhopdong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmahd.Text = dgvhopdong.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtmanhanvien.Text = dgvhopdong.Rows[e.RowIndex].Cells[1].Value.ToString();

                dtpngayky.Text = dgvhopdong.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpngayhet.Text = dgvhopdong.Rows[e.RowIndex].Cells[3].Value.ToString();
               

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
