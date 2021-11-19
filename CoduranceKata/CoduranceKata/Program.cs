/*
* File: Program.cs
* Author: Josh Hehir 
* Date: 19/11/2021
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoduranceKata
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           Message myMessage;
           myMessage = new Message("Hello World - from Message Object");
           myMessage.Print();
        }
    }
}