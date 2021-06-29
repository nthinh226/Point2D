using System;
using System.Collections.Generic;
using System.Text;
namespace Point2D_OnTap_LTNC_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Point2D p = new Point2D();
            p.nhapDiem();
            Console.WriteLine();
            p.checkOxOy(p);
            Console.WriteLine();
            //p.thayDoiViTri(1, 1);
            //p.xuatDiem(); 

            Console.WriteLine($"**Khoảng cách với gốc toạ độ O(0,0): {p.tinhKhoangCach()}");
            Point2D A = new Point2D(1, 2);
            Console.WriteLine($"**Khoảng cách với điểm A(1,2): {p.tinhKhoangCach(A)}");

            Console.WriteLine("**Tìm điểm đối xứng của điểm hiện hành qua trục Ox: ");
            p.diemDoiXungOx().xuatDiem();
            Console.WriteLine();

            Console.WriteLine("**Điểm đối xứng của điểm hiện hành qua trục Oy: ");
            p.diemDoiXungOy().xuatDiem();
            Console.WriteLine();

            Console.WriteLine("**Kiểm tra đoạn thẳng 2 toạ độ có song song Ox?");
            p.checkSongSongOx(p, A);

            Console.WriteLine("**Kiểm tra đoạn thẳng 2 toạ độ có song song Oy?");
            p.checkSongSongOy(p, A);

            Console.WriteLine("**Kiểm tra đoạn thẳng 2 toạ độ có đi qua gốc toạ độ O?");
            p.checkQuaGocO(p, A);

        }
    }
}
