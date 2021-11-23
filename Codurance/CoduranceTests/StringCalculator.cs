using System;

namespace CoduranceTests
{
    internal class StringCalculator
    { 
        public StringCalculator()
        {

        }

        public int Add(string input)
        {
            int total = 0;
            string comma = ",";
            
            if (string.IsNullOrEmpty(input))
           
                return 0;

            string[] numbers = input.Split(comma);


            foreach (string number in numbers)
            {
                total += int.Parse(number);
            }
            return (total);
        }
    }
}