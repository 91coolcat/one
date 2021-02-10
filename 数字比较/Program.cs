using System;

namespace 数字比较
{
    class Program
    {
        static void Main(string[] args)
        {
            //将数字从小到大排序
            int[] num = { 9, 4, 6, 7, 1, 2, 3 };
            for (int i = 0; i < num.Length-1; i++)
            {
                for (int j = 0; j < num.Length-1-i; j++)
                {
                    if (num[j] > num[j+1])
                    {
                        int a = num[j];
                        num[j] = num[j+1];
                        num[j+1] = a;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }
        }
    }
}
