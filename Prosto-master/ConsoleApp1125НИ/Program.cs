using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1125НИ
{
    public class Book { public string book { get; set; } } 
    internal class Program
    {
        static void Main(string[] args)
        {
            //UDP_server();
            //Thread client = new Thread( UDP_client);client.Start();
            //Thread server = new Thread(UDP_server); server.Start();
            //while (true) { }

            var program = new Program();
            back:
            var method = program.GetType().GetMethod(Console.ReadLine());
            if (method == null) { Console.WriteLine("Нет такого метода"); goto back; }
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
        public static void N4_139()
        {
            int.TryParse(Console.ReadLine(), out int number_1);
            int.TryParse(Console.ReadLine(), out int number_2);
            string suits = string.Empty;
            string dignity = string.Empty;
            switch (number_1)
            {
                case 1: suits = "пик"; break;
                case 2:
                    suits = "треф"; break;
                case 3:
                    suits = "бубен"; break;
                case 4:
                    suits = "черв"; break;
            }
            switch (number_2) 
            {
                case 6: dignity = "Шестёрка "; break;
                case 7: dignity = "Семёрка "; break;
                case 8: dignity = "Восмёрка "; break;
                case 9: dignity = "Девятка "; break;
                case 10: dignity = "Десятка "; break;
                case 11: dignity = "Валет "; break;
                case 12: dignity = "Дама "; break;
                case 13: dignity = "Король "; break;
                case 14: dignity = "Туз "; break;
            }
            Console.WriteLine(dignity + suits);
        }
        public static void N5_8() // public static void N5_9() { }
        {
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine($"Фунты\tКилограммы");
            for (int i = 1; i < number; i++) 
             Console.WriteLine($"{i}\t{0.453 * i}");
        } 

        public static void N5_9() 
        {
            Console.WriteLine("С какого числа"); 
            int.TryParse(Console.ReadLine(), out int number_1);
            Console.WriteLine("По какое число");
            int.TryParse(Console.ReadLine(), out int number_2);
            Console.WriteLine($"Дюймы\tСантиметры");
            for (int i = 1; i < number_2; i++)
                Console.WriteLine($"{i}\t{2.54 * i}");
        }
        public static void N5_11() 
        {
            double radius = 6350;
            Console.WriteLine("Начальная точка");
            double.TryParse(Console.ReadLine(), out double point_of_high_0);
            Console.WriteLine("Конечная точка");
            double.TryParse(Console.ReadLine(), out double point_of_high);
            for (;point_of_high_0 < point_of_high; point_of_high_0++)
            Console.WriteLine(Math.Sqrt(Math.Pow(radius + point_of_high_0, 2) - Math.Pow(radius, 2)));
        }
        public static void N5_17()
        {
            Console.WriteLine("От какого числа");
            int.TryParse(Console.ReadLine(), out int i);
            Console.WriteLine("До какого числа");
            int.TryParse(Console.ReadLine(), out int x);
            for (; i <= x; i++)  
                Console.WriteLine(3*(i + 3)*(i + 3) + 4.87*(i + 3) - 3);
        }
        public static void N5_22() 
        {
            Console.WriteLine("Стоимость 1 кг");
            int.TryParse(Console.ReadLine(), out int price);
            for (float i = 0.1F; i < 20; i=+0.1F)  Console.WriteLine(price*i);
        }
        public static void N5_41() 
        {
            Console.WriteLine("Введите число");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine("Количество последних цифр");
            int.TryParse(Console.ReadLine(), out int last_numbers);
            int result = 0;
            for (int i = 0; i < last_numbers; i++) 
            {
                result += number % 10;
                number /= 10;
            }
            Console.WriteLine(result);
        }
        public static void N5_42() 
        {
            Console.WriteLine("Количество переобуваний");
            int.TryParse(Console.ReadLine(), out int number);
            bool to_work_from_home = true;
            double meters = 1000;
            double meters_2 = 0;
            double result_1 = 0;
            double result_2 = 0;
            for (int i = 3; i < number; i++) 
            {
                meters_2 = meters / i;
                result_2 += meters_2;
                if (to_work_from_home) to_work_from_home = false; else { to_work_from_home = true; result_1 = meters_2;}
            }
            Console.WriteLine("Расстояние до дома: " + result_1);
            Console.WriteLine("Общий пройденный путь: " + result_2);
        }
        public static void N5_43() 
        {
            int.TryParse(Console.ReadLine(), out int number); 
            float a = 1;
            for (int i = 1; i <= number; i++) 
            {
                Console.WriteLine(a);
                a = i*a+1/i;
            }
        }
        public static void N5_44() 
        {
            int.TryParse(Console.ReadLine(), out int number);
            int a0 = 1, an = 1, b = 1;
            for (int i = 1;i <= number; i++)
            {
                b = an + a0;
                Console.WriteLine(b);
                a0 = an;
                an = b;
            }
        }
        public static void N5_45() 
        {
            int.TryParse(Console.ReadLine(), out int number);
            int numenator_1 = 1, numenator_n = 1, numenator_res = 1;
            int denomenator_1 = 1, denomenator_n = 1, denomenator_res = 1;
            bool open = true;
            for(int i = 1; i<=number; i++) 
            {
                Console.WriteLine($"{numenator_res} / {denomenator_res}");
                numenator_res = numenator_1 + numenator_n;
                if(open) { open = false; goto turn;}
                denomenator_res=denomenator_1 + denomenator_n;
                denomenator_1=denomenator_n;
                denomenator_n=denomenator_res;
                turn:
                numenator_1 = numenator_n;
                numenator_n = numenator_res; 
            }
        }
        public static void N5_50() 
        {
            Console.WriteLine("Сколько бежал лыжник");
            int.TryParse(Console.ReadLine(), out int distance);
            Console.WriteLine("Сколько дней бежал лыжник");
            int.TryParse(Console.ReadLine(), out int days);
            int summ = 0;
            for(int i = 1;i<=days;i++)
            {
                summ += distance;
                Console.WriteLine($"Пробежал лыжник в {i} день: {distance}\nПробежал за всё время: {summ}");
                distance += distance/10;
            }
        }
        public static void N5_55() 
        {
            int.TryParse(Console.ReadLine(), out int number);
            
            int res = 1;
            int with_sign = -1;
            for(int i = 1; i<number; i++) 
            {
                res = i*i*with_sign;
                with_sign -= with_sign;
                Console.WriteLine(res + "" + with_sign);
            }
            
            for (double i = -1; i < number; i++)
            {
                i *= i;
                Console.WriteLine(i);
                i = Math.Sqrt(i);
            }
        }
        public static void N5_56() 
        {

        }
        static void UDP_server()
        {
            int port = 8080;
            //UdpClient listener = new UdpClient(port);
            ///IPEndPoint groupEP = ;
            Socket serv =
            //new Socket( SocketType.Stream, ProtocolType.IP);
            new Socket(SocketType.Dgram, ProtocolType.Udp);
            serv.Bind(new IPEndPoint(IPAddress.Any, port));
            //serv.Listen();

            //Socket client = serv.Receive;

            byte[] data = new byte[1000];
            while (true)
            {
                if (serv.Receive(data) > 0) { Console.WriteLine("by comp 3:" + Encoding.UTF32.GetString(data)); Array.Fill<byte>(data, 0); }
            }

        }

        static void UDP_client()
        {
            int port = 8080;
            IPAddress IP = IPAddress.Parse("192.168.1.3");
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            s.Connect(IP, port);


            byte[] data;
            while (true)
            {
                data = Encoding.UTF32.GetBytes(Console.ReadLine());
                s.Send(data);
                //if (data.Length > 0) Console.WriteLine(data);
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
