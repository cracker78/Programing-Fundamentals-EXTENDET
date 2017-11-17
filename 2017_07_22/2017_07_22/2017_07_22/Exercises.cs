using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2017_07_22
{
    class Exercises
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(input);

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        class Name
        {
            public string Topic {
                get { return }; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public string Problems { get; set; }
        }
    }
}


