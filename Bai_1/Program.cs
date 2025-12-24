using System;
class Program
{
    static void Main()
    {
        // Bài 1: Viết chương trình in ra các kiểu dữ liệu cơ bản
        char alias = 'Q';
        byte data = 1;
        short age = 22;
        int salary = 25000000;
        long income = 1000000000;
        long account = -1000000;
        float f = 2243.2342f;
        double phone = 124219491;
        string name = "Quy";
        decimal dec = 2.234234m;
        Console.WriteLine(" biet danh :" + alias);
        Console.WriteLine(" tao la :" + name);
        Console.WriteLine(" luong: " + salary);
        Console.WriteLine(" thu nhap :" + income);
        Console.WriteLine(" so du tai khoan" + account);
        Console.WriteLine(" so dien thoai" + phone);
        Console.WriteLine(" so thap phan" + dec);
        unsafe
        {
            int n = 100;
            int* p = &n;
            *p = 500;
            Console.WriteLine(" gia tri cua n: {0}", n);
            Console.WriteLine(" dia chi o nho cua n: {0}", (int)p);

        }
        // Bài 2: thử nghiệm over flow
        short q = 32766;
        Console.WriteLine(q);
        q++;
        Console.WriteLine(q);
        q++;
        Console.WriteLine(q); // quay vòng về -32768
        q++;
        Console.WriteLine(q);

        // Bài 3: Tính toán tiền lãi tiết kiệm
        Console.Write(" ky han: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Lai suat:");
        decimal laiSuat = Convert.ToDecimal(Console.ReadLine());
        Console.Write(" So tien gui: ");
        decimal soTienGui = Convert.ToDecimal(Console.ReadLine());
        decimal tongSoTien = (year * laiSuat * soTienGui / 100) + soTienGui;
        Console.WriteLine(" So tien sau tiet kiem: " + tongSoTien);

        //Bài 4: Boxing và unboxing với object
        // boxing
        short value = 10;
        object obj;
        obj = value;
        Console.WriteLine(obj);
        //unboxing
        object c = 20;
        int d = (int)c;
        Console.WriteLine(d);

    }
}