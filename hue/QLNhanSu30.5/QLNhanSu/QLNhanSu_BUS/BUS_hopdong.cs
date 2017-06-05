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
    public  class BUS_hopdong
    {
        SQL_hopdong sql = new SQL_hopdong();
     
        public void themdulieu(EC_hopdong et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_hopdong et)

        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_hopdong et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
