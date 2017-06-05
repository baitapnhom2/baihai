using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhanS_Entity;
using QLNhanSu_DAL;
namespace QLNhanSu_BUS
{
    public class BUS_dangnhap
    {
        SQL_dangnhap sql = new SQL_dangnhap();
        public void kiemtra(string id, string pass)
        {
            sql.kiemtra(id, pass);
        }
        public void doimatkhau(string id, string pass, EC_dangnhap et)
        {
            sql.doimatkhau(id, pass, et);
        }
    }
}
