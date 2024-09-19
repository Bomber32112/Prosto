namespace ConsoleApp1125НИ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var method = program.GetType().GetMethod(Console.ReadLine());
            method.Invoke(program, null);
            //Console.WriteLine("Номер главы");
            //int.TryParse(Console.ReadLine(), out int number_of_head);
            //Console.WriteLine("Номер задания");
            //int.TryParse(Console.ReadLine(), out int number_of_execise);
            //switch (number_of_head)
            //{
            //    case 1:
            //        switch (number_of_execise)
            //            {
            //            case 1: N1_1();
            //                break;
            //            case 6: N1_6(); break;
                        
            //            case 16: N1_16(); break;
            //        }
            //    break;
            //    case 2:
            //        switch (number_of_execise)  
            //        {
            //            case 1: N2_1(); break;
            //                case 6: N2_6(); break;
            //            case 8: N2_8(); break;
            //            case 9: N2_10(); break;
            //            case 36: N2_36(); break;
            //        }
            //        break;

            //}
        }
        public static void N1_1 () 
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
        public static void N4_118() 
        {
            int.TryParse (Console.ReadLine(), out int x);
            if (x <= 0) x = 0;
            else if (x > 0 && x <= 1);
            else x *= x;
            Console.WriteLine($"f(x) = {x}");
        }
        public static void N4_119() 
        {
            int.TryParse(Console.ReadLine(), out int y);
            if (y > 2) y = 2;
            else if (y > 0 && y <= 2);
            else y = (~y + 1)*3;
            Console.WriteLine($"f(y) = {y}");
        }
        public static void N4_120()
        {
            int.TryParse(Console.ReadLine(), out int under);
            int.TryParse(Console.ReadLine(), out int x);
            double y;
            switch (under)
            {
                case 1:
            
            
            if (x >= -1 && x <= 1) y = 1; break;
            case 2:
                    if (x >= -1 && x<= 1) y = ~x+1;
             break;
            case 3:
                    if (x >= -1 && x <= 1) y = x - 0.5;
                    break;
            }
        }
        public static void N4_133() 
        {
            int.TryParse(Console.ReadLine(), out int x);
            switch (x)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;
            }
        }
        public static void N4_135() 
        {
            int.TryParse(Console.ReadLine(), out int x);
            Console.Write(test(x));
            static string test(int x) => x 
            switch
            {
                1 or 2 or 12 => "Зима",
                >=3 and <=5 => "Весна",
                >= 6 and <= 8 => "Лето",
                >= 9 and <= 11 => "Осень"
            };
        }
        public static void N4_136() 
        {
            int.TryParse(Console.ReadLine(), out int month);
            bool.TryParse(Console.ReadLine(), out bool x);
            if (month == 2 && x) Console.WriteLine(29); else Console.WriteLine(test(month));
            static int test(int month) => month
            switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                2 => 28,
                4 or 6 or 9 or 11 => 30
            };
        }
        public static void N4_138() 
        {
            int.TryParse(Console.ReadLine(), out int number);
            switch (number) 
            {
                case 1: Console.WriteLine("Пики"); break;
                case 2:
                    Console.WriteLine("Трефы"); break;
                case 3:
                    Console.WriteLine("Бубны"); break;
                case 4:
                    Console.WriteLine("Черви"); break;
            }
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
