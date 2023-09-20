using System;

namespace _2033216416_NguyenHaiHoa_Buoi4_.NET
{
    internal class HinhTron : ToaDo
    {
        private double _BanKinh;
        ToaDo tam = new ToaDo();

        public double GetBanKinh()
        {
            return _BanKinh;
        }

        public ToaDo GetTam()
        {
            return tam;
        }


        public void SetBanKinh() { }
        public void SetTam() { }
        public double tinhChuVi()
        {
            return _BanKinh * 2 * 3.14;
        }
        public double tinhDienTich()
        {
            return _BanKinh * _BanKinh * 3.14;
        }


        public HinhTron()
        {

        }
        public HinhTron(double bankinh, ToaDo tam)
        {
            this._BanKinh = bankinh;
            this.tam = tam;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ban kinh: ");
            _BanKinh = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine(" voi ban kinh {0}", _BanKinh);
            Console.WriteLine("Chu vi hinh tron la: {0}", tinhChuVi());
            Console.WriteLine("Dien tich hinh tron la: {0}", tinhDienTich());
        }
    }
}