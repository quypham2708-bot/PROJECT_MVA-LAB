using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.IO;
using System.Drawing;
class program
{
    static void Main()
    {
        ////Bài 1
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //string logFile = "D:\\PROJECT\\PROJECT\\Buổi 7_File in C#\\LogFile.txt";
        //if (!File.Exists(logFile))
        //{
        //    Console.WriteLine("Không tồn tại file");
        //    return;
        //}
        //Random giaTriCamBien = new Random();
        //Console.WriteLine("Bắt đầu ghi giá trị cảm biến");
        //while (true)
        //{
        //    int sensor = giaTriCamBien.Next(50, 100);
        //    string time = DateTime.Now.ToString();
        //    string log = $"Tại thời điểm: {time} có giá trị: {sensor}...\r\n";
        //    File.AppendAllText(logFile, log);
        //    Thread.Sleep(5000);
        //}

        //Bài 2
        //ExcelPackage.License.SetNonCommercialPersonal("DucQuy");
        //string excelPath = "D:\\PROJECT\\PROJECT\\Buổi 7_File in C#\\LichBaoTri.xlsx";

        //if (!File.Exists(excelPath))
        //{
        //    Console.WriteLine("Không tồn tại file LichBaoTri");
        //    return;
        //}
        //using (ExcelPackage package = new ExcelPackage(new FileInfo(excelPath)))
        //{
        //    ExcelWorksheet ws = package.Workbook.Worksheets[0];
        //    int maxRow = ws.Dimension.End.Row;
        //    int maxCol = ws.Dimension.End.Column;
        //    DateTime ngayDenHan;
        //    Console.Write("Thiết bị đã quá hạn bảo trì: ");
        //    for (int i = 2; i <= maxRow; i++)
        //    {
        //        DateTime ngayGanNhat = DateTime.Parse(ws.Cells[i, 2].Text);
        //        double chuKy = (double)ws.Cells[i, 3].Value;
        //        ngayDenHan = ngayGanNhat.AddDays(chuKy);
        //        if (ngayDenHan < DateTime.Today)
        //        {
        //            Console.Write(ws.Cells[i, 1].Text + " ");
        //            ws.Cells[i, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
        //            ws.Cells[i, 1].Style.Fill.BackgroundColor.SetColor(Color.YellowGreen);
        //        }
        //    }
        //    Console.WriteLine();
        //    string output = "D:\\PROJECT\\PROJECT\\Buổi 7_File in C#\\ThietBiCanBaoTri.xlsx";
        //    package.SaveAs(new FileInfo(output));

        //}

        //Bài 3
        string sanLuong = "D:\\PROJECT\\PROJECT\\Buổi 7_File in C#\\SanLuongT9,10.xlsx";
        if (!File.Exists(sanLuong))
        {
            Console.WriteLine("Không tìm thấy file sản lượng");
            return;
        }
        using (ExcelPackage package2 = new ExcelPackage( new FileInfo(sanLuong)))
        {
            ExcelWorksheet ws1 = package2.Workbook.Worksheets["SanLuongT9"];
            ExcelWorksheet ws2 = package2.Workbook.Worksheets["SanLuongT10"];
            int maxRow1 = ws1.Dimension.End.Row;
            int maxCol1 = ws1.Dimension.End.Column;
            int maxRow2 = ws2.Dimension.End.Row;
            int maxCol2 = ws2.Dimension.End.Column;
        }    

    }
}