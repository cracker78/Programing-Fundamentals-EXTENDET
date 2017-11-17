namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Winecraft
    {
        static void Main()
        {

            int[] grapes = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int grapesCounter = 0;

            do
            {
                for (int i = 0; i < n; i++)
                {
                    GrapesLvlChange(grapes);
                }

                RemoveGrapesLowerOrEqual(n, grapes);

                grapesCounter = grapes.Where(g => g > n).ToArray().Length;

            }
            while (grapesCounter >= n);

            grapes = grapes.Where(g => g > n).ToArray();

            Console.WriteLine(string.Join(" ", grapes));

        }

        static void GrapesLvlChange(int[] grapes)
        {
            HashSet<int> lesserGrapesIndexes = new HashSet<int>();

            for (int i = 0; i < grapes.Length; i++)
            {
                bool isGreater = GreatGrape(i, grapes);


                if (isGreater)
                {
                    lesserGrapesIndexes.Add(i - 1);
                    lesserGrapesIndexes.Add(i + 1);
                }
            }
            StealGrapeFromLesserGrapes(grapes);

            LvlUpGrapesDifferendThenLessarGrape(grapes, lesserGrapesIndexes);

        }

        private static void StealGrapeFromLesserGrapes(int[] grapes)
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                bool isGreater = GreatGrape(i, grapes);

                if (isGreater)
                {
                    int first = grapes[i - 1];
                    int greater = grapes[i];
                    int last = grapes[i + 1];
                   
                    if (first > 0)
                    {
                        grapes[i - 1]--;
                        grapes[i]++;
                    }
                    if (last > 0)
                    {
                        grapes[i + 1]--;
                        grapes[i]++;
                    }
                }
            }
        }

        static void LvlUpGrapesDifferendThenLessarGrape(int[] grapes,
            HashSet<int> lesserGrapesIndexes)
        {
            for (int i = 0; i < grapes.Length; i++)
            {

                if (grapes[i] > 0 && !lesserGrapesIndexes.Contains(i))
                {
                    grapes[i]++;
                }
            }
        }

        static bool GreatGrape(int index, int[] grapes)
        {
            if (index > 0 && index < grapes.Length - 1)
            {
                return grapes[index - 1] < grapes[index] && grapes[index + 1] < grapes[index];
            }
            return false;

        }
        static void RemoveGrapesLowerOrEqual(int n, int[] grapes)
        {

            for (int i = 0; i < grapes.Length; i++)
            {
                if (grapes[i] < n)
                {
                    grapes[i] = 0;
                }
            }
        }
    }
}
