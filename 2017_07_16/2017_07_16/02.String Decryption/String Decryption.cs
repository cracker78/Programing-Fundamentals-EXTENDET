using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> inputTextToDecode = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            int skipedChars = inputNumbers[0];
            int correctChars = inputNumbers[1];



            int[] decryptedList=inputTextToDecode.Where(x=> x>64 && x<91)
                .Skip(skipedChars)
                .Take(correctChars)
                .ToArray();

            for (int i = 0; i < decryptedList.Length; i++)
            {
                Console.Write((char)decryptedList[i]);
            }
            Console.WriteLine();
        }
    }
}
