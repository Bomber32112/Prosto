namespace ConsoleApp1125НИ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер главы");
            int.TryParse(Console.ReadLine(), out int number_of_head);
            Console.WriteLine("Номер задания");
            int.TryParse(Console.ReadLine(), out int number_of_execise);
            switch (number_of_head)
            {
                case 1:
                    switch (number_of_execise)
                        {
                        case 1: N1_1();
                            break;
                        case 6: N1_6(); break;
                        
                        case 16: N1_16(); break;
                    }
                break;
                case 2:
                    switch (number_of_execise)  
                    {
                        case 1: N2_1(); break;
                            case 6: N2_6(); break;
                        case 8: N2_8(); break;
                        case 9: N2_10(); break;
                        case 36: N2_36(); break;
                    }
                    break;

            }
        }
        static void N1_1 () 
        {
            int.TryParse(Console.ReadLine(), out int number_1);
            int.TryParse(Console.ReadLine(), out int number_2);
            int.TryParse(Console.ReadLine(), out int number_3);
            Console.WriteLine(number_1 + " " + number_2 + " " + number_3);
        }
        static void N1_6()
        {
            int.TryParse (Console.ReadLine(), out int number_1);
            Console.WriteLine(Math.Round(Math.PI, number_1));
        }
        static void N1_16() 
        {
            int.TryParse(Console.ReadLine(), out int size);
            string[] massive = new string[size];
            for (int i = 0; i < size; i++) 
            {
                massive[i] = Console.ReadLine();  
            }
            for (int i = 0; i < size; i++) 
            {
                
                if (i != 0 &&i % 2 == 0)
                {
                    Console.WriteLine(massive[i]);
                }
                else
                {
                    Console.Write(massive[i] + $"\t");
                }
            }
        }
        static void N2_1()
        {
            Console.WriteLine("Номер подномера");
            int.TryParse(Console.ReadLine(), out int under_execise);
            switch (under_execise)
            {
                case 1:
                    double.TryParse(Console.ReadLine(), out double x);
                    Console.WriteLine(17 * Math.Pow(x, 2) - 6 * x + 13);
                    break;

                case 2:
                    double.TryParse(Console.ReadLine(), out double a);
                    Console.WriteLine(3 * Math.Pow(a, 2) + 5 * a - 21);
                    break;
            }
        }
        static void N2_5() 
        {
            int.TryParse(Console.ReadLine(), out int under_);
            Console.WriteLine(under_*2);
        }
        static void N2_6() 
        {
            double radius = 6350;
            double.TryParse(Console.ReadLine(), out double point_of_high);
            Console.WriteLine(Math.Sqrt(Math.Pow(radius + point_of_high, 2) - Math.Pow(radius,2)));
        }
        static void N2_7() 
        {
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(number * number * number + $"\t" + number * number);
        }
        static void N2_8() 
        {
            double.TryParse(Console.ReadLine(), out double radius);
            Console.WriteLine("Длина окружности:" + 2 * radius * Math.PI + $"\nПлощадь круга:" + Math.PI * (radius*radius));
        }
        static void N2_10() 
        {
            double.TryParse(Console.ReadLine(), out double number_1);
            double.TryParse(Console.ReadLine(), out double number_2);
            Console.WriteLine("Среднее арифмитическое: " + (number_1 + number_2) / 2 + "Среднее геометрическое: " + Math.Sqrt(number_1*number_2));
        }
        static void N2_36() 
        {
            double.TryParse(Console.ReadLine(), out double celse);
            Console.WriteLine("По фаренгейту: " + Term.Farengate(celse) + "По кельвину: " + Term.Kelvin(celse));
        }
        static void N2_37() 
        {
            
            
        }
    }
    static public class Term 
    {
        public static double Farengate(double n)
        {
            return (n * 1.8) + 32;
        }
        public static double Kelvin(double n)
        {
            return n - 273.15;
        }
        public static double FarToCelse(double n) 
        {
            return (n - 32) / 1.8;
        }
        public static double KelToCelse(double n)
        {
            return n + 273.15;
        }
    }
}
