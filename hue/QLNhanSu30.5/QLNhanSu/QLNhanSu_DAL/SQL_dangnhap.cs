using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhanS_Entity;

namespace QLNhanSu_DAL
{
  public   class SQL_dangnhap
    {
        ketnoi kn = new ketnoi();
        public int kiemtra(string id, string pass)
        {
            return int.Parse(kn.GetValue("select count(*) from dangnhap where username='" + id + "' and pass='" + pass + "'"));
        }
        public void doimatkhau(string id, string pass, EC_dangnhap et)
        {
            kn.ThucThiCauLenhSQL("update dangnhap set username='" + id + "',pass='" + pass + "' where username='" + et.Username + "' and pass='" + et.Pass + "'");
        }
    }
}

