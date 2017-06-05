using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhanS_Entity;
namespace QLNhanSu_DAL
{
   public   class SQL_hopdong
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_hopdong ec)
        {
            string sql = "themhd";
            int so_luong = 4;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@ma"; Values[0] = ec.Ma;
            Name[1] = "@nhanvienma"; Values[1] = ec.Nhanvienma;
            Name[2] = "@ngayki"; Values[2] = ec.Ngayki.ToString();
            Name[3] = "@ngayhethan"; Values[3] = ec.Ngayhethan.ToString();
           
          
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void xoadulieu(EC_hopdong ec)
        {
            kn.ThucThiCauLenhSQL("delete hopdong where ma='" + ec.Ma + "'");
        }
        public void suadulieu(EC_hopdong ec)
        {
            kn.ThucThiCauLenhSQL("update hopdong set nhanvienma =N'" + ec.Nhanvienma + "', ngayki = N'" + ec.Ngayki+"' ,ngayhethan =N'"+ec.Ngayhethan+"'  where ma='" + ec.Ma + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from hopdong " + dieukien);
        }
    }
}

