//Создать программу, которая принимает от пользователя слово и выводит его значение. 
//Если такого слова нет, то следует вывести соответствующее сообщение.
using System;
using System.Collections.Generic;

namespace _6_Collections1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool canExitApp = true;
            string stopProgram = "exit";
            string userInput;
            string word = "Изподвыподверта";
            string meaningWord = "Это проверка на состояние алкогольного опьянения.";
            string nextWord = "Глюкокортикостеройды";
            string nextMeaningWord = "Группа физиологически активных веществ, регулирующих процессы жизнедеятельности у человека.";
            string lastWord = "Институционализация";
            string lastMeaningWord = "Процесс превращения каких-либо отношений в институты, с установленными правилами и нормами.";
            Dictionary<string, string> definition = new Dictionary<string, string>();
            definition.Add(word, meaningWord);
            definition.Add(nextWord, nextMeaningWord);
            definition.Add(lastWord, lastMeaningWord);

            Console.WriteLine($"Для выхода из словоря введите {stopProgram}");

            while (canExitApp)
            {   
                Console.Write("Ввод: ");
                userInput = Console.ReadLine();

                if (definition.ContainsKey(userInput))
                {
                    Console.WriteLine(definition[userInput]);
                }
                else if(userInput == stopProgram)
                {
                    canExitApp = false;
                }
                else
                {
                    Console.WriteLine($"Такого слова {userInput} нет в программе. Попробуйте ещё раз.");
                }
            }
        }
    }
}
