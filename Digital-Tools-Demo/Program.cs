using System;
class Program
{
    static void Main(string[] args)
    {
        Point p = new Point(5, 40);
        p.ShowData();

        Counter c = new Counter(0, 100);
        c.Increment();
        Console.WriteLine(c.GetCurrent());
        c.Increment();
        Console.WriteLine(c.GetCurrent()); 
    }
}
