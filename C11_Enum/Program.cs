using System;

namespace C11_Enum
{
    public enum Level
    { 

        Low,
        Normal,
        High
    
    }


    class Program
    {
        enum Status
        { 
            Pending,
            Production,
            Transporting,
            Delivered
        }


        static void Main(string[] args)
        {

            var temperature = 32;
            var _tempLevel = Level.Normal;

            switch (temperature) 
            {

                case var t when t < 10:
                    _tempLevel = Level.Low;
                    Console.WriteLine("Temperature is to Low");
                break;

                case var t when t > 30:
                    _tempLevel = Level.High;
                    Console.WriteLine("Temperature is to High");
                    break;

                default:
                    _tempLevel = Level.Normal;
                    Console.WriteLine("Temperature is Normal");
                    break;

            }
            switch(_tempLevel) {
                case Level.Low:
                Console.WriteLine("Temperature is to Low");
                    break;
                case Level.Normal:
                    Console.WriteLine("Normal");
                    break;
                case Level.High:
                    Console.WriteLine("High");
                    break;
                    Console.WriteLine(_tempLevel);
            }

            
            
            var status = Status.Transporting;

                switch(status)
            {
                case Status.Pending:
                    Console.WriteLine("Info recived");
                    break;
                case Status.Production:
                    Console.WriteLine("Products ready for shipping");
                    break;
                case Status.Transporting:
                    Console.WriteLine("Products are in transit");
                    break;
                case Status.Delivered:
                    Console.WriteLine("Deliverd");
                    break;

            }


        }
    }
}
