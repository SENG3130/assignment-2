// File Name:   StringInputter.cs
// Developer:   Mitchell Davis
//
// Description: Reads the input from the arguments, and appends to the linkedlist output.
//
// Notes:       Concatenates each line of the file with an end of line delimiter ( /).

using System;
using System.Collections.Generic;

namespace CDT.Core
{
    class StringInputter : Inputter
    {
        private string[] input;

        public StringInputter(string[] args)
        {
            input = args;
        }

        public LinkedList<string> Input()
        {
#if DEBUG
            Console.WriteLine(DateTime.Now + " StringInputter.Input started");
#endif

            LinkedList<string> output = new LinkedList<string>();

            foreach (String item in input)
            {
                output.AddLast(item + " /");
            }

#if DEBUG
            Console.WriteLine(DateTime.Now + " StringInputter.Input finished");
#endif

            return output;
        }
    }
}
