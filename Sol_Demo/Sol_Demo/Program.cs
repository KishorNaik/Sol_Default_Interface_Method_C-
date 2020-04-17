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

            IA demoA = new DemoC();
            demoA.Display();
            demoA.Display1();

            IB demoB = new DemoC();
            demoB.Display();
            demoB.Display2();

            ID dObj = new DemoD();
            dObj.Display1();
            dObj.Display2();

            demoA = dObj;
            demoA.Display();

            demoB = dObj;
            demoB.Display();

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


    public interface IA
    {
        public void Display()
        {
            Console.WriteLine("Display A");
        }

        public void Display1()
        {
            Console.WriteLine("Display1 : A");
        }
    }

    public interface IB
    {
        public void Display()
        {
            Console.WriteLine("Display B");
        }

        public void Display2()
        {
            Console.WriteLine("Display2 : A");
        }
    }


    public class DemoC : IA,IB
    {

    }


    public interface ID : IA,IB
    {

    }

    public class DemoD : ID
    {
        
    }

}
