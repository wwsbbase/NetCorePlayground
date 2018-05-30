using System;

namespace NetCorePlayground
{
    class Program
    {
        static void Time()
        {
            System.DateTime currentTime=new System.DateTime();
            currentTime=System.DateTime.Now; 
             Console.WriteLine(currentTime);
        }
        static void Main(string[] args)
        {
            Time();
            Console.WriteLine("Hello World!");
        }
    }
}
