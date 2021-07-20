using System;

namespace DeclaracionSwitch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int autos = 1;

            switch (autos)
            {
                case 0:
                    Console.WriteLine("Usted no paga impuestos");
                    break;

                case 1:
                    Console.WriteLine("Usted paga 15$");
                    break;

                case 2:
                    Console.WriteLine("Usted paga 30$");
                    break;

                default:
                    Console.WriteLine("Usted paga 15$ dolares por auto");
                    break;
            }
            Console.Read();
        }
    }
}
