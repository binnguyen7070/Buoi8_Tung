using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8_Tung
{
    internal class SinhvienIT : Sinhvien
    {
        public double diemJava;
        public double diemCss;
        public override double getDiemTB()
        {
            return (2 * diemJava + diemCss)/3;
        }


    }
}
