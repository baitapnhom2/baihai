using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhanSu_DAL;
using QLNhanS_Entity;
namespace QLNhanSu_BUS
{
  public   class BUS_nhanvien
    {
        SQL_nhanvien sql = new SQL_nhanvien();
        public void themdulieu(EC_nhan_vien et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_nhan_vien et)

        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_nhan_vien et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
