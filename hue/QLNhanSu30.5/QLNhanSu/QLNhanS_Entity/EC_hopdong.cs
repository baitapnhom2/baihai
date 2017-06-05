using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanS_Entity
{
   public class EC_hopdong
    {
        private string ma;
      
        private DateTime ngayki;
        private DateTime ngayhethan;
        private string nhanvienma;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public DateTime Ngayki
        {
            get
            {
                return ngayki;
            }

            set
            {
                ngayki = value;
            }
        }

        public DateTime Ngayhethan
        {
            get
            {
                return ngayhethan;
            }

            set
            {
                ngayhethan = value;
            }
        }

        public string Nhanvienma
        {
            get
            {
                return nhanvienma;
            }

            set
            {
                nhanvienma = value;
            }
        }

     
    }
}
