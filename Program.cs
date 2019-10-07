using System;
using System.Collections.Generic;
using System.Linq;

namespace special_keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = "pqrstuvwxyzabcdefghijklmno";

                Console.WriteLine(input.Length);

                string output = "leetcode";                
                
                /*
                if (output.Length > 1 && output.Length < 10)
                {
                    Console.WriteLine(output.Length);
                }
                */

                if (output.All(char.IsLetter))
                {
                    Console.WriteLine("Output has only letters");
                }
                if (output.Any(char.IsDigit))
                {
                    Console.WriteLine("Output has digits");
                }
                if (output.Any(char.IsUpper))
                {
                    Console.WriteLine("Output has upper case letters");
                }


                Dictionary<char, int> input_dict = new Dictionary<char, int>();

                int char_value = 0;

                foreach (char c in input)
                {
                    input_dict.Add(c, char_value++);
                }

                foreach (var item in input_dict)
                {
                    Console.Write(item.Key + " " + item.Value + " ");
                }

                int time = 0;
                int prev_char_value = 0;

                foreach (char c in output)
                {
                    //Console.WriteLine(c);
                    if (input_dict[c] > prev_char_value)
                    {
                        time = time + (input_dict[c] - prev_char_value);
                    }
                    else if (input_dict[c] < prev_char_value)
                    {
                        time = time + (prev_char_value - input_dict[c]);
                    }
                    else { }
                    prev_char_value = input_dict[c];
                }

                Console.WriteLine("");
                Console.WriteLine(time);


            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");

            }   // End of catch
        }
    }
}
