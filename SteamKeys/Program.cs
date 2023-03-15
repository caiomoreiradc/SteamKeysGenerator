using System;
using System.IO;

namespace SteamKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int keyLength = 15;

            Console.WriteLine("Generate Steam Keys!!!!");
            Console.WriteLine();

            Console.WriteLine("How many Keys do you want to generate? ");
            int qtdKeys = int.Parse(Console.ReadLine());

            // Nome do arquivo onde as keys serão salvas
            string fileName = "steamkeys.txt";

            // Cria um StreamWriter para o arquivo de saída
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < qtdKeys; i++)
                {
                    char[] keyChars = new char[keyLength];

                    for (int j = 0; j < keyLength; j++)
                    {
                        keyChars[j] = chars[random.Next(chars.Length)];
                    }

                    string key = new string(keyChars);
                    string formattedKey = string.Format("{0}-{1}-{2}", key.Substring(0, 5), key.Substring(5, 5), key.Substring(10, 5));

                    // Escreve a chave formatada no arquivo de saída
                    writer.WriteLine(formattedKey);
                }
            }

            Console.WriteLine("Keys saved to file: " + fileName);
        }
    }
}
