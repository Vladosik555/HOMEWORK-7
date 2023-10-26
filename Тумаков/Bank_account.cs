using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Bank_account//упражнение 8.1 (перевод с одного счёта на другой)
    {
        private static int number;
        public void SetNumber(int number_1)
        {
            Bank_account.number = number_1;
        }
        public int PrintNumber()
        {
            return number++;
        }

        private static uint balance;
        public uint Set(uint balance1)
        {
            Bank_account.balance = balance1;
            return balance;
        }
        public void SetBalance(string operation, uint value)
        {
            switch (operation)
            {
                case "положить":
                    Bank_account.balance += value;
                    break;
                case "снять":
                    if (value > balance)
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    else
                    {
                        balance -= value;
                    }
                    break;
                default:
                    Console.WriteLine("Такой операция нет");
                    break;
            }
        }
        public uint SetBalan(int balance_1)
        {
            Bank_account.number = balance_1;
            return balance;
        }
        public uint PrintBalance()
        {
            return balance;
        }


        private static uint balance1;
        public uint Set1(uint balance2)
        {
            Bank_account.balance1 = balance2;
            return balance1;
        }
        public uint PrintBalance1()
        {
            return balance1;
        }

        public string Transfer(Bank type, uint balance_curr, uint balance_savin)
        {
            if (type == Bank.текущий)
            {
                Console.Write("Напишите сумму, которую хотите перевести с текущего на сберегательный: ");
                bool flag = uint.TryParse(Console.ReadLine(), out uint sum);
                if (flag)
                {
                    if (sum <= balance_curr)
                    {
                        uint sum_1 = balance_curr - sum;
                        balance_savin += sum;
                        string count = $"Баланс на текущем счёте: {sum_1} рублей, баланс на сберегательном счёте {balance_savin} рублей";
                        Console.WriteLine(count);
                        return "";
                    }
                    else
                    {
                        Console.WriteLine("Нельзя переводить сумму, который превышает ваш баланс");
                    }
                }
                else
                {
                    Console.WriteLine("Нельзя водить символы, буквы или отрицательный числа");
                }
            }
            else
            {
                Console.Write("Напишите сумму, которую хотите перевести с сберегательного счёта на текущий: ");
                bool flag1 = uint.TryParse(Console.ReadLine(), out uint sum1);
                if (flag1)
                {
                    if (sum1 <= balance_savin)
                    {
                        uint sum_2 = balance_savin - sum1;
                        balance_curr += sum1;
                        string count1 = $"Баланс на текущем счёте: {balance_curr} рублей, баланс на сберегательном счёте {sum_2} рублей";
                        Console.WriteLine(count1);
                        return "";

                    }
                    else
                    {
                        Console.WriteLine("Нельзя переводить сумму, который превышает ваш баланс");
                    }
                }
                else
                {
                    Console.WriteLine("Нельзя водить символы, буквы или отрицательный числа");
                }
            }
            return "";
        }

        public uint Balance { get { return balance; } set { balance = value; } }

        private Bank type;
        public Bank Type { get { return type; } set { type = value; } }
    }
}
