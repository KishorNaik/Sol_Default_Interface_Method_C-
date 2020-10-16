using System;

namespace Sol_Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDemo demo = new Demo();
            demo.DemoMethod();
            demo.DemoPublicDefaultMethod();
            demo.DemoVirtualDefaultMethod();
            demo.DemoAbstractDefaultMethod();
            Console.WriteLine(demo.Message);

            IDemo.DemoStaticDefaultMethod(); // Static Method

            // Call method throug Class Object
            Demo demo1Obj = new Demo();
            // So Here you will get any method throug Object.
            ((IDemo)demo1Obj).DemoMethod();

            //--------------------------------------------

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
        void DemoMethod();

        // Public Method
        // By Default is virtual method
        public void DemoPublicDefaultMethod()
        {
            Console.WriteLine("Default Public Method Demo");
            this.DemoPrivateDefaultMethod();
        }

        // Private Method
        private void DemoPrivateDefaultMethod()
        {
            Console.WriteLine("Demo Default Private Method");
        }

        // Virtual Method
        virtual void DemoVirtualDefaultMethod()
        {
            Console.WriteLine("Demo Interface : Virtual Method");
        }

        // Abstract Method
        abstract void DemoAbstractDefaultMethod();

        //Static Method
        public static void DemoStaticDefaultMethod()
        {
            Console.WriteLine("Demo Interface : static method");
        }

        // Property
        public String Message => "Hello";
    }

    public class Demo : IDemo
    {
        void IDemo.DemoMethod()
        {
            Console.WriteLine("Demo Method 1 Implement");
        }

        // If you want to Override Default Interface Method then do the following procedures
        //void IDemo.DemoDefaultMethod1()
        //{
        //    Console.WriteLine("Override Default Method Demo");
        //}

        void IDemo.DemoVirtualDefaultMethod()
        {
            Console.WriteLine("Demo Class : Override method");
        }

        void IDemo.DemoAbstractDefaultMethod()
        {
            Console.WriteLine("Demo Override Abstract Method");
        }
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

    public class DemoC : IA, IB
    {
    }

    public interface ID : IA, IB
    {
    }

    public class DemoD : ID
    {
    }
}