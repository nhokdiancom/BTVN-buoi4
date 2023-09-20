using System;

namespace _2033216416_NguyenHaiHoa_Buoi4_.NET
{
    internal class ToaDo
    {
        private string _ten;
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private double x;

        private double y;
        public ToaDo()
        {
            x = 0;
            y = 0;
        }

        public ToaDo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX() { return x; }
        public double GetY() { return y; }

        public void SetX(double x) { }
        public void SetY(double y) { }

        public void nhap()
        {
            Console.WriteLine("Nhap tam toa do: ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

        }
        public void xuat()
        {
            Console.Write("Tam O({0},{1})", x, y);
        }
    }
}