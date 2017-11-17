using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            string code = Console.ReadLine();
            string reason = Console.ReadLine();

            if (operation== "success")
            {
                ShowSuccess(operation, code);
            }
            else if(operation == "error")
            {
                ShowError(operation, code);
            }

        }
        static string ShowSuccess(string operation, string code)
        {
            Console.WriteLine($"Successfully executed {operation}");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {code}");
        }
        static string ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }
    }
}
