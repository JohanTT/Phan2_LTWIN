using System;

namespace Phần_2._Cấu_trúc_điều_kiện
{
    class Program
    {
        // ______________________________BAI 12______________________________
        static void Bai12()
        {
            Console.WriteLine("Nhap a va b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = a;
            if (max > a) Console.WriteLine(max);
            max = b;
            if (max > b) Console.WriteLine(max);
            Console.WriteLine("So lon nhat la: " + max);
            Console.ReadKey();
        }

        // ______________________________BAI 13______________________________
        static void Bai13()
        {
            Console.WriteLine("Nhap a va b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max > a) Console.WriteLine(max);
            max = b;
            if (max > b) Console.WriteLine(max);
            max = c;
            if (max > c) Console.WriteLine(max);
            Console.WriteLine("So lon nhat la: " + max);
            Console.ReadKey();
        }

        // ______________________________BAI 14______________________________
        static void Bai14()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int tm = 0;
            if (a > b)
            {
                tm = a;
                a = b;
                b = tm;
            }
            if (a > c)
            {
                tm = a;
                a = c;
                c = tm;
            }
            if (b > c)
            {
                tm = b;
                b = c;
                c = tm;
            }
            Console.WriteLine(" Thu tu tang dan la: " + a + " " + b + " " + c);
            Console.ReadKey();
        }

        // ______________________________BAI 15______________________________
        static void Bai15()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A == 0)
            {
                if (B == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem: " + (-B / A));
            }

            Console.ReadKey();
        }

        // ______________________________BAI 16______________________________
        static void Bai16()
        {
            float a, b, c;
            Console.WriteLine("Nhap a : ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b : ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c : ");
            c = float.Parse(Console.ReadLine());
            float delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep ");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            Console.ReadKey();
        }

        // ______________________________BAI 17______________________________
        static void Bai17()
        {
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            int c = int.Parse(Console.ReadLine());
            double denta = b * b - 4 * a * c;
            if (a == 0 && b != 0 && c != 0)
            {
                double A1 = Math.Sqrt(-c / b);
                double A2 = -Math.Sqrt(-c / b);
                if ((-c / b) > 0)
                    Console.WriteLine("Phuong trinh co 2 nghiem {0}", A1, A2);
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            if (a == 0 && b == 0 && c != 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            if (a == 0 && b == 0 && c == 0)
                Console.WriteLine("Phuong trinh vo so nghiem");
            if (a != 0 && b == 0 && c == 0 || a == 0 && b != 0 && c == 0)
                Console.WriteLine("Phuong trinh co 1 nghiem =0");
            if (a != 0 && b != 0 || a != 0 && c != 0)
            {
                if (denta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                if (denta == 0)
                {
                    double t = -b / (2 * a);
                    double X1 = Math.Sqrt(t);
                    double X2 = -Math.Sqrt(t);
                    if (t < 0)
                        Console.WriteLine("Phuong trinh vo nghiem");
                    else if (t >= 0)
                        if (t == 0)
                            Console.WriteLine("Phuong trinh 1 co nghiem = 0");
                        else
                            Console.WriteLine("Phuong trinh co 2 nghiem {0} {1}", X1, X2);
                }
                if (denta > 0)
                {
                    double t1 = ((-b + Math.Sqrt(denta)) / (2 * a));
                    double t2 = ((-b - Math.Sqrt(denta)) / (2 * a));
                    double x1 = Math.Sqrt(t1);
                    double x2 = -Math.Sqrt(t1);
                    double x3 = Math.Sqrt(t2);
                    double x4 = -Math.Sqrt(t2);
                    if (t1 < 0 && t2 < 0)
                        Console.WriteLine("Phuong trinh vo nghiem");
                    if (t1 == 0 && t2 < 0 || t2 == 0 && t1 < 0)
                        Console.WriteLine("Phuong trinh 1 co nghiem = 0");
                    if (t2 == 0 && t1 > 0)
                        Console.WriteLine("Phuong trinh co 3 nghiem = 0, {0}, {1}", x1, x2);
                    if (t1 == 0 && t2 > 0)
                        Console.WriteLine("Phuong trinh co 3 nghiem = 0, {0}, {1}", x3, x4);
                    if (t1 > 0 && t2 < 0)
                        Console.WriteLine("Phuong trinh co 2 nghiem = {0}, {1}", x1, x2);
                    if (t1 < 0 && t2 > 0)
                        Console.WriteLine("Phuong trinh co 2 nghiem = {0}, {1}", x3, x4);
                    if (t1 > 0 && t2 > 0)
                        Console.WriteLine("Phuong trinh co 4 nghiem = {0}, {1}, {2}, {3}", x1,
                       x2, x3, x4);
                }
            }
            Console.ReadLine();

            Console.ReadKey();
        }

        // ______________________________BAI 18______________________________
        static void Bai18()
        {
            Console.WriteLine("Nhap so nguyen n gom 3 chu so: ");
            int n = int.Parse(Console.ReadLine());
            int tram = n / 100;
            int chuc = ((n % 100) / 10);
            int donvi = (n % 10);
            int max = tram;
            if (tram > chuc)
            {
                if (tram > donvi)
                {
                    Console.WriteLine("Chu so lon nhat nam o hang tram. ");
                }
                else
                {
                    Console.WriteLine("Chu so lon nhat nam o hang don vi. ");
                }
            }
            else if (chuc > donvi)
                Console.WriteLine("Chu so lon nhat nam o hang chuc. ");
            else
                Console.WriteLine("Chu so lon nhat nam o hang don vi. ");
            Console.ReadKey();
        }

        // ______________________________BAI 19______________________________
        static void Bai19()
        {
            Console.WriteLine("Nhap so nguyen n gom 3 chu so: ");
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = ((n % 100) / 10);
            int c = (n % 10);
            if (a > b)
            {
                int doi = a;
                a = b;
                b = doi;
            }
            if (b > c)
            {
                int doi = b;
                b = c;
                c = doi;
            }
            if (a > b)
            {
                int doi = a;
                a = b;
                b = doi;
            }
            Console.WriteLine("Thu tu tang dan cua cac chu so {0}, {1}, {2}", a, b, c);

            Console.ReadKey();
        }

        // ______________________________BAI 20______________________________
        static void Bai20()
        {

        }

        // ______________________________BAI 21______________________________
        static void Bai21()
        {

        }

        // ______________________________BAI 22______________________________
        static void Bai22()
        {

        }

        // ______________________________BAI 23______________________________
        static void Bai23()
        {

        }
        static void Main(string[] args)
        {
            //Bai12();

            //Bai13();

            //Bai14();

            //Bai15();

            //Bai16();

            //Bai17();

            //Bai18();

            //Bai19();

            //Bai20();

            //Bai21();

            //Bai22();

            //Bai23();
        }
    }
}
