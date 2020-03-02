using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int simulation;
            int bankDifficulty;
            List<Heister> Heister = new List<Heister>();
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine(@"
                     ||====================================================================||
||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||
||(100)==================| FEDERAL RESERVE NOTE |================(100)||
||\\$//        ~         '------========--------'                \\$//||
||<< /        /$\              // ____ \\                         \ >>||
||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||
||<<|        \\ //           || <||  >\  ||                        |>>||
||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
||<<|      L38036133B        *\\  |\_/  //* series                 |>>||
||>>|  12                     *\\/___\_//*   1989                  |<<||
||<<\      Treasurer     ______/Franklin\________     Secretary 12 />>||
||//$\                 ~|UNITED STATES OF AMERICA|~               /$\\||
||(100)===================  ONE HUNDRED DOLLARS =================(100)||
||\\$//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\$//||
||====================================================================||
            ");
            Console.WriteLine();
            Console.WriteLine("Alright boys, how secure of a bank we hittin??");
            string bankDifficultyString = Console.ReadLine();
            try
            {
                bankDifficulty = int.Parse(bankDifficultyString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{bankDifficultyString} is not a number pal. I need a number that specifies how diffiicult this heist is gonna be. As punishment I'm settin the difficulty to one thousand. Haha try that!");
                bankDifficulty = 1000;
            }
            while (true)
            {
                Heister teamMember;
                Console.WriteLine("What's the guy's name? I'll have Big Eaze do a background check on em.");
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("ok pal, how many times do we run the simulation??");
                    string trialRunString = Console.ReadLine();
                    try
                    {
                        trialRuns = int.Parse(trialRunString);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{trialRunString} is not number pal. If you don't know I'll just run it once for now.");
                        trialRuns = 1;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("What is the team member's skill level?");
                    string skillLevelString = Console.ReadLine();
                    int skillLevel;
                    try
                    {
                        skillLevel = int.Parse(skillLevelString);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{skillLevelString} is not a number, so you're getting 5");
                        skillLevel = 5;
                    }

                    Console.WriteLine("How would you rate the team member's courage factor?");
                    string courageFactorString = Console.ReadLine();
                    decimal courageFactor;

                    try
                    {
                        courageFactor = decimal.Parse(courageFactorString);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"what's that? I didn't quite catch that. I don't think that was a valid number. I'm setting them to 1.0.");
                        courageFactor = 1.0M;
                    }
                }
            }
        }
    }
}
