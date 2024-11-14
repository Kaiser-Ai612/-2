using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum acc
        {
            nowing,
            saving,
        }

        enum Vus
        {
            kgu,
            kai,
            khti,
        }
        struct Worker
        {
            public string Name1;
            public Vus uni;
            public void status()
            {
                Console.WriteLine($"имя :{Name1} вуз:{uni}");
            }
        }
        struct bank
        {
            public string number;
            public string tipe;
            public int balance;
            public bank(string number, string tipe, int balance) //нужно для быстрого вводв данных
            {
                this.number = number;
                this.tipe = tipe;
                this.balance = balance;
            }
            public void comannd()
            {
                Console.WriteLine($"номер счета :{number} тип счета: {tipe} баланс:{balance}");
            }

        }

        static void Main(string[] args)
        {
            /*Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского
счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
значение и вывести это значение на печать.
             */
            acc account = acc.nowing;
            Console.WriteLine($"вид банковского счета {account}");

            /*Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
значениями и напечатать результат.
             */
            bank accbank = new bank();
            accbank.number = "556926429562";
            accbank.tipe = "saving";
            accbank.balance = 6528746;
            accbank.comannd();

            /*Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
распечатать.
             */
            Worker work = new Worker();
            work.Name1 = "Dasha";
            work.uni = Vus.kgu;
            work.status();


        }
    }
}