using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadToGitHub
{
    internal class Program
    {

        public static void SearchBook(string bookName)
        {
            // Simulate searching for a book
            Thread.Sleep(2000);
            Console.WriteLine($"Book '{bookName}' found in the library.");
        }

        public static void UpdatLoanStatus(string memberId)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Loan status updated for member '{memberId}'.");
        }

        public static void ProcesssRequest()
        {
            Thread searchThread = new Thread(() => SearchBook("C# Programming"));
            Thread updateThread = new Thread(() => UpdatLoanStatus("m12345"));

            searchThread.Start();
            updateThread.Start();

            searchThread.Join();
            updateThread.Join();   
        }
        static void Main(string[] args)
        {

            ProcesssRequest();
            Console.ReadKey();
        }
    }
}
