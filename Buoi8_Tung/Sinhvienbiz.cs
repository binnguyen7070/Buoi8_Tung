using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8_Tung
{
    internal class Sinhvienbiz : Sinhvien
    {
        public double keToan;
        public double marketting;
        public double banHang;
        public override double getDiemTB()
        {
            return( keToan + marketting +banHang )/3;
        }
             

    }
}
