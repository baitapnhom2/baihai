using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhanS_Entity;
namespace QLNhanSu_DAL
{
   public   class SQL_Phongban
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_phongban ec)
        {
            string sql = "thempb";
            int so_luong = 5;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@ma"; Values[0] = ec.Ma;
            Name[1] = "@ten"; Values[1] = ec.Ten;
            Name[2] = "@diachi"; Values[2] = ec.Diachi;
            Name[3] = "@sdt"; Values[3] = ec.Sdt;
            Name[4] = "@truongphong"; Values[4] = ec.Tentruongphong;
           
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void xoadulieu(EC_phongban ec)
        {
            kn.ThucThiCauLenhSQL("delete phongban where ma='" + ec.Ma + "'");
        }
        public void suadulieu(EC_phongban ec)
        {
            kn.ThucThiCauLenhSQL("update phongban set ten=N'" + ec.Ten + "',sdt='" + ec.Sdt + "',diachi=N'" + ec.Diachi + "',truongphong = N'"+ec.Tentruongphong+"' where ma='" + ec.Ma + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from phongban " + dieukien);
        }
    }
}

