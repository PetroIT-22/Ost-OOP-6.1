using System;

namespace Ost_OOP_6._1
{
    interface IBank
    {
        void Gram(int n, Bank[] b);
    }
    public class Bank:IBank
    {
        public DateTime data;
        public string name;
        public string LastName;
        public string number;
        public float input;
        public float output;
        public float GetCash;
        public float OutCash;
        public float Cash;
        public Bank(DateTime data, string name, string LastName, string number, float input, float output, float GetCash, float OutCash, float Cash)
        {
            this.data = data;
            this.name = name;
            this.LastName = LastName;
            this.number = number;
            this.input = input;
            this.output = output;
            this.GetCash = GetCash;
            this.OutCash = OutCash;
            this.Cash = Cash;
        }
        public void Gram(int n,Bank[]b)
        {
            Console.Write("Граничне значення: ");
            float z = float.Parse(Console.ReadLine());
            Console.WriteLine("\n*********\nКлієнти банку, які на протязі заданого періоду часу виконали безготівкове переведення на загальну суму, яка перевищує задане користувачем граничне значення");
            Console.WriteLine("{0,-5} {1, -30} {2, -10} {3, -20} {4, -15} {5,-30} {6,-40}{7,-20}{8,-20}{9,-20}", "№", "Дата", "Ім'я", "прізвище", "№ рахунку", "сума безготівкового отримання", "сума безготівкового переведення", "отримано готівкою", "видано готівкою", "залишок вкладу");
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (b[i].output > z)
                {
                    m = i + 1;
                    Console.WriteLine("{0,-5} {1, -30} {2, -10} {3, -20} {4, -15} {5,-40} {6,-30}{7,-30}{8,-10}{9,-15}", m, b[i].data, b[i].name, b[i].LastName, b[i].number, b[i].input, b[i].output, b[i].GetCash, b[i].OutCash, b[i].Cash);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введіть кількість клієнтів: ");
            int n = int.Parse(Console.ReadLine());
            Bank[] b = new Bank[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Клієнт №" + (i + 1));
                Console.Write("дата проведення операції: ");
                DateTime data = new DateTime(2020, 12, 12);
                Console.WriteLine(data.ToString());
                Console.Write("Iм’я: ");
                string name = Console.ReadLine();
                Console.Write("прізвище: ");
                string LastName = Console.ReadLine();
                Console.Write("№ рахунку: ");
                string number = Console.ReadLine();
                Console.Write("сума безготівкового отримання: ");
                float input = float.Parse(Console.ReadLine());
                Console.Write("сума безготівкового переведення: ");
                float output = float.Parse(Console.ReadLine());
                Console.Write("отримано готівкою: ");
                float GetCash = float.Parse(Console.ReadLine());
                Console.Write("видано готівкою: ");
                float OutCash = float.Parse(Console.ReadLine());
                Console.Write("залишок вкладу: ");
                float Cash = float.Parse(Console.ReadLine());

                b[i] = new Bank(data, name, LastName, number, input, output, GetCash, OutCash, Cash);

            }

            b[0] = Gram(n, b);


        }
    }
}



