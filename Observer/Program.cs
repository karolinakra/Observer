using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            //ConcreteSubject cs = new ConcreteSubject("spi");

            ////cs.SubjectState = "spi";


            //ConcreteObserver co = new ConcreteObserver(cs, "Andrzej");
            //ConcreteObserver co1 = new ConcreteObserver(cs, "Tomek");
            //ConcreteObserver co2= new ConcreteObserver(cs, "Stefan");

            //cs.Attach(co);
            //cs.Attach(co1);
            //cs.Attach(co2);


            //cs.SubjectState = "wstal";

            //cs.Detach(co);
            //cs.Notify();


            //Console.WriteLine();
            //Console.ReadLine();

            ConcreteHandler1 ch1 = new ConcreteHandler1();
            ConcreteHandler3 ch2 = new ConcreteHandler3();
            ConcreteHandler3 ch3 = new ConcreteHandler3();

            ch1.SetSuccessor(ch2);
            ch2.SetSuccessor(ch3);


            ch1.HandleRequest(22);

            



        }
    }
}
