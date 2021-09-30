using System;

namespace Phần_2._Cấu_trúc_lặp
{
    class Program
    {
        // ______________________________BAI 24______________________________
        static void Bai24()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                Console.WriteLine("n la so nguyen to");
            }
            else
            {
                Console.WriteLine("n ko là so nguyen to");
            }
            Console.ReadKey();
        }

        // ______________________________BAI 25______________________________
        static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        static int BCNN(int a, int b)
        {
            return a * b / UCLN(a, b);
        }
        static void Bai25()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("UCLN cua 2 so la " + UCLN(a, b));
            Console.WriteLine("BCNN cua 2 so la " + BCNN(a, b));
            Console.ReadKey();
        }

        // ______________________________BAI 26______________________________
        static void Bai26()
        {
            Console.Write("Nhap vao 1 so nguyen duong N: ");
            int N = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                    dem++;
            }
            Console.WriteLine("Dem so uoc: " + dem);
            Console.ReadKey();
        }

        // ______________________________BAI 27______________________________
        static int SOHOANHAO(int n)
        {
            int flag = 0, sum = 0;

            //Tìm tổng ước số   
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) sum += i;

            }
            Console.Write("Tong cua cac uoc so: {0}", sum);
            //So sánh tổng ước số với số đã cho để tìm ra số hoàn hảo
            if (sum == n & n != 0) flag = 1;
            return flag;
        }

        static void Bai27()
        {
            int n = int.Parse(Console.ReadLine());
            int check = SOHOANHAO(n);
            if (check == 1) Console.WriteLine("la so hoan thien");
            else Console.WriteLine("khong la so hoan thien");
            Console.ReadKey();
        }

        // ______________________________BAI 28______________________________
        static void Bai28()
        {
            int n = int.Parse(Console.ReadLine());
            int gt = 1;

            int i = 0;

            for (i = 1; i <= n; ++i)
                gt = gt * i;
            Console.WriteLine("n!= " + gt);
            Console.ReadKey();
        }

        // ______________________________BAI 29______________________________
        static int TinhTich(int n)
        {
            int p = 1;
            for (int i = 0; i <= n; i++)
                p = p * (2 * i + 1);
            return p;
        }

        static void Bai29()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0)
                Console.WriteLine("Ket qua: " + TinhTich(n));
            else Console.WriteLine("SAI NHAP LAI");
            Console.ReadKey();
        }

        // ______________________________BAI 30______________________________
        static int TinhTong(int n)
        {
            int tong = 0;
            for (int i = 0; i <= n; i++)
                tong = tong + (2 * i + 1);
            return tong;
        }
        static void Bai30()
        {        
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0)
                Console.WriteLine("Ket qua: " + TinhTong(n));
            else
                Console.WriteLine("SAI NHAP LAI");
            Console.ReadKey();
        }

        // ______________________________BAI 31______________________________
        static long TinhCongTru(int n)
        {
            long p = 0;
            long tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                p += tmp * i;
                tmp *= -1;
            }
            return p;
        }

        static void Bai31()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("Ket qua: " + TinhCongTru(n));
            else
                Console.WriteLine("SAI NHAP LAI");
            Console.ReadKey();

        }

        // ______________________________BAI 32______________________________
        static int TinhCongNhan(int n)
        {

            int tong = 0, tich = 1;
            for (int i = 1; i <= n; i++)
            {
                tich = tich * i;
                tong = tong + tich;
            }
            return tong;
        }

        static void Bai32()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("Ket qua: " + TinhCongNhan(n));
            else Console.WriteLine("SAI NHAP LAI");
            Console.ReadKey();
        }

        // ______________________________BAI 33______________________________
        static void Bai33()
        {
            long S = 0;
            Console.WriteLine("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                S = S + i * i;
            }
            Console.WriteLine("Tong 1^2 + 2^2 + ... + n^2 la: {0}", S);
            Console.ReadKey();
        }

        // ______________________________BAI 34______________________________
        static void Bai34()
        {
            Console.WriteLine("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            float S = 0;
            while (n <= 0) ;
            for (int i = 1; i <= n; i++)
            {
                S += 1 / (float)i;
            }
            Console.WriteLine("Tong 1 + 1/2 + 1/3 + ... + 1/n la: {0}", S);
            Console.ReadKey();
        }

        // ______________________________BAI 35______________________________
        static void Bai35()
        {
            Console.WriteLine("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            float S = 0;
            for (int i = 1; i <= n; i++)
            {
                S = S + i * i;
            }
            Console.WriteLine("Tong 1 + 2^2 + 3^2 + ... + n^2 la: {0}", S);
            Console.ReadKey();
        }

        // ______________________________BAI 36______________________________
        static void Bai36()
        {
            Console.WriteLine("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            float S = 0;
            for (int i = 1; i <= n; i++) // với i = 1, S = 0;
            {
                S = S + (float)i / (i + 1);
            }
            Console.WriteLine("Tong 1/2 + 2/3 + 3/4 + n/(n+1) la: {0}", S);
            Console.ReadKey();
        }

        // ______________________________BAI 37______________________________
        //tao ham mu tu dinh nghia
        public static double Tinh(int n)
        {
            double s = 0;
            long p = 1;
            for (int i = 1; i <= n; i++)
            {
                p = p * i;
                s = s + (double)1 / p;
            }
            return s;
        }
        static void Bai37()
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong 1 + 1/2! + 1/3! + ... + 1/n! la: {0}", Tinh(n));
            Console.ReadKey();
        }

        // ______________________________BAI 40______________________________
        //tao ham mu tu dinh nghia
        public static int HamPow(int num, int exp)
        {
            int ket_qua = 1;
            int i;
            for (i = 1; i <= exp; i++)
                ket_qua = ket_qua * num;
            return ket_qua;
        }
        
        static void Bai40()
        {
            int x;
            int y;
            Console.Write("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gia tri cua {0} ^ {1} = {2} ", x, y, HamPow(x, y));

            Console.ReadKey();
        }
        
        // ______________________________BAI 41______________________________
        public static double Tinh(int n)
        {
            int s = 0, t = 0;
            for (int i = 1; i <= n; i++)
            {
                t = t + i;
                s = s + t;
            }
            return s;
        }
        
        static void Bai41()
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong 1 + (1 + 2) + (1 + 2 + 3) + ... + (1 + 2 + 3 + ... + n) la: {0}", Tinh(n));
        }
        
        static void Main(string[] args)
        {
            Bai24();

            Bai25();

            Bai26();

            Bai27();

            Bai28();

            Bai29();

            Bai30();

            Bai31();

            Bai32();

            Bai33();

            Bai33();

            Bai34();

            Bai35();

            Bai36();

            Bai37();
            
            Bai40();
            
            Bai41();
            
            Bai42();

        }
    }
}
