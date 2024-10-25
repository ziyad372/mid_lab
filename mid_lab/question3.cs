using System;
using System.Collections.Generic;

namespace mid_lab
{
    class question3
    {
        static void Main()
        {
            string initialState = "S0";
            string finalState = "S3";

            var fsm = new Dictionary<string, Dictionary<string, string>>
        {
            { "S0", new Dictionary<string, string> { {"Start", "S1"}, {"Stop", "S1"}, {"Accelerate", "S1"}, {"Right", "S1"}, {"Brake", "S1"} } },
            { "S1", new Dictionary<string, string> { {"Start", "S2"}, {"Stop", "S2"}, {"Accelerate", "S2"}, {"Right", "S2"}, {"Brake", "S2"} } },
            { "S2", new Dictionary<string, string> { {"Start", "S3"}, {"Stop", "S3"}, {"Accelerate", "S3"}, {"Right", "S3"}, {"Brake", "S3"} } },
            { "S3", new Dictionary<string, string> { {"Start", "S3"}, {"Stop", "S3"}, {"Accelerate", "S3"}, {"Right", "S3"}, {"Brake", "S3"} } }
        };

            Console.WriteLine("Enter commands separated by spaces (e.g., Start Accelerate Right Stop): ");
            string input = Console.ReadLine();

            string[] commands = input.Split(' ');
            string state = initialState;

            foreach (var command in commands)
            {
                if (fsm[state].ContainsKey(command) && command != "Left")
                {
                    state = fsm[state][command];
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid Command or Unsupported 'Left' Command");
                    return;
                }
            }

            if (state == finalState)
            {
                Console.WriteLine("RESULT OKAY");
            }
            else
            {
                Console.WriteLine("ERROR: Sequence did not reach the final state");
            }
        }
    }
}