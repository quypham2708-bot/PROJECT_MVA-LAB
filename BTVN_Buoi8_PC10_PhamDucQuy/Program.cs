namespace BTVN_Buoi8_PC10_PhamDucQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            //List<string> nhapLenh = new List<string>();
            //Stack<string> unDo = new Stack<string>();
            //Stack<string> reDo = new Stack<string>();
            //while (true)
            //{
            //    string lenh = Console.ReadLine();
            //    if (string.IsNullOrEmpty(lenh)) break;
            //    nhapLenh.Add(lenh);
            //    unDo.Push(lenh);
            //}
            //while (true)
            //{
            //    Console.WriteLine("redo or undo");
            //    string input = Console.ReadLine();
            //    if (string.IsNullOrEmpty(input)) break;
            //    switch (input)
            //    {

            //        case "undo":
            //            string cmd = unDo.Pop();
            //            Console.WriteLine("Lenh vua undo la: " + cmd);
            //            reDo.Push(cmd);
            //            break;
            //        case "redo":
            //            string cmd2 = reDo.Pop();
            //            Console.WriteLine("Lenh vua redo la: " + cmd2);
            //            unDo.Push(cmd2);
            //            break;
            //    }
            //}

            //Bài 2
            //string bieuThuc = Console.ReadLine();
            //Stack<char> kyTu = new Stack<char>();
            //bool hopLe = true;
            //for (int i = 0; i < bieuThuc.Length; i++) 
            //{
            //    if (bieuThuc[i] == '(')
            //    {
            //        kyTu.Push(bieuThuc[i]);
            //    }
            //    if (bieuThuc [i] == ')')
            //    {
            //        if (kyTu.Count == 0)
            //        {
            //            hopLe = false;
            //            break;
            //        }
            //        kyTu.Pop(); 
            //    }
            //}
            //if ( kyTu.Count > 0)
            //{
            //    hopLe = false;
            //}
            //if (hopLe)
            //{
            //    Console.WriteLine("Bieu thuc hop le");
            //}
            //else { Console.WriteLine("Bieu thuc KHONG hop le"); }

            //Bài 3
            //Queue<string> queue = new Queue<string>();
            //while (true)
            //{
            //    string product = Console.ReadLine();
            //    if (string.IsNullOrEmpty(product)) break;
            //    queue.Enqueue(product);
            //}
            //Console.WriteLine("Danh sach san pham dang duoc xu ly: ");
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Bài 4: palindrome
            Console.Write("Nhap ky tu: ");
            string palindrome = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < palindrome.Length; i++)
            {
                stack.Push(palindrome[i]);
                queue.Enqueue(palindrome[i]);
            }
            List<char> chuoiXuoi = new List<char>();
            List<char> chuoiNguoc = new List<char>();
            while (queue.Count > 0)
            {
                chuoiXuoi.Add(queue.Dequeue());
                chuoiNguoc.Add(stack.Pop());
            }
            bool kiemTra = false;
            for (int i = 0; i < chuoiXuoi.Count; i++)
            {
                if (chuoiXuoi[i] == chuoiNguoc[i]) 
                kiemTra = true;
                break;
            }
            if (kiemTra) { Console.WriteLine("Chuoi la palindrome"); }
            else { Console.WriteLine("Chuoi KHONG phai palindrome"); }
        }
     
    }
}
