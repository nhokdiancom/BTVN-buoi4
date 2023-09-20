using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033216416_NguyenHaiHoa_Buoi4_.NET
{
    class ChuyenXe
    {
        public string MaSoChuyen;
        public string HoTen;
        public string SoXe;
        public double DoanhThu;
        public string _MaSoChuyen { get => MaSoChuyen; set => MaSoChuyen = value; }
        public string _HoTen { get => HoTen; set => HoTen = value; }
        public string _SoXe { get => SoXe; set => SoXe = value; }
        public double _DoanhThu { get => DoanhThu; set => DoanhThu = value; }

        public ChuyenXe(string MaSoChuyen,string HoTen,string SoXe,double DoanhThu){
            this.MaSoChuyen = MaSoChuyen;
            this.HoTen = HoTen;
            this.SoXe = SoXe;
            this.DoanhThu = DoanhThu;
        }
        public ChuyenXe() {
            MaSoChuyen = "452A";
            HoTen = "Nguyen Tien Dung";
            SoXe = "8135BA5358";
            DoanhThu = 12000;
        }
        public virtual void Nhap() {
            Console.WriteLine("Moi nhap Ma so chuyen xe:");
            MaSoChuyen = Console.ReadLine();
            Console.WriteLine("Moi nhap Ho Ten tai xe:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Moi nhap So xe:");
            SoXe = Console.ReadLine();
            Console.WriteLine("Moi nhap Doanh thu:");
            DoanhThu = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat() {
            Console.WriteLine("Ma so chuyen xe:{0} \nHo Ten tai xe:{1} \nSo xe:{2} \nDoanh Thu:{5}", MaSoChuyen, HoTen, SoXe, DoanhThu);
        }
        public virtual double TongDoanhThu(double DoanhThu) {
            return DoanhThu;
        }
    }
}
