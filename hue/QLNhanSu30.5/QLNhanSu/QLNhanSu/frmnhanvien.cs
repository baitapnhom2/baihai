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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        EC_nhan_vien ec = new EC_nhan_vien();
        BUS_nhanvien bus = new BUS_nhanvien();
        SQL_nhanvien sql = new SQL_nhanvien();
        DataTable dt = new DataTable();
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlConnection connect = new SqlConnection();
        bool themmoi;
        void khoadieukien()
        {
            txtmanv.Enabled = false;
          
            txttennv.Enabled = false;
            datengaysinh.Enabled = false;
         
            txtdiachi.Enabled = false;
            txtphongban.Enabled = false;
            txthesoluong.Enabled = false;
         
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btncapnhat.Enabled = false;
        }
        void modieukien()
        {
            txtmanv.Enabled = true;
           
            txttennv.Enabled = true;
            datengaysinh.Enabled = true;
         
            txtdiachi.Enabled = true;
            txthesoluong.Enabled = true;
            txtphongban.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btncapnhat.Enabled = true;
        }
        void setnull()
        {
            txtmanv.Text = "";
            
            txttennv.Text = "";
            
            txtdiachi.Text = "";
            txthesoluong.Text = "";
            txtphongban.Text = "";
        }
        void hienthi(string where)
        {
            DataTable dt = bus.taobang(where);

            dgvnhanvien.DataSource = dt;
        }
        public static string map;
     

        private void btnthem_Click(object sender, EventArgs e)
        {
            modieukien();
            setnull();
            themmoi = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            modieukien();
            txtmanv.Enabled = false;
            themmoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Ma = txtmanv.Text;
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
                    ec.Ma = txtmanv.Text;
                    
                    ec.Ten = txttennv.Text;
                    ec.Ngaysinh = Convert.ToDateTime(datengaysinh.Text);
                   
                    ec.Quequan = txtdiachi.Text;
                    ec.Hesoluong = txthesoluong.Text;
                    ec.Phongbanma = txtphongban.Text;
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
                    ec.Ma = txtmanv.Text;
                 
                    ec.Ten = txttennv.Text;
                    ec.Ngaysinh = Convert.ToDateTime(datengaysinh.Text);
                   
                    ec.Quequan = txtdiachi.Text;
                    ec.Hesoluong = txthesoluong.Text;
                    ec.Phongbanma = txtphongban.Text;
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

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmanv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
               
                txttennv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                datengaysinh.Text = dgvnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
               
                txtdiachi.Text = dgvnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtphongban.Text = dgvnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txthesoluong.Text = dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString(); 
            }
            catch
            {

            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            modieukien();
            hienthi("where tennv like N'%" + txttimkiem.Text + "%'");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void frmnhanvien_Load_1(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhopdong frm = new frmhopdong();
            frm.ShowDialog();
        }
    }
}
