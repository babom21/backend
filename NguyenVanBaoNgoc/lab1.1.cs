using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Nhap ten va tuoi");
            Console.WriteLine("2. Tinh dien tich hinh chu nhat");
            Console.WriteLine("3. Chuyen doi nhiet do C sang F");
            Console.WriteLine("4. Kiem tra so chan");
            Console.WriteLine("5. Tinh tong va tich 2 so");
            Console.WriteLine("6. Kiem tra so am/duong/0");
            Console.WriteLine("7. Kiem tra nam nhuan");
            Console.WriteLine("8. In bang cuu chuong tu 1 den 10");
            Console.WriteLine("9. Tinh giai thua");
            Console.WriteLine("10. Kiem tra so nguyen to");
            Console.WriteLine("0. Thoat");
            choice = NhapSoNguyen("Chon bai (0-10): ");

            Console.WriteLine();

            switch (choice)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 0: Console.WriteLine("Tam biet!"); break;
                default: Console.WriteLine("Lua chon khong hop le."); break;
            }

        } while (choice != 0);
    }

    static int NhapSoNguyen(string thongBao)
    {
        int so;
        string? input;
        do
        {
            Console.Write(thongBao);
            input = Console.ReadLine();
        } while (!int.TryParse(input, out so));
        return so;
    }

    static double NhapSoThuc(string thongBao)
    {
        double so;
        string? input;
        do
        {
            Console.Write(thongBao);
            input = Console.ReadLine();
        } while (!double.TryParse(input, out so));
        return so;
    }

    static void Bai1()
    {
        Console.Write("Nhap ten: ");
        string? name = Console.ReadLine();
        int age = NhapSoNguyen("Nhap tuoi: ");
        Console.WriteLine($"Xin chao {name}, ban {age} tuoi!");
    }

    static void Bai2()
    {
        double dai = NhapSoThuc("Nhap chieu dai: ");
        double rong = NhapSoThuc("Nhap chieu rong: ");
        Console.WriteLine($"Dien tich hinh chu nhat: {dai * rong}");
    }

    static void Bai3()
    {
        double c = NhapSoThuc("Nhap nhiet do C: ");
        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"Nhiet do F: {f}");
    }

    static void Bai4()
    {
        int n = NhapSoNguyen("Nhap so nguyen: ");
        Console.WriteLine(n % 2 == 0 ? "So chan" : "So le");
    }

    static void Bai5()
    {
        int a = NhapSoNguyen("Nhap so thu nhat: ");
        int b = NhapSoNguyen("Nhap so thu hai: ");
        Console.WriteLine($"Tong: {a + b}, Tich: {a * b}");
    }

    static void Bai6()
    {
        int x = NhapSoNguyen("Nhap mot so: ");
        if (x > 0) Console.WriteLine("So duong");
        else if (x < 0) Console.WriteLine("So am");
        else Console.WriteLine("So 0");
    }

    static void Bai7()
    {
        int year = NhapSoNguyen("Nhap nam: ");
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine(isLeap ? "Nam nhuan" : "Khong phai nam nhuan");
    }

    static void Bai8()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Bang cuu chuong cua {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }

    static void Bai9()
    {
        int num = NhapSoNguyen("Nhap mot so nguyen duong: ");
        int giaiThua = 1;
        for (int i = 1; i <= num; i++)
        {
            giaiThua *= i;
        }
        Console.WriteLine($"Giai thua cua {num} la: {giaiThua}");
    }

    static void Bai10()
    {
        int number = NhapSoNguyen("Nhap mot so: ");
        bool isPrime = number > 1 && Enumerable.Range(2, (int)Math.Sqrt(number)).All(i => number % i != 0);
        Console.WriteLine(isPrime ? "La so nguyen to" : "Khong phai so nguyen to");
    }
}
