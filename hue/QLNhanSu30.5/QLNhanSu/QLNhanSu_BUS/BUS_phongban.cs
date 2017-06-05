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
   public  class BUS_phongban
    {
        SQL_Phongban sql = new SQL_Phongban();
     

      
        public void themdulieu(EC_phongban et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_phongban et)

        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_phongban et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}

