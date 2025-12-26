using System.Drawing;

namespace BTVN_Bai3_PC10_PhamDucQuy
{
    internal class Program
    {
        #region
        //Bai 1
        const double VAT = 0.1;
        static double nhapDonGia()
        {
            Console.Write("Nhap Don Gia: ");
            double donGia = Convert.ToDouble(Console.ReadLine());
            return donGia;
        }
        static int nhapSoLuong()
        {
            Console.Write("Nhap so luong: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());
            return soLuong;
        }
        static int tangSoLuong(ref int soLuong)
        {
            soLuong++;
            Console.WriteLine("So luong sau khi tang la: " + soLuong);
            return soLuong;
        }
        static void tinhtoan(out double tongTien, out double thueVAT, double donGia, double soLuong)
        {
            double thanhTien = donGia * soLuong;
            thueVAT = thanhTien * VAT;
            tongTien = thanhTien + thueVAT;
        }
        #endregion
        #region
        //Bai 2
        const int KW_TO_KWH = 1000;
        const int PRICE_PER_KWH = 2500;
        static int soDienTieuTHu()
        {
            Console.Write("So dien tieu thu(Wh) la: ");
            int soDien = Convert.ToInt32(Console.ReadLine());
            return soDien;
        }
        static double tinhTienDien(ref int soDien)
        {
            double soDien2 = (double)soDien / KW_TO_KWH;
            double tongTienDien = soDien2 * PRICE_PER_KWH;
            soDien = (int)soDien2;
            return tongTienDien;
        }
        #endregion
        #region
        //Bai 3
        const int MIN_PER_HOUR = 60;
        const int SALARY_PER_HOUR = 45000;
        static double tienLuong(ref int soPhut)
        {
            double soGio = (double)soPhut / MIN_PER_HOUR;
            double tongTienLuong = soGio * SALARY_PER_HOUR;
            soPhut = (int)soGio;
            return tongTienLuong;
        }
        #endregion
        #region
        //Bai 4
        const double VAT2 = 0.1;
        static double tinhtoan4(ref double giaGoc)
        {
            double thueVAT = giaGoc * VAT2;
            double giaSauThue = giaGoc + thueVAT;
            giaGoc = (int)giaSauThue;
            return giaSauThue;
        }
        #endregion
        static void Main(string[] args)
        {
            //Bai 1
            double donGia = nhapDonGia();
            int soLuong = nhapSoLuong();
            tangSoLuong(ref soLuong);
            double tongTien, thueVAT;
            tinhtoan(out tongTien, out thueVAT, donGia, soLuong);
            Console.WriteLine("Tong tien la: " + tongTien);
            Console.WriteLine("Thue VAT la: " + thueVAT);

            //Bai 2
            int soDien = soDienTieuTHu();
            double tongTienDien = tinhTienDien(ref soDien);
            Console.WriteLine("Luong dien tieu thu sau quy doi: " + soDien);
            Console.WriteLine("Tong tien dien phai thanh toan: " + tongTienDien);

            //Bai 3:
            Console.Write("Tong so phut lam viec la: ");
            int soPhut = Convert.ToInt32(Console.ReadLine());
            double tongTienLuong = tienLuong(ref soPhut);
            Console.WriteLine("Tong tien luong la: " + tongTienLuong);
            Console.WriteLine("So gio lam tron la: " + soPhut);

            //Bai 4
            Console.Write("Gia goc cua san pham la: ");
            double giaGoc = Convert.ToDouble(Console.ReadLine());
            double giaSauThue = tinhtoan4(ref giaGoc);
            Console.WriteLine("Gia sau thue la: " + giaSauThue);
            Console.WriteLine("Gia sau thue da lam tron la: " + giaGoc);


        }

    }
}
    
