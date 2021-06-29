using System;
using System.Collections.Generic;
using System.Text;

namespace Point2D_OnTap_LTNC_6
{
    class Point2D
    {
        private int x, y;
        public Point2D()
        {
            x = y = 0;
        }
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
        ~Point2D() { }
        public void nhapDiem()
        {
            Console.WriteLine("**Nhập toạ độ x, y");
            Console.Write("Nhập x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            y = int.Parse(Console.ReadLine());
        }
        public void xuatDiem()
        {
            Console.Write($"({x},{y})");
        }
        public void checkOxOy(Point2D t)
        {
            if (t.x == 0)
            {
                Console.Write("Điểm ");
                t.xuatDiem();
                Console.Write(" nằm trên trục Oy");
            }
            else if (t.y == 0)
            {
                Console.Write("Điểm ");
                t.xuatDiem();
                Console.Write(" nằm trên trục Ox");
            }
            else
            {
                Console.Write("Điểm ");
                t.xuatDiem();
                Console.Write(" không thuộc trục Ox, Oy");
            }
        }
        public void thayDoiViTri(int tx, int ty)
        {
            x = x + tx;
            y = y + ty;
        }
        public void thayDoiViTri(Point2D A)
        {
            this.x = A.x;
            this.y = A.y;
        }
        public double tinhKhoangCach()
        {
            return Math.Round(Convert.ToDouble(Math.Sqrt(x * x + y * y)),2);
        }
        public double tinhKhoangCach (Point2D A)
        {
            return Math.Round(Convert.ToDouble(Math.Sqrt(Math.Pow(this.x - A.x, 2) + Math.Pow(this.y - A.y,2))));
        }
        public Point2D diemDoiXungOx()
        {
            Point2D t = new Point2D();
            t.x = this.x;
            t.y = -this.y;
            return t;
        }
        public Point2D diemDoiXungOy()
        {
            Point2D t = new Point2D();
            t.x = -this.x;
            t.y = this.y;
            return t;
        }
        public Point2D diemDoiXungO(Point2D t)
        {
            Point2D dx = new Point2D();
            dx.x = -t.x;
            dx.y = -t.y;
            return dx;
        }
        public void checkSongSongOx(Point2D t1, Point2D t2)
        {
            Console.WriteLine((t1.y == t2.y) ? "Đoạn thẳng song song với Ox" : "Đoạn thẳng không song song với Ox");
        }
        public void checkSongSongOy(Point2D t1, Point2D t2)
        {
            Console.WriteLine((t1.x == t2.x) ? "Đoạn thẳng song song với Oy" : "Đoạn thẳng không song song với Oy");
        }
        public void checkQuaGocO(Point2D t1, Point2D t2)
        {
            Point2D temp = new Point2D();
            temp = diemDoiXungO(t2);
            Console.WriteLine((t1.x == temp.x && t1.y==temp.y) ? "Đoạn thẳng đi qua tâm O" : "Đoạn thẳng không đi qua tâm O");
        }
    }
}
