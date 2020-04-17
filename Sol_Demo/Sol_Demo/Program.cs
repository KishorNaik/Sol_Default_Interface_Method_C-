using System;

namespace Sol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDemo demo = new Demo();
            demo.DemoMethod1();
            demo.DemoDefaultMethod();
        }
    }

    public interface IDemo
    {
        void DemoMethod1();

        public void DemoDefaultMethod()
        {
            Console.WriteLine("Default Method Demo");
        }
    }

    public class Demo : IDemo
    {
        void IDemo.DemoMethod1()
        {
            Console.WriteLine("Demo Method 1 Implement");
        }

        // If you want to Override Default Interface Method then do the following procedures
        //void IDemo.DemoDefaultMethod()
        //{
        //    Console.WriteLine("Override Default Method Demo");
        //}
    }
}
