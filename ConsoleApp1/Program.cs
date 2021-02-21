using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int l = 0; bool a = true;
            //1-100整数和
            //do
            //{
            //    l += i; i++;
            //} while (i != 101);
            //Console.WriteLine(l);
            //不断要求用户输入一个数字，输入end退出
            //while (a == true)
            //{
            //    Console.WriteLine("输入一个数字，输入end退出");
            // string s =Console.ReadLine();
            //    if (s == "end") a = false;
            //    else
            //    {
            //        try
            //        {
            //            i = Convert.ToInt32(s);
            //            l += i;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入格式不对");
            //        }
            //    }
            //}
            //Console.WriteLine("这些数字的和为{0}", l);
            //for (int ci = 100; ci < 1000; ci++)
            //{
            //    i = 0;
            //    int bai = ci / 100;i += bai * bai * bai;
            //    int shi = ci % 100/10; i += shi * shi * shi;
            //    int ge = ci %10; i += ge * ge * ge;
            //    if (i == ci) Console.WriteLine(i);
            //}
            //乘法表
            //for (int c = 1; c < 10; c++)
            //{
            //    for (int b = 1; b < 10; b++)
            //    {
            //        if (b >= c) Console.Write("{0}*{1}={2}\t",c,b,c*b);
            //    }
            //    Console.WriteLine();
            //}
            //不断要求用户输入一个数字,输入+或/进行求总和或者平均值
            //string vs = null;
            //while (a)
            //{
            //    Console.WriteLine("请输入第{0}个数字\n+&/", i+1);i++;
            //    string str = Console.ReadLine();
            //    if (int.TryParse(str, out l))
            //    {
            //        vs += l + "/";
            //    }
            //    else if (str == "+" || str == "/")
            //    {
            //        a = false; i = 0;
            //        string[] vs1 = vs.Split(new char[] { '/' });
            //        if (str == "+")
            //        {
            //            for (int p = 0; p < vs1.Length-1; p++)
            //            {
            //                i += int.Parse(vs1[p]);
            //            }
            //        }
            //        if (str.Equals("/"))
            //        {
            //            for (int p = 0; p < vs1.Length-1; p++)
            //            {
            //                i += int.Parse(vs1[p]);
            //            }
            //            i = i / (vs1.Length-1);
            //        }
            //        a = false;
            //    }
            //    else { Console.WriteLine("输入不合规"); i--; }
            //}
            //Console.WriteLine(i);
            //Console.ReadLine();
        }
    }
}
