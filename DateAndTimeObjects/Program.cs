using System;

namespace DateAndTimeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(current.Hour);
            Console.WriteLine(current.Minute);
            Console.WriteLine(current.Second);
            Console.WriteLine(current.ToString("MMMM"));
            Console.WriteLine(current.ToString("yyyy"));
            Console.WriteLine(current.ToString("dddd dd, MMMM"));
            
        }
    }
}
