using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;

namespace Тумаков
{
    enum Bank
    {
        текущий,
        сберегательный
    }
    
        internal class Program
    {
        static void Examination(object obj)
        {
            IFormattable formattable = obj as IFormattable;
            if (formattable != null )
            {
                Console.WriteLine("возможно сформатировать с данным типом данных");
            }
            else
            {
                Console.WriteLine("невозможно сформатировать с данным типом данных");
            }
        }
        static void SearchMail(ref string s)
        {
            string[] email = s.Split('#');
            s = email[1];
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 8.1");
            Console.WriteLine("Данная программа позволяет положить или снять деньги со счёта");
            Bank_account bank = new Bank_account();
            Random random = new Random();
            bank.Set(10000);
            Console.WriteLine($"\nНа вашем {Bank.текущий} счёте {bank.Set(10000)} рублей");
            int rand = random.Next(0, 100000);
            bank.PrintBalance();
            Console.WriteLine("\nВыберите операцию: снять или положить средства");
            string operation = Console.ReadLine();
            operation = operation.ToLower();
            Console.WriteLine("Напишите сумму");
            bool flag = uint.TryParse(Console.ReadLine(), out uint balance);
            if (flag)
            {
                bank.SetBalance(operation, balance);
                Console.WriteLine($"Ваш баланс: {bank.PrintBalance()} рублей");
            }
            else
            {
                Console.WriteLine("Нельзя водить символы, буквы или отрицательный числа");
            }
            bank.SetNumber(rand);
            int number2 = bank.PrintNumber();
            Console.WriteLine($"Номер карты: {number2}");
            bank.Type = Bank.текущий;
            Bank type = bank.Type;
            bank.Type = Bank.сберегательный;
            Bank type1 = bank.Type;
            Console.WriteLine($"Тип банковского счёта: {type}");
            Console.WriteLine();
            uint balance_current = bank.PrintBalance();
            uint balance_savings = bank.Set(10000);
            Console.WriteLine($"на вашем {type} счете: {balance_current} рублей");
            Console.WriteLine($"на вашем {type1} счете: {balance_savings} рублей");
            Console.WriteLine("Напишите операцию для перевода денег");
            Console.WriteLine("Для того чтобы положить деньги с текущего на сберегательный счёт, нажмите 0");
            Console.WriteLine("Для того чтобы положить деньги с собирательного на текущий счёт, нажмите 1");
            bool flag1 = Bank.TryParse(Console.ReadLine(),out Bank type2);
            if (flag1)
            {
                if (type2 == Bank.текущий)
                {
                    bank.Transfer(type2, balance_current, balance_savings);
                }
                else if (type2 == Bank.сберегательный)
                {
                    bank.Transfer(type2, balance_current, balance_savings);
                }
                else
                {
                    Console.WriteLine("Такой операции нет");
                }
            }
            else
            {
                Console.WriteLine("Нельзя водить символы, буквы или отрицательный числа");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("Данная программа записывает буквы в обратном порядке");
            Console.Write($"Напишите текст: ");
            string text = Console.ReadLine();
            Text_count text1 = new Text_count();
            Console.WriteLine(text1.Text1(text));
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 8.3");
            Console.WriteLine("Работа с файлами");
            string outputFile = "outText.txt";
            Console.Write("Введите название входного файла: ");
            string inputFile = Console.ReadLine();

            if (File.Exists(inputFile))
            {
                File.WriteAllText(outputFile, File.ReadAllText(inputFile).ToUpper());
                Console.WriteLine($"Текст записан в файл: {outputFile}");
            }
            else
            {
                Console.WriteLine($"Такого файла нет");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 8.4");
            Console.WriteLine("Метод, который проверяет реализует ли входной параметр метода интерфейс");
            Console.Write("\nНапишите, какой тип данных в хотите выбрать: целочисленный или строка: ");
            string text2 = Console.ReadLine();
            text2 = text2.ToLower();
            switch (text2)
            {
                case "целочисленный":
                    object obj = 50;
                    Examination(obj);
                    break;
                case "строка":
                    object obj1 = "привет";
                    Examination(obj1);
                    break;
                default:
                    Console.WriteLine("Вы ничего не выбрали");
                    break;
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Домашнее задание 8.1");
            Console.WriteLine("Работа со строками. ФИО и email");
            string s;
            StreamReader fail = new StreamReader("ФИО+email.txt");
            while ((s = fail.ReadLine()) != null)
            {
                SearchMail(ref s);
                using (var writer = new StreamWriter("email.txt", true))
                {
                    writer.WriteLine(s);
                }
            }
            Console.WriteLine("Текст перенесен");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            
            Console.WriteLine("Домашнее задание 8.2");
            Console.WriteLine("Программа с песнями");
            Song song_1 = new Song();
            Song song_2 = new Song();
            Song song_3 = new Song();
            Song song_4 = new Song();
            Song[] songs = { song_1, song_2, song_3, song_4};
            for (int i = 0; i < songs.Length; i++)
            {
                songs[i].FillingName();
                songs[i].FillingAuthor();
                if (i != 0)
                {
                    songs[i].prev = songs[i - 1];
                }
                songs[i].Title();
                if (i != 0)
                {
                    switch (i)
                    {
                        case 1:
                            string num_1 = "первая";
                            string num_2 = "вторая";
                            if (songs[i].Equals(songs[i - 1]))
                            {
                                Console.WriteLine($"{num_1} и {num_2} это одинаковые песни");
                            }
                            else
                            {
                                Console.WriteLine($"{num_1} и {num_2} это разные песни");
                            }
                            break;
                        case 2:
                            string num2 = "вторая";
                            string num3 = "третья";
                            if (songs[i].Equals(songs[i - 1]))
                            {
                                Console.WriteLine($"{num2} и {num3} это одинаковые песни");
                            }
                            else
                            {
                                Console.WriteLine($"{num2} и {num3} это разные песни");
                            }
                            break;
                        case 3:
                            string num_3 = "третья";
                            string num_4 = "четверная";
                            if (songs[i].Equals(songs[i - 1]))
                            {
                                Console.WriteLine($"{num_3} и {num_4} это одинаковые песни");
                            }
                            else
                            {
                                Console.WriteLine($"{num_3} и {num_4} это разные песни");
                            }
                            break;
                        default:
                            continue;
                    }
                }
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            


            





        }
    }
}
