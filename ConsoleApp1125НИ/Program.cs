using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.InteropServices;
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
        public static void N11_16() 
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int different);
            Console.WriteLine("Размер массива");
            int.TryParse(Console.ReadLine(), out int size);
            int helping = a;
            int[] ints = [size];
            for (int i = 0; i < size; i++)
            {
                ints[i] = helping;
                helping += different;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(ints[i]);
            }
            
                  
        }
        public static void N11_16_2()
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int z);
            Console.WriteLine("Размер массива");
            int.TryParse(Console.ReadLine(), out int size);
            int[] ints = [size];
            ints[0] = a;
            for (int i = 1; i < size; i++)
            {
                ints[i] = a*z*(i+1);
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
        public static void N11_17() 
        {
            int.TryParse(Console.ReadLine(), out int size);
            int[] ints = [size];
            int a0 = 1, an = 1;
            for (int i = 0; i < size; i++)
            {
                ints[i] = an + a0;
                Console.WriteLine(ints[i]);
                a0 = an;
                an = ints[i];
            }
        }
        public static void N11_18() 
        {
            int.TryParse(Console.ReadLine(), out int size);
            int[] ints = [size];
            Console.WriteLine("Левая граница");
            int.TryParse(Console.ReadLine(), out int left_border);
            Console.WriteLine("Правая граница");
            int.TryParse(Console.ReadLine(), out int right_border);
            for (int i = 0; i < size; i++)
            {
                for (int j = left_border; j < right_border; j++)
                if (j%13==0 && j%17==0) ints[i] = i;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
        public static void N11_20() 
        {
            int.TryParse(Console.ReadLine(), out int size);
            int[] ints = new int[size];
            List<int> wrongs = new List<int>();
            Random random = new Random();
            int right_answer = 0;
            for (int i = 0; i < size; i++)
            {
                int a = random.Next(1,10);
                int b = random.Next(1,10);
                Console.WriteLine($"Сколько будет умножить {a} на {b}?");
                int.TryParse(Console.ReadLine(), out int num);
                ints[i] = num;
                if (ints[i] == a * b) right_answer++;
                else wrongs.Add(i+1);
            }
            Console.WriteLine($"Правильных ответов: {right_answer}");
            Console.WriteLine($"Неправильных ответов: {size-right_answer}");
            Console.Write("Ошибки в ");
            for (int i = 0;i < wrongs.Count; i++)
            Console.Write($"{wrongs[i]} ");
            Console.Write("ответах");

        }
        public static void N11_21() 
        {
            Console.WriteLine("Размер массива");
            int.TryParse(Console.ReadLine(), out int size);
            int[] ints = new int[size];
            Random random = new Random();
            for (int i = 0; i<size; i++) 
            {
                newRand:
                ints[i] = random.Next();
                for (int j = 0; j < size; j++)
                {
                    if (ints[i] == ints[j] && i!=j) goto newRand;
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
        
        public static void N14_5() 
        {
            Console.WriteLine("Ширина");
            int.TryParse(Console.ReadLine(), out int width);
            Console.WriteLine("Длина");
            int.TryParse(Console.ReadLine(), out int lenght);
            Square(width,lenght);
            void Square(int width, int lenght) 
            {
                StarLine(width);
                for (int i = 0; i < lenght; i++)
                {
                    Console.Write('*');
                    for (int j = 0;j < lenght-2; j++)
                        Console.Write(' ');
                    Console.WriteLine('*');
                }
                StarLine(width);

            }
            void StarLine(int width) 
            {
                for(int i = 0;i < width; i++)
                Console.Write('*');
                Console.WriteLine();
            }
        }
        public static void N14_6() 
        {
            Console.WriteLine("Стороны первого треугольника");
            int.TryParse(Console.ReadLine(), out int t1_side1);
            int.TryParse(Console.ReadLine(), out int t1_side2);
            int.TryParse(Console.ReadLine(), out int t1_side3);
            Console.WriteLine("Стороны второго треугольника");
            int.TryParse(Console.ReadLine(), out int t2_side1);
            int.TryParse(Console.ReadLine(), out int t2_side2);
            int.TryParse(Console.ReadLine(), out int t2_side3);
            int t1_p = t1_side1 + t1_side2 + t1_side3;
            int t2_p = t2_side1 + t2_side2 + t2_side3;
            Console.WriteLine($"Периметр: {t1_p+t2_p} Площадь: {S(t1_p, t1_side1, t1_side2,t1_side3) + S(t2_p, t2_side1, t2_side2, t2_side3)}");
            
            double S (int p, int a, int b, int c) 
            { p /= 2;
                return Math.Sqrt(p * (a - p) * (b - p) * (c - p));
            }
        }
        public static void N14_7() 
        {
            Console.WriteLine("Основания и высота первой трапеции");
            int.TryParse(Console.ReadLine(), out int t1_base1);
            int.TryParse(Console.ReadLine(), out int t1_base2);
            int.TryParse(Console.ReadLine(), out int t1_h);
            Console.WriteLine("Основания и высота второй трапеции");
            int.TryParse(Console.ReadLine(), out int t2_base1);
            int.TryParse(Console.ReadLine(), out int t2_base2);
            int.TryParse(Console.ReadLine(), out int t2_h);
            Console.WriteLine($"Сумма периметров {P(t1_base1, t1_base2, t1_h)+P(t2_base1, t2_base2, t2_h)} Сумма площадей {S(t1_base1, t1_base2, t1_h) + S(t2_base1, t2_base2, t2_h)}");
            int P(int a, int b, int h) 
            { return a+b+2*h;}
            int S(int a, int b, int h) {return (a+b)/2*h;}
        }
        public static void N14_14() 
        {
            //произвольная фигура из двух прямоугольных треугольников
            Console.WriteLine("Стороны ");
            int.TryParse(Console.ReadLine(), out int side1);
            int.TryParse(Console.ReadLine(), out int side2);
            int.TryParse(Console.ReadLine(), out int side3);
            double side4 = Hypotenuse(side1, side2); //гипотенуза первого треугольника
            Console.WriteLine($"{Hypotenuse(side3, side4)+side1+side2+side3}"); //гипотенуза второго треугольника и периметр фигуры
            double Hypotenuse (double a, double b) { return Math.Sqrt(a * a + b * b); }

        }
        public static void N14_25() 
        {
            Console.WriteLine((2*Factorial(5)+3*Factorial(8))/Factorial(6)+Factorial(4));
        }
        public static void N14_26() 
        {
            int result1 = 0;
            int result2 = 0;
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);
            int[] ints1 = IntToArray(number1);
            int[] ints2 = IntToArray(number2);
            for (int i = 0; i < Math.Min(ints1.Length, ints2.Length); i++) 
            {
                result1 += ints1[i];
                result2 += ints2[i];
            }
            if (result1 > result2) Console.WriteLine("Первое число больше");
            else if (result1 < result2) Console.WriteLine("Второе число больше");
            else Console.WriteLine("Числа равны");
        }
        public static void N14_27()
        {
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);
            int result1 = IntToArray(number1).Length;
            int result2 = IntToArray(number2).Length;
            if (result1 > result2) Console.WriteLine("Первое число больше");
            else if (result1 < result2) Console.WriteLine("Второе число больше");
            else Console.WriteLine("Числа равны");
        }
        public static void N14_28() 
        {
            Console.WriteLine(LuckyNumber(123123));
            static bool LuckyNumber(int number) 
            {
                int[] ints = IntToArray(number);
                int result1 = 0, result2 = 0;
                for (int i = 0, j = ints.Length; i < Math.Min(3, ints.Length); i++)
                {
                    result1 += ints[i];
                    result2 += ints[--j];
                }
                return result1 == result2;
            }
        }
        public static void N14_29() 
        {
            int[] array1 = ArrayInput();
            int[] array2 = ArrayInput();
            int[] array3 = ArrayInput();
            int result1 = Similarities(array1, array3);
            int result2 = Similarities(array2, array3);
            Console.WriteLine(result1==result2?"Одинаковое количество одинаковых элементов":(result1>result2?"Больше одинаковых элементвов в масиве 1":"Больше одинаковых элементвов в масиве 2"));
            static int Similarities (int[] a, int[] b) 
            {
                int result = 0;
                for (int i = 0; i < a.Length; i++) 
                {
                    for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j]) result++;
                }
                return result;
            }
        }
        public static void N14_30() 
        {
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);
            Console.WriteLine(Palindromes(number1)||Palindromes(number2));
            static bool Palindromes(int x) 
            {
                int[] ints = IntToArray(x);
                Array.Reverse(ints);
                int result = ArrayToInt(ints);
                return result==x;
            }  
        }
        public static void N14_31() 
        {
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);
            Console.WriteLine(number1*number2/NOD(number1, number2));
        }
        public static void N14_32() 
        {
            Fraction fraction = new (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine($"{fraction.x/NOD(fraction.x, fraction.y)}/{fraction.y / NOD(fraction.x, fraction.y)}");
        }
        struct Fraction
        {
            public int x,y;
            public Fraction(int x, int y) { this.x = x; this.y = y; }
        }
        public static void N9_1() 
        {
            bool space = true;
            int words = 0;
            string text = Console.ReadLine();
            for (int i = 0; text[i] != '.'; i++) 
            {
                if (text[i] == ' ') space = true;
                if (space && text[i]!=' ') { words++; space = false;}
            }
            Console.WriteLine(words);
        }
        public static void N9_exemple() 
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            // 1 вариант (с циклом)
            string textNew = string.Empty;
            for (int q = 0; q < text.Length; q++)
            {
                if (text[q] == ' ')
                    textNew += ", ";
                else
                    textNew += text[q];
            }
            //text = textNew;
            Console.WriteLine(textNew);

            // 2 вариант замена подстрок
            text = text.Replace(" ", ", ");
            Console.WriteLine(text);
        }
        public static void N9_2() 
        {
            bool space = true;
            int words = 0;
            int wordsD = 0;
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++) 
            {
                if (text[i] == ' ') space = true;
                else
                {
                    if (space) 
                    { 
                        words++;
                        if (text[i] == 'd') wordsD++;
                        space = false;
                    }
                }
            }
            Console.WriteLine($"{words} {wordsD}");
        }
        public static void N9_3() 
        {
            string text = Console.ReadLine();
            int r = 0, k = 0, t = 0;
            for (int i = 0; i < text.Length; i++) 
            {
                switch (text[i]) 
                {
                    case 'r': r++; break;
                    case 'k': k++; break;
                    case 't': t++; break;
                }
            }
            Console.WriteLine($"{r} {k} {t}");
        }
        public static void N9_4() 
        {
            string text = Console.ReadLine();
            int mult = 0, point_pt = 0, t_point = 0;
            for (int i = 0; i < text.Length; i++) 
            {
                switch (text[i]) 
                {
                    case '*': mult++; break;
                    case ';': point_pt++; break;
                    case ':': t_point++; break;
                }
            }
            Console.WriteLine($"{mult} {point_pt} {t_point}");
        }
        public static void N9_5() 
        {
            string text = Console.ReadLine();
            var splt = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(splt.Max(x => x.Length));
        }
        public static void N9_6() 
        {
            string text = Console.ReadLine();
            var splt = text.Split(':', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(splt[0].Length);
        }
        public static void N9_7() 
        {
            string text = Console.ReadLine();
            var splt = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splt.Length;i++)
                if (splt[i].Length == 3) Console.WriteLine(splt[i]);
        }
        public static void N9_8() 
        {
            string text = Console.ReadLine();
            
        }
        public static int NOD(int x, int y) 
        {
            if (x - y == 0) return x;
            return NOD(Math.Max(x,y)-Math.Min(x,y), Math.Min(x,y));
        }
        public static int[] ArrayInput() 
        {
            Console.WriteLine("Размер массива: ");
            int.TryParse(Console.ReadLine(), out int size);
            int [] array = new int[size];
            for (int i = 0; i < size; i++) 
                int.TryParse(Console.ReadLine(), out array[i]);
            return array;
        }
        public static int[] IntToArray (int x) 
        {
            int result = 0;
            for (int i = x; i >= 1;)
            {
                i /= 10;
                result++;
            }
            int[] ints = new int[result];
            for (int i = 0; i < result; i++)
            {
                ints[i] = x%10;
                x /= 10;
            }
            Array.Reverse(ints);
            return ints;
        }
        public static int ArrayToInt(int[] ints) 
        {
            int result = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                result *= 10;
                result += ints[i];
            }
            return result;
        }
        public static int Factorial (int a)
        {
            if (a == 1) return 1;
            return a * Factorial(a - 1);
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
