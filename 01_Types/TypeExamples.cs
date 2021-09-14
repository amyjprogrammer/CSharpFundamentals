using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //Whole numbers
            byte oneBytesWorth;//declared the variable
            oneBytesWorth = 255;
            short smallWholeNumber = 16; //Int16
            int wholeNumber = 32; //Int32
            long largeWholeNumber = 64;  //Int64

            int newNumber = oneBytesWorth;

            //Decimals
            float floatExample = 1.23456f;
            double doubleExample = 12.34546;
            decimal decimalExample = 123.4567m; 

            char letter = 'A';//could be ?, 0 

            // Operators

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; //value would be 2
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
        }
        [TestMethod]
        public void ReferenceTypes()
        {
            //Strings
            string stringExample = "This is a string"; //declare and initialize at the same time
            string firstName = "Amy";

            string declared;
            declared = "Now it's initialized.";

            //Formatting strings
            string concatenate = stringExample + " " + firstName; //will be This is a string Amy
            string interpolate = $"{firstName}. Here is the string: {stringExample}.";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //Other object examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = now - randomDate;
            Console.WriteLine(waitTime);

            // Collections

            //Arrays
            string anotherExampleString = "Hellow World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15]; //must have a predetermined size

            Console.WriteLine(students);

            // Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>(); //first in first out
            firstInFirstOut.Enqueue("Luke"); //ended to the end of the queue

            //Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            // Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>(); //ordered Dictionary
            Stack<string> firstInLastOut = new Stack<string>(); // first in last out..opposite of Queue
        }
    }
}
