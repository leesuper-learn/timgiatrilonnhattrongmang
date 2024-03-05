using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timgiatrilonnhattrongmang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] arr;
            do
            {
                Console.WriteLine("Nhap tong gia tri can so sanh ( khong duoc vuot qua 20) : ");
                size = int.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Kich thuoc khong duoc vuot qua 20.");
                }
            } while (size > 20);
            arr = new int[size];
            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine("Gia tri tai san cua nguoi thu " + (i+1) + " la :");
                arr[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Danh sach top 20 nguoi la : ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            int max = arr[0];
            int index = 1;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max)
                {
                    max = arr[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("Nguoi giau nhat trong top 20 nguoi đang so huu: " + max + " ( ti do ), co SBD la:  " + index);
            Console.ReadKey();

        }
    }
}
