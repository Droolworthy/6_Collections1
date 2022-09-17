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
            string meaningWord = "Изподвыподверта - это проверка на состояние алкогольного опьянения.";
            string stopProgram = "Изподвыподверта";
            List<string> words = new List<string>();
            words.Add(stopProgram);

            while (canExitApp)
            {
                Console.Write("Введите слово: ");
                userInput = Console.ReadLine();

                if (userInput == stopProgram)

                    for (int i = 0; i < words.Count; i++)
                    {
                        Console.WriteLine(meaningWord);
                        canExitApp = false;
                    }
                else
                {
                    Console.WriteLine("Такого слова нет в программе. Попробуйте ещё раз.");
                }
            }
        }
    }
}