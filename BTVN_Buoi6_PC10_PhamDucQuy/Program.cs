using System.Reflection.Metadata.Ecma335;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========PC CONTROL QUAN LY DANH SACH THIET BI=======");
            Console.WriteLine("1. Them thiet bi");
            Console.WriteLine("2. Xoa thiet bi");
            Console.WriteLine("3. Hien thi danh sach thiet bi");
            Console.WriteLine("4. Xu ly thiet bi");
            Console.WriteLine("0. Thoat chuong trinh");
            List<string> devices = new List<string>();
            while (true)
            {
                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    Console.WriteLine("Da thoat chuong trinh");
                    break;
                }
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Hay nhap thiet bi");
                        ThemThietBi(devices);
                        break;
                    case "2":
                        // Xoa thiet bi
                        Console.WriteLine("Hay nhap thiet bi can xoa: ");
                        XoaThietBi(devices);
                        break;
                    case "3": //Hien thi danh sach thiet bi
                        Console.WriteLine("Danh sach thiet bi sau khi update: ");
                        DanhSach(devices);
                        break;
                    case "4":
                        //Xu ly thiet bi
                        Console.WriteLine("Dang xu ly: ");
                        XuLyThietBi(devices);

                        break;
                    default:
                        Console.WriteLine("Khong hop le, Hay nhap lai");
                        break;
                }
            }
        }
        static void ThemThietBi(List<string> devices)
        {
            while (true)
            {
                string nameDevice = Console.ReadLine();
                if (string.IsNullOrEmpty(nameDevice)) break;
                if (devices.Contains(nameDevice)) break;
                if (!nameDevice.Contains("PLC") && !nameDevice.Contains("SENSOR") && !nameDevice.Contains("CAM")) break;
                devices.Add(nameDevice);
            }
            Console.Write("Danh sach thiet bi sau khi them la: ");
            foreach (string device in devices) { Console.Write(device + " "); }
        }
        static void XoaThietBi(List<string> devices)
        {
            string deleteDevice = Console.ReadLine();
            if (deleteDevice.Contains("PLC")) return;
            if (!devices.Contains(deleteDevice)) return;
            devices.Remove(deleteDevice);
        }
        static void DanhSach(List<string> devices)
        {
            foreach (var device in devices) { Console.Write(device + " "); }
            Console.WriteLine();
        }
        static void XuLyThietBi(List<string> devices)
        {
            Console.Write("Co thiet bi stop");
            foreach (var device in devices)
            {
                if (device.Contains("ERROR")) continue;
                if (device.Contains("STOP")) break;
                Console.WriteLine(device + " ");
            }
        }
    }
}
