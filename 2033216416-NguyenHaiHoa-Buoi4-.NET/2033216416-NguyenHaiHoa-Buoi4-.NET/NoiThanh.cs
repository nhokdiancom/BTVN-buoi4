using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033216416_NguyenHaiHoa_Buoi4_.NET
{
    internal class NoiThanh:ChuyenXe
    {
        private string SoTuyen;
        private double SoKM;

        public string _SoTuyen { get => SoTuyen; set => SoTuyen = value; }
        public double _SoKM { get => SoKM; set => SoKM = value; }
        public NoiThanh(string SoTuyen, double SoKM)
        {
            this.SoTuyen = SoTuyen;
            this.SoKM = SoKM;
        }
        public NoiThanh()
        {
            SoTuyen = "52A";
            SoKM = 20;
        }

        public override void Nhap()
        {
            Console.WriteLine("Moi nhap So Tuyen xe:");
            SoTuyen = Console.ReadLine();
            Console.WriteLine("Moi nhap So km di duoc:");
            SoKM = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("SoTuyen:{0} \nSo KM di duoc:{1}", SoTuyen, SoKM);
            Console.WriteLine("Tong so tien phai tra la:{0}", TongDoanhThu(DoanhThu));
        }
        public override double TongDoanhThu(double DoanhThu)
        {
            return DoanhThu * SoKM;
        }
    }
}
