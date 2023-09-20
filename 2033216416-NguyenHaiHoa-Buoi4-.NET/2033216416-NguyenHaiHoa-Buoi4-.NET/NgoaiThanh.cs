using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033216416_NguyenHaiHoa_Buoi4_.NET
{
    internal class NgoaiThanh:ChuyenXe
    {
        private string NoiDen;
        private int SoNgayDiDuoc;

        public string _NoiDen { get => NoiDen; set => NoiDen = value; }
        public int _SoNgayDiDuoc { get => SoNgayDiDuoc; set => SoNgayDiDuoc = value; }
        public NgoaiThanh(string NoiDen,int SoNgayDiDuoc) {
            this.NoiDen = NoiDen;
            this.SoNgayDiDuoc = SoNgayDiDuoc;
        }
        public NgoaiThanh() {
            NoiDen = "Tp.hcm";
            SoNgayDiDuoc = 5;
        }
        public override void Nhap() {
            Console.WriteLine("Moi nhap Noi den:");
            NoiDen = Console.ReadLine();
            Console.WriteLine("Moi nhap So ngay di duoc:");
            SoNgayDiDuoc = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Noi den:{0} \nSo ngay di:{1}",NoiDen,SoNgayDiDuoc);
            Console.WriteLine("Tong so tien phai tra la :{0}",TongDoanhThu(DoanhThu));
        }
        public override double TongDoanhThu(double DoanhThu)
        {
            return DoanhThu * SoNgayDiDuoc;
        }
    }
}
