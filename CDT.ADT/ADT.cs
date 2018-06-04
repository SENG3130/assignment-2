// File Name:   ADT.cs
// Developer:   Brad Turner
//
// Description: Implements an abstract data type build of a standard KWIC indexing system.
//
// Notes: 

using System.Linq;
using CDT.Core;

namespace CDT.ADT
{
    class ADT
    {
        static void Main(string[] args)
        {
            Inputter input;

            // If there is no input specified, or there is a single argument, load the input from a file.
            if (args.Length <= 2)
            {
                input = new Inputter(args);
            }

            // Otherwise the input is specified as a string, with a prefix "string", so skip the first argument and load the rest.
            else
            {
                input = new StringInputter(args.Skip(1).ToArray());
            }

            Rotator rot = new Rotator();
            Indexor idx = new Indexor();
            Outputter output = new Outputter(args);

            output.Output(idx.Index(rot.Rotate(input.Input())));
            //disadvantage have to know the signatures to all methods otherwise cant do this^.

        }
    }
}
