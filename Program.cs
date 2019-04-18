using System;

namespace helloworld
{
    class Program
    {
        public static int ThreadStaticAttribute = 1;
        static void Main(string[] args)
        {
           
            MyClass c1 = new MyClass();
             Console.WriteLine(Program.ThreadStaticAttribute);
        }
    }
}
