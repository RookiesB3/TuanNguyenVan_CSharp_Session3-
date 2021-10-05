using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class BunchOfFunction{

        //Way 1 to check prime number
        public  bool IsPrime1(int number){
            if(number<=1) return false;
            if(number==2) return true;
            for (int i=2;i<number;i++){
                if(number%i==0){
                    return false;
                }
                Thread.Sleep(1);
            }
            return true;
        }

        //way 2 to check primay number
        public  bool IsPrime2(int number){
            if(number<=1) return false;
            if(number==2) return true;
            for (int i=2;i<Math.Sqrt(number)+1;i++){
                if(number%i==0){
                    return false;
                }
                Thread.Sleep(1);
            }
            return true;
        }

        //Create list prime number
        public  Task<List<int>> ListPrimeNumber(int start,int end, Func<int,bool> _type){
            Task<List<int>> t= new Task<List<int>>(()=>{
                List<int> listPrime =new List<int>();
                for (var i=start;i<end;i++){
                    if(_type(i)){
                        listPrime.Add(i);
                        //Console.WriteLine(i);
                    }
                }
                return listPrime;
            });
            t.Start();
            return t;
        }
    }
}