using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            var function= new BunchOfFunction();
            var timer=new Stopwatch();
            var timer2=new Stopwatch();
            timer.Start();
            var t1= function.ListPrimeNumber(0,40,function.IsPrime1);
            var t2= function.ListPrimeNumber(41,60,function.IsPrime1);
            var t3= function.ListPrimeNumber(61,69,function.IsPrime1);
            var t4= function.ListPrimeNumber(70,75,function.IsPrime1);
            var t5= function.ListPrimeNumber(76,80,function.IsPrime1);
            var t6= function.ListPrimeNumber(81,86,function.IsPrime1);
            var t7= function.ListPrimeNumber(87,90,function.IsPrime1);
            var t8= function.ListPrimeNumber(91,93,function.IsPrime1);
            var t9= function.ListPrimeNumber(94,97,function.IsPrime1);
            var t10= function.ListPrimeNumber(98,100,function.IsPrime1);
            Task.WaitAll(t1,t2,t3,t4,t5,t6,t7,t8,t9,t10);
            timer.Stop();
            Console.WriteLine($"Power of 10 threads: {timer.Elapsed.Seconds}s:{timer.Elapsed.Milliseconds}");

            timer2.Start();
            var t11 = function.ListPrimeNumber(0,100,function.IsPrime1);
            t11.Wait();
            timer2.Stop();
            Console.WriteLine($"Power of 1 thread: {timer2.Elapsed.Seconds}s:{timer2.Elapsed.Milliseconds}");
        }
    }
}
