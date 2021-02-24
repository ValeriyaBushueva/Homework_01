using System;

namespace Homework_1
{
    // Бушуева Валерия
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            #region Task1
            // Написать программу «Анкета», выполнены пункты 1а, 1б, 1в
            
            Console.Title = "Программа 1. Анкета. ";

            
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите ваш рост: ");
            int growth = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите ваш вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            
            // Выводится, использую склеивание (1а)
            Console.WriteLine( "Ваше имя и фамилия:  "+ name + " " +
                               surname + " Ваш возраст: " + age + " Ваш рост: " + growth+ " Ваш вес: " + weight);
            
            // Выводится, используя форматированный вывод (1б)
            Console.WriteLine(" {0}. {1}, {2}, {3}, {4}", name, surname, age, growth, weight);
            // Выводится, используя вывод со знаком $
            Console.WriteLine($"{name} , {surname} , {age}  , {growth} , {weight}");
            Console.ReadLine();
            
            Console.Clear();
            #endregion
            
            #region Task2
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
            
            Console.Title = "Программа 2. Рассчет индекса массы тела. ";
            
            double mass;
            double hight;
            
            Console.WriteLine("Введите ваш вес: ");
            mass = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите ваш рост: ");
            hight = Convert.ToDouble(Console.ReadLine());
            double i = mass / (hight * hight);
            
            Console.WriteLine("Индекс массы вашего тела = " + i);
            
            Console.ReadLine();
            Console.Clear();
            
            #endregion
            
            #region Task3
            //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            Console.Title = "Программа 3. Рассчет расстояния между точками. ";

            // 3б  оформить вычисления расстояния между точками в виде метода;
            
            static double Calculate(double x1, double y1, double x2, double y2)
            {
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
            
            double x1 = 3.75;
            double y1 = 7.03;
            double x2 = 9.22;
            double y2 = 15.876;
           
            double calculate = Calculate(x1,y1,x2,y2);

      
            // 3а Вывести результат, используя спецификатор формата .2f 
            Console.WriteLine("{0:F} расстояние между точками", calculate);
            Console.ReadLine();
            
            #endregion
            
            #region Task4
            // Написать программу обмена значениями двух переменных

            Console.Title = " Программа 4. Обмен значениями двух переменных";
            
            // с использованием третьей переменной;
            int a = 5;
            int b = 10;
            
            int g = a;
            a = b;
            b = g;
            
            
         // без использования третьей переменной.
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    

            Console.ReadKey();

            #endregion
            
            #region Task5
            //  Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

            Console.Title = "Программа 5. Вывод в центр экрана своей фамилии, имя и города проживания";
          
            static void Print(string message, int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(message);
            }
            
            Print(message:"Бушуева Валерия, г. Минск", 15,10 );
            Console.ReadLine();

            Console.Clear();

            #endregion
        }

    }
    
    #region Task6
    // Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)
    public class CaseStudy
    {
        public static void Start()
        {
            Console.Title = "Программа 6. Cоздать класс с методами(Print, Pause). ";
            Print();
            Pause();
        }
        
        static void Pause()
        {
            Console.ReadLine();
        }
    
        static void Print()
        {
            Console.ReadLine();
        }
        
    }
    #endregion
    
}