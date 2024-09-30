namespace Buoi8_Tung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            SinhvienIT sinhvienIT = new SinhvienIT();
            sinhvienIT.diemJava = double.Parse(txt_Java.Text);
            sinhvienIT.diemJava = double.Parse(txt_Css.Text);
            MessageBox.Show(sinhvienIT.getDiemTB().ToString() + sinhvienIT.xepLoai() );

        }

        private void btn_biz_Click(object sender, EventArgs e)
        {
            Sinhvienbiz sinhvienbiz = new Sinhvienbiz();
            sinhvienbiz.keToan = double.Parse(txt_KT.Text);
            sinhvienbiz.marketting = double.Parse(txt_MKTing.Text);
            sinhvienbiz.banHang = double.Parse(txt_Bhang.Text);
            MessageBox.Show(sinhvienbiz.getDiemTB().ToString() + sinhvienbiz.xepLoai() );
        }
    }
}
