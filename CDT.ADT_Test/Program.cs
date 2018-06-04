// File Name:   Program.cs
// Developer:   Mitchell Davis
//
// Description: Generates random strings to pass to the ADT project, and records whether the system crashes for each string.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using CDT.Core;

namespace CDT.ADT_Test
{
    class Program
    {
        private static Random random;

        static void Main(string[] args)
        {
            random = new Random();

            int iterations = 100;
            string alphabet = "!#$%&‘()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";

            switch (args.Length)
            {
                case 1:
                    {
                        iterations = Int32.Parse(args[0]);

                        break;
                    }

                case 2:
                    {
                        iterations = Int32.Parse(args[0]);
                        alphabet = args[1];

                        break;
                    }
            }

            Console.WriteLine(DateTime.Now + " Starting " + iterations + " iterations with alphabet: " + alphabet);

            List<String> output = new List<string>();

            for (int i = 0; i < iterations; i++)
            {
                string[] input = GenerateRandomStrings(alphabet);

                int exitCode = RunAndReturnExitCode(input);
                
                output.Add("Crashed: " + ((exitCode != 0) ? ("Yes") : ("No ")) + " Input: " + String.Join(" ", input));
            }

            Outputter outputter = new Outputter();

            outputter.Output(output);

            Console.WriteLine(DateTime.Now + " Finished " + iterations + " iterations.");
        }

        static string[] GenerateRandomStrings(string alphabet)
        {
            return GenerateRandomStrings(alphabet, random.Next(2, 10));
        }

        static string[] GenerateRandomStrings(string alphabet, int stringCount)
        {
            return GenerateRandomStrings(alphabet, random.Next(1, 5), random.Next(2, 10));
        }

        static string[] GenerateRandomStrings(string alphabet, int stringCount, int wordCount)
        {
            string[] strings = new string[stringCount];

            for (int i = 0; i < stringCount; i++)
            {
                strings[i] = "\"" + GenerateRandomString(alphabet, wordCount) + "\"";
            }

            return strings;
        }

        static string GenerateRandomString(string alphabet)
        {
            return GenerateRandomString(alphabet, random.Next(2, 10));
        }

        static string GenerateRandomString(string alphabet, int wordCount)
        {
            string[] words = new string[wordCount];

            for(int i = 0; i < wordCount; i++)
            {
                int wordLength = random.Next(3, 10);
                string word = "";

                for(int j = 0; j < wordLength; j++)
                {
                    char c = alphabet[random.Next(alphabet.Length)];

                    word += c;
                }

                words[i] = word;
            }

            return String.Join(" ", words);
        }

        static int RunAndReturnExitCode(string[] input)
        {
            Process process = new Process();

#if DEBUG
            process.StartInfo.FileName = Path.GetFullPath("../../../CDT.ADT/bin/Debug/CDT.ADT.exe");
#else
            process.StartInfo.FileName = Path.GetFullPath("../../../CDT.ADT/bin/Release/CDT.ADT.exe");
#endif
            process.StartInfo.Arguments = "fakeinput fakeoutput " + String.Join(" ", input);
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();

            return process.ExitCode;
        }
    }
}
