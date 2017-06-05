using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhanS_Entity;
namespace QLNhanSu_DAL
{
   public  class SQL_nhanvien
    {

        ketnoi kn = new ketnoi();
        public int themdulieu( EC_nhan_vien ec)
        {
            string sql = "themnv";
            int so_luong = 7;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@ma"; Values[0] = ec.Ma;
            Name[1] = "@ten"; Values[1] = ec.Ten;
            Name[2] = "@ngaysinh"; Values[2] = ec.Ngaysinh.ToString();
           
            Name[3] = "@quequan"; Values[3] = ec.Quequan;
            Name[4] = "@phongbanma"; Values[4] = ec.Phongbanma;
            Name[5] = "@hesoluong"; Values[5] = ec.Hesoluong;
           
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void xoadulieu(EC_nhan_vien ec)
        {
            kn.ThucThiCauLenhSQL("delete nhansu where ma='" + ec.Ma + "'");
        }
        public void suadulieu(EC_nhan_vien ec)
        {
            kn.ThucThiCauLenhSQL("update nhansu set ngaysinh=N'" + ec.Ngaysinh + "',ten='" + ec.Ten + "',quequan=N'" + ec.Quequan + "', hesoluong = N'"+ec.Hesoluong+"',phongbanma = N'"+ec.Phongbanma+"' where ma='" + ec.Ma + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from nhansu " + dieukien);
        }
    }
}

