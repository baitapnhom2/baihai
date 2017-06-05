using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanS_Entity
{
   public  class EC_nhan_vien
    {
        private string ma;
        private string ten;
        private DateTime ngaysinh;
        private string quequan;
        private string hesoluong;
        private string phongbanma;

      

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Quequan
        {
            get
            {
                return quequan;
            }

            set
            {
                quequan = value;
            }
        }

        public string Hesoluong
        {
            get
            {
                return hesoluong;
            }

            set
            {
                hesoluong = value;
            }
        }

        public string Phongbanma
        {
            get
            {
                return phongbanma;
            }

            set
            {
                phongbanma = value;
            }
        }


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

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
    }
}
