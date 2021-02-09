using System;

namespace _00001
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;
            Console.WriteLine("时间   秒");
            while (true)
            {
                try
                {
                    v = Convert.ToInt32(Console.ReadLine()); break;
                }
                catch
                {
                    Console.WriteLine("输入不规范");
                }
            }
            Console.WriteLine("一共{0}分{1}秒", v / 60, v % 60);
        }
    }
}
