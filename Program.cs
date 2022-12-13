
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork2
{
    public class Phone 
    {
        public long number;
        public string model;
        public double weight;
        public void ReceiveCall (string name)
        {
            Console.WriteLine($"{name} is calling.");
        }
        public long GetNumber()
        {
            return number;
        }
        public void ReceiveCall(string name, long number)
        {
            Console.WriteLine($"{name} is calling with {number.ToString("+###-(##)-###-##-##")} number");
        }
        public void SendMessages(params long[] numbers)
        {
            foreach (long number in numbers) 
            {
                Console.Write($"{number.ToString("+###-(##)-###-##-##")} ");
            }
            Console.WriteLine("\t");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var Iphone = new Phone();
            var Samsung = new Phone();
            var Xiaomi = new Phone();

            Iphone.number = 375295372543;
            Iphone.model = "5S";
            Iphone.weight = 0.21;
            Samsung.number = 37533679123;
            Samsung.model = "Galaxy A5";
            Samsung.weight = 0.23;
            Xiaomi.number = 375253467213;
            Xiaomi.model = "12t";
            Xiaomi.weight = 0.22;

            Console.WriteLine($"Iphone number is {Iphone.number.ToString("+###-(##)-###-##-##")}");
            Console.WriteLine($"Iphone model is {Iphone.model}");
            Console.WriteLine($"Iphone weight is {Iphone.weight}");
            Console.WriteLine($"Samsung number is {Samsung.number.ToString("+###-(##)-###-##-##")}");
            Console.WriteLine($"Samsung model is {Samsung.model}");
            Console.WriteLine($"Samsung weight is {Samsung.weight}");
            Console.WriteLine($"Xiaomi number is {Xiaomi.number.ToString("+###-(##)-###-##-##")}");
            Console.WriteLine($"Xiaomi model is {Xiaomi.model}");
            Console.WriteLine($"Xiaomi weight is {Xiaomi.weight}");

            Iphone.ReceiveCall("Nikita");
            Samsung.ReceiveCall("Dima");
            Xiaomi.ReceiveCall("Alex");

            Console.WriteLine(Iphone.GetNumber());
            Console.WriteLine(Samsung.GetNumber());
            Console.WriteLine(Xiaomi.GetNumber()); 

            Iphone.ReceiveCall("Nikita", 375294225312);
            Samsung.ReceiveCall("Dima", 375336841286);
            Xiaomi.ReceiveCall("Alex", 375253569134);

            Iphone.SendMessages(375294225312);
            Samsung.SendMessages(375336841286, 375294225312);
            Xiaomi.SendMessages(375253569134, 375336841286, 375294225312);

        }
    }
}