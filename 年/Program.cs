using System;

namespace 年
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int y;string s;string s1="1";
            while (true)
            {
                try
                {
                    Console.WriteLine("输入年份");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("输入月份");
                    y = Convert.ToInt32(Console.ReadLine());
                    if(y>1 && y <12) break;
                }
                catch
                {
                    Console.WriteLine("输入不合理");
                }
            }
            if (n % 4 == 0) s = ("是润年");
            else s = ("不是闰年");
            if (y==2)
            {
                if (n % 4 == 0) s1 = "28";
                else s1 = "29";
            }
            else if (n%2==0) s1= "30";
            else if(n%2!=0) s1="31";
            Console.WriteLine("{0}年是{1}，{2}月有{3}天", n, s, y, s1);
        }
    }
}
