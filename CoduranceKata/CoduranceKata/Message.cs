/*
* File: Message.cs
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
    public class Message
    {
        private string text;
        public Message(string text)
        {
            this.text = text;
        }

        public void Print()
        {
            Console.WriteLine(text);
        }
    }
}
