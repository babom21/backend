using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== MENU BAI MANG =====");
            Console.WriteLine("1. Tinh tong cac so chan trong mang");
            Console.WriteLine("2. Kiem tra va hien thi cac so nguyen to trong mang");
            Console.WriteLine("3. Dem so am va so duong trong mang");
            Console.WriteLine("4. Tim so lon thu hai trong mang");
            Console.WriteLine("5. Hoan vi 2 so nguyen a va b");
            Console.WriteLine("6. Sap xep mang theo chieu tang dan");
            Console.WriteLine("0. Thoat");
            choice = NhapSoNguyen("Chon bai (0-6): ");

            Console.WriteLine();

            switch (choice)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
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

    static int[] NhapMangNguyen(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = NhapSoNguyen($"Phan tu [{i}]: ");
        }
        return arr;
    }

    static void Bai1()
    {
        int n = NhapSoNguyen("Nhap so phan tu cua mang: ");
        int[] arr = NhapMangNguyen(n);
        int tongChan = arr.Where(x => x % 2 == 0).Sum();
        Console.WriteLine($"Tong cac so chan trong mang: {tongChan}");
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Bai2()
    {
        int n = NhapSoNguyen("Nhap so phan tu cua mang: ");
        int[] arr = NhapMangNguyen(n);
        Console.WriteLine("Cac so nguyen to trong mang:");
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(arr[i]))
            {
                Console.WriteLine($"Chi so {i}, gia tri {arr[i]}");
            }
        }
    }

    static void Bai3()
    {
        int n = NhapSoNguyen("Nhap so phan tu cua mang: ");
        int[] arr = NhapMangNguyen(n);
        int soAm = arr.Count(x => x < 0);
        int soDuong = arr.Count(x => x > 0);
        Console.WriteLine($"So luong am: {soAm}, so luong duong: {soDuong}");
    }

    static void Bai4()
    {
        int n = NhapSoNguyen("Nhap so phan tu cua mang: ");
        int[] arr = NhapMangNguyen(n);
        int max = arr.Max();
        int secondMax = int.MinValue;
        foreach (int x in arr)
        {
            if (x != max && x > secondMax)
                secondMax = x;
        }
        if (secondMax == int.MinValue)
            Console.WriteLine("Khong tim thay so lon thu hai.");
        else
            Console.WriteLine($"So lon thu hai la: {secondMax}");
    }

    static void Bai5()
    {
        int a = NhapSoNguyen("Nhap so a: ");
        int b = NhapSoNguyen("Nhap so b: ");
        Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
    }

    static void Bai6()
    {
        int n = NhapSoNguyen("Nhap so phan tu cua mang: ");
        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu [{i}]: ");
            while (!double.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.Write("Nhap lai: ");
            }
        }
        Array.Sort(arr);
        Console.WriteLine("Mang sau khi sap xep tang dan:");
        foreach (var x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }
}
