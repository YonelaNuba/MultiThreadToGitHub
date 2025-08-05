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
            //Simulates the Update status
            Thread.Sleep(1000);
            Console.WriteLine($"Loan status updated for member '{memberId}'.");
        }

        // This method processes the request by starting two threads: one for searching a book and another for updating loan status.
        public static void ProcesssRequest()
        {
            Thread searchThread = new Thread(() => SearchBook("C# Programming"));
            Thread updateThread = new Thread(() => UpdatLoanStatus("m12345"));

            //Start the threads
            searchThread.Start();
            updateThread.Start();

            //Join the threads
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
