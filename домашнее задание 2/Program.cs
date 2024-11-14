using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        struct User
        {
            public string Name;
            public string Town;
            public int age;
            public string pin;
            public void person()
            {
                Console.WriteLine($"Name {Name} Town {Town} Age {age} pin cod {pin}");
            }
        }

        static void Main(string[] args)
        {
            /*1. Выведите на экран информацию о каждом типе данных в виде:
Тип данных – максимальное значение – минимальное значение
             */
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"char - {char.MaxValue} - {char.MinValue}");

            /*2. Напишите программу, в которой принимаются данные пользователя в виде имени,
города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
переменной, а затем распечатайте всю информацию в правильном формате.
             */
            User a = new User();
            Console.WriteLine("напишите имя");
            a.Name = Console.ReadLine();
            Console.WriteLine("напишите город");
            a.Town = Console.ReadLine();
            Console.WriteLine("напишите возраст");
            a.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("напишите пин код");
            a.pin = Console.ReadLine();
            string pincod = a.pin;
            int cod = pincod.Length;
            while (true)
            {
                if (cod == 4)
                {
                    a.person();
                    break;
                }
                else
                {
                    Console.WriteLine("в пин коде 4 цифры");
                    a.pin = Console.ReadLine();
                    pincod = a.pin;
                    cod = pincod.Length;

                }
            }


            /*3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
строчные.
             */
            Console.WriteLine("напишите текст");
            string text = Console.ReadLine(); //asdFGHJghjk
            string newtext = "";
            foreach (char el in text) // char el = 'F'
            {
                if (char.IsLower(el))
                {
                    newtext += char.ToUpper(el);
                }
                else
                {
                    newtext += char.ToLower(el); // newtext = "ASDf"
                }
            }
            Console.WriteLine(newtext);

            /*4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
на экран.
             */
            Console.Write("введите строку ");
            string text1 = Console.ReadLine();
            //char[] str = text1.ToCharArray();
            char[] str = text1.ToArray<char>();

            Console.Write("введите подстроку ");
            string understr = Console.ReadLine();
            int len = understr.Length;
            int k = 0;

            for (int i = 0; i <= (str.Length - len); i++)
            {
                if (string.Join("", str[i..(i + len)]) == understr) //обьединяет массивы и  считает 
                {
                    k++;
                }
            }
            Console.WriteLine(k);

            /*5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.
             */
            Console.WriteLine("напишите обычную цену");
            double normPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("скидка в дьюти фри");
            double salePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("стоимость отпуска");
            Double holidayPrice = Convert.ToDouble(Console.ReadLine());

            int economia = Convert.ToInt32(normPrice - (normPrice * (1 - (salePrice / 100))));
            if (economia != 0)
            {
                int count = Convert.ToInt32(holidayPrice / economia);
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("деление на 0 ");
            }


            /*6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
(процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
структуры: наименование типа напитка и процент спирта.
             */

        }
    }
}