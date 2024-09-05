using System;
using System.Linq;

namespace myproject
{
     class BaiTap
     {
          // Bài 1: Tạo mảng số nguyên và tính tổng
          public void TinhTongMang()
          {
               Console.Write("Nhập số lượng phần tử của mảng: ");
               int n = int.Parse(Console.ReadLine());
               int[] mang = new int[n];
               int tong = 0;

               for (int i = 0; i < n; i++)
               {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    mang[i] = int.Parse(Console.ReadLine());
                    tong += mang[i];
               }

               Console.WriteLine("Tổng các phần tử trong mảng là: " + tong);
          }

          // Bài 2: Đếm số lượng ký tự trong chuỗi
          public void DemKyTuChuoi()
          {
               Console.Write("Nhập chuỗi: ");
               string chuoi = Console.ReadLine();
               int dem = 0;

               foreach (char c in chuoi)
               {
                    if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
                    {
                         dem++;
                    }
               }

               Console.WriteLine("Số lượng ký tự không tính khoảng trắng và dấu câu là: " + dem);
          }

          // Bài 3: Tìm phần tử lớn nhất trong mảng
          public void TimPhanTuLonNhat()
          {
               Console.Write("Nhập số lượng phần tử của mảng: ");
               int n = int.Parse(Console.ReadLine());
               int[] mang = new int[n];

               for (int i = 0; i < n; i++)
               {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    mang[i] = int.Parse(Console.ReadLine());
               }

               int lonNhat = mang.Max();
               Console.WriteLine("Phần tử lớn nhất trong mảng là: " + lonNhat);
          }

          // Bài 4: Đảo ngược chuỗi
          public void DaoNguocChuoi()
          {
               Console.Write("Nhập chuỗi: ");
               string chuoi = Console.ReadLine();
               char[] daoNguoc = chuoi.ToCharArray();
               Array.Reverse(daoNguoc);
               string chuoiDaoNguoc = new string(daoNguoc);

               Console.WriteLine("Chuỗi sau khi đảo ngược là: " + chuoiDaoNguoc);
          }

          // Bài 5: Kiểm tra mảng đối xứng
          public void KiemTraMangDoiXung()
          {
               Console.Write("Nhập số lượng phần tử của mảng: ");
               int n = int.Parse(Console.ReadLine());
               int[] mang = new int[n];

               for (int i = 0; i < n; i++)
               {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    mang[i] = int.Parse(Console.ReadLine());
               }

               bool doiXung = true;
               for (int i = 0; i < n / 2; i++)
               {
                    if (mang[i] != mang[n - i - 1])
                    {
                         doiXung = false;
                         break;
                    }
               }

               if (doiXung)
               {
                    Console.WriteLine("Mảng là đối xứng.");
               }
               else
               {
                    Console.WriteLine("Mảng không đối xứng.");
               }
          }

          // Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
          public void DemSoLanXuatHienKyTu()
          {
               Console.Write("Nhập chuỗi: ");
               string chuoi = Console.ReadLine();
               Console.Write("Nhập ký tự cần đếm: ");
               char kyTu = char.Parse(Console.ReadLine());
               int dem = 0;

               foreach (char c in chuoi)
               {
                    if (c == kyTu)
                    {
                         dem++;
                    }
               }

               Console.WriteLine($"Số lần xuất hiện của ký tự '{kyTu}' trong chuỗi là: " + dem);
          }

          // Hàm Main để gọi các phương thức
          static void Main(string[] args)
          {
               BaiTap baiTap = new BaiTap();

               baiTap.TinhTongMang();
               baiTap.DemKyTuChuoi();
               baiTap.TimPhanTuLonNhat();
               baiTap.DaoNguocChuoi();
               baiTap.KiemTraMangDoiXung();
               baiTap.DemSoLanXuatHienKyTu();
          }
     }
}