using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primeList = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                primeList = RemoveAllOccurrenses(primeList);

            }
            primeList.Sort();

            Console.WriteLine(string.Join(" ", primeList));
        }

        static List<int> RemoveAllOccurrenses(List<int> primeList)
        {
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            for (int p = 0; p < secondList.Count; p++)
            {
                if (primeList.Contains(secondList[p]))
                {
                    primeList.Remove(secondList[p]);
                }
                else
                {
                    primeList.Add(secondList[p]);
                }
            }

            return primeList;
        }
    }
}
