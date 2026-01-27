using System;
using System.IO;
using System.Drawing;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks.Sources;
using OfficeOpenXml.DataValidation;
namespace BTVN_TongHop_PC10_PhamDucQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ExcelPackage.License.SetNonCommercialPersonal("DucQuy");
            List<string> maHocSinh = new List<string>();
            List<string> tenHocSinh = new List<string>();
            List<double> diemToan = new List<double>();
            List<double> diemVan = new List<double>();
            List<double> diemAnh = new List<double>();
            List<double> diemTB = new List<double>();
            List<string> xepLoai = new List<string>();
            try
            {                
                string input = "D:\\PROJECT\\PROJECT\\BTVN_TongHop_PC10_PhamDucQuy\\dữ liệu input.xlsx";
                if (!File.Exists(input))
                {
                    throw new FileNotFoundException("Không tìm thấy file: " + input);
                }                
                using (ExcelPackage package = new ExcelPackage(new FileInfo(input)))
                {
                    ExcelWorksheet ws = package.Workbook.Worksheets[0];
                    int maxRow = ws.Dimension.End.Row;
                    int maxCol = ws.Dimension.End.Column;
                    for ( int i = 2; i <= maxRow; i++ )
                    {
                        maHocSinh.Add(ws.Cells[i, 1].Text);
                        tenHocSinh.Add(ws.Cells[i,2].Text);
                        double toan, van, anh;
                        try { toan = Convert.ToDouble(ws.Cells[i, 3].Value); } catch { toan = 0; }
                        try { van = Convert.ToDouble(ws.Cells[i, 4].Value); } catch {  van = 0; }
                        try { anh = Convert.ToDouble(ws.Cells[i, 5].Value); } catch { anh = 0; }
                        diemToan.Add(Math.Round(toan, 2));
                        diemVan.Add(Math.Round(van, 2));
                        diemAnh.Add(Math.Round(anh, 2));
                    }
                    
                    for ( int i = 0; i<maHocSinh.Count;i++ )
                    {
                        double tb = (diemToan[i] + diemVan[i] + diemAnh[i]) / 3;
                        diemTB.Add(Math.Round(tb,2));
                        string s=null;
                        switch (tb)
                        {
                            case 10:
                                s = "Xuất sắc";
                                break;
                            default:
                                if (tb >= 8) s = "Giỏi";
                                if (tb < 8 && tb >= 6) s = "Khá";
                                if (tb < 6 && tb >= 4) s = "Trung Bình";
                                if (tb < 4) s = "yếu";
                                break;
                        }
                        xepLoai.Add(s);
                        Console.WriteLine($"Mã Học Sinh: {maHocSinh[i]} - {tenHocSinh[i]}: {diemTB[i]} ; xếp loại {xepLoai[i]}");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khác: " + ex.Message);
            }
            try
            {
                using (ExcelPackage package1 = new ExcelPackage())
                {
                    ExcelWorksheet ws = package1.Workbook.Worksheets.Add("KetQua");
                    ws.Cells[1, 1].Value = "Mã Học Sinh";
                    ws.Cells[1, 2].Value = "Tên Học Sinh";
                    ws.Cells[1, 3].Value = "Điểm trung bình";
                    ws.Cells[1, 4].Value = "Xếp loại";
                    for (int i = 0; i < maHocSinh.Count; i++)
                    {
                        ws.Cells[i + 2, 1].Value = maHocSinh[i];
                        ws.Cells[i + 2, 2].Value = tenHocSinh[i];
                        ws.Cells[i + 2, 3].Value = diemTB[i];
                        ws.Cells[i + 2, 4].Value = xepLoai[i];
                    }
                    ws.Cells[1, 1, maHocSinh.Count + 1, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells[1, 1, 1, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[1, 1, 1, 4].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    ws.Cells[1, 1, 1, 4].Style.Font.Bold = true;
                    ws.Cells[1, 1, maHocSinh.Count + 1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[1, 1, maHocSinh.Count + 1, 1].Style.Fill.BackgroundColor.SetColor(Color.Gray);

                    string path = "D:\\PROJECT\\PROJECT\\BTVN_TongHop_PC10_PhamDucQuy\\output.xlsx";
                    FileInfo output = new FileInfo(path);
                    package1.SaveAs(output);
                    Console.WriteLine("\nTạo file tổng hợp thành công");
                }
            }
            catch(Exception ex) { Console.WriteLine("Lỗi tạo file: " + ex.Message);
                throw;
            }

            
        }
    }
}
