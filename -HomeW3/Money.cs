public class Money
{
 public void MonGen()
    {
        double a, b, c, d, e, f, g, h, i, j, k, remain;
        Console.Write("Please input money : ");
        remain = double.Parse(Console.ReadLine());
            a = remain / 1000;
            remain = remain % 1000;
            b = remain / 500;
            remain = remain % 500;
            c = remain / 100;
            remain = remain % 100;
            d = remain / 50;
            remain = remain % 50;
            e = remain / 20;
            remain = remain % 20;
            f = remain / 10;
            remain = remain % 10;
            g = remain / 5;
            remain = remain % 5;
            h = remain / 2;
            remain = remain % 2;
            i = remain / 1;
            remain = remain % 1;

            remain = remain * 100;
            j = remain / 50;
            remain = remain % 50;
            k = remain / 25;
            remain = remain % 25;

            Console.WriteLine("1000: {0}", Math.Floor(a));
            Console.WriteLine("500: {0}", Math.Floor(b));
            Console.WriteLine("100: {0}", Math.Floor(c));
            Console.WriteLine("50: {0}", Math.Floor(d));
            Console.WriteLine("20: {0}", Math.Floor(e));
            Console.WriteLine("10: {0}", Math.Floor(f));
            Console.WriteLine("5: {0}", Math.Floor(g));
            Console.WriteLine("2: {0}", Math.Floor(h));
            Console.WriteLine("1: {0}", Math.Floor(i));
            Console.WriteLine("0.50: {0}", Math.Floor(j));
            Console.WriteLine("0.25: {0}", Math.Floor(k));
    }
}