using System;
using System.Collections.Generic;

namespace _6_Collections1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool canExitApp = true;
            string userInput;
            string meaningText = "Изподвыподверта - это проверка на состояние алкогольного опьянения.";
            string text = "Изподвыподверта";
            List<string> words = new List<string>();
            words.Add(text);

            while (canExitApp)
            {
                Console.Write("Введите слово: ");
                userInput = Console.ReadLine();

                if (userInput == text)
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        Console.WriteLine(meaningText);
                        canExitApp = false;
                    }
                }
                else
                {
                    Console.WriteLine("Такого слова нет в программе. Попробуйте ещё раз.");
                }
            }
        }
    }
} 
