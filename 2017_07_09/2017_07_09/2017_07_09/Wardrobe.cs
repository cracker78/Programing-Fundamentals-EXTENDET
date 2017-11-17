using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2017_07_09
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe=new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < cnt; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];
                string[] clotes = input[1].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }


                for (int j = 0; j < clotes.Length; j++)
                {
                    Dictionary<string, int> aaa=new Dictionary<string, int>();

                    string clo = clotes[j];

                    if (!wardrobe[color].ContainsKey(clo))
                    {
                        wardrobe[color].Add(clo, 0);                        
                    }
                    if (wardrobe[color].ContainsKey(clo))
                    {
                        wardrobe[color][clo]++;
                    }
                }

            }

            string[] search = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            foreach (var proba in wardrobe)
            {
                Console.WriteLine(proba.Key + " clothes:");
                Dictionary<string, int> neshto = proba.Value;
                foreach (var result in neshto)
                {

                    if (result.Key==search[1] && proba.Key==search[0])
                    {
                        Console.WriteLine("* " + result.Key + " - " + result.Value + " (found!)");
                    }
                    else
                    {
                        Console.WriteLine("* " + result.Key + " - " + result.Value);
                    }
                    
                }

            }

        }
        
    }
}
