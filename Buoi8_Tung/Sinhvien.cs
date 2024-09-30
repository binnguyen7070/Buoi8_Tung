using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8_Tung
{
  abstract  internal class Sinhvien
    {
        public String hoTen;
   abstract     public double getDiemTB();
        public virtual string xepLoai()
        {
            if (getDiemTB() > 5 && getDiemTB() < 7)
            {
                return "Trung binh";
            }
            else if (getDiemTB() > 7)
            {
                return "Gioi";
            }
            else
            {
                return "Yeu";

            }
            return "Kem";
        }




    }
  }