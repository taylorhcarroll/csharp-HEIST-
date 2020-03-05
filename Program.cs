using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int simulation;
            int totalRuns;
            int percentage;
            int bankDifficulty;
            Console.BackgroundColor = ConsoleColor.Black;
            List<Dictionary<string, string>> Crew = new List<Dictionary<string, string>>();
            Console.ForegroundColor = ConsoleColor.Green;
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
||<<\      Treasurer     ________/HEIST\_________     Secretary 12 />>||
||//$\                ~| TEXTUAL ESPIONAGE ACTION |~              /$\\||
||(100)=================  HIDDEN IN PLAIN SIGHT  ================(100)||
||\\$//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\$//||
||====================================================================||
            ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Plan Your...");
            Console.WriteLine(@"
 __  __     ______     __     ______     ______
/\ \_\ \   /\  ___\   /\ \   /\  ___\   /\__  _\
\ \  __ \  \ \  __\   \ \ \  \ \___  \  \/_/\ \/
 \ \_\ \_\  \ \_____\  \ \_\  \/\_____\    \ \_\
  \/_/\/_/   \/_____/   \/_/   \/_____/     \/_/
                                                    ");
            Console.WriteLine("Alright people, how secure of a bank we hittin??");
            Console.ForegroundColor = ConsoleColor.White;
            string bankDifficultyString = Console.ReadLine();
            bankDifficulty = int.Parse(bankDifficultyString);

            while (true)
            {
                Dictionary<string, string> teamMember = new Dictionary<string, string>();
                Console.WriteLine("Alright, what's their name? I'll have Big Eaze do a background check on em.");
                Console.WriteLine("I'll keep adding them to the list as long as you keep talking.");
                string name = Console.ReadLine();
                teamMember.Add("Name", name);
                if (name == "")
                {
                    Console.WriteLine("ok pal, how many times do we run the simulation??");
                    string simulationString = Console.ReadLine();
                    simulation = int.Parse(simulationString);
                    totalRuns = int.Parse(simulationString);
                    break;
                }
                else
                {
                    // int skillLevel;
                    // while (true)
                    {
                        Console.WriteLine($"What is {name}'s skill level?");
                        string skillLevelString = Console.ReadLine();
                        teamMember.Add("SkillLevel", skillLevelString);
                    }

                    Console.WriteLine($"How would you rate {name}'s courage factor?");
                    string courageFactorString = Console.ReadLine();
                    teamMember.Add("CourageFactor", courageFactorString);
                    foreach (KeyValuePair<string, string> attribute in teamMember)
                    {
                        Console.WriteLine($"{attribute.Key} is {attribute.Value}");

                    };
                    Crew.Add(teamMember);
                }
            }
            int success = 0;
            int failure = 0;
            Console.WriteLine($"Alright, you've assembled a crew of {Crew.Count} people.");
            int teamSkill = 0;
            foreach (var member in Crew)
            {
                Console.WriteLine($"Name:{member["Name"]} Skill Level: {member["SkillLevel"]} Courage Factor: {member["CourageFactor"]}");
                int skillLVL = int.Parse(member["SkillLevel"]);
                teamSkill += skillLVL;
            }
            while (simulation > 0)
            {
                Random random = new Random();
                int luck = random.Next(-10, 10);

                bankDifficulty += luck;
                Console.WriteLine($"Your team has a collective skill level of {teamSkill}");
                Console.WriteLine($"We did some recent reconissance and found the Bank Difficulty, if we're lucky, is actually going to be about: {bankDifficulty}.");
                if (bankDifficulty > teamSkill)
                {
                    Console.WriteLine("FAILURE: Awww sorry mate, we ran the simulation and it looks like this heist ended in failure. Better luck next time eh?");
                    failure += 1;
                }
                else
                {
                    Console.WriteLine("SUCCESS: Hahah VERY GOOD, verrrry good. This is looking like this will be a successful job.");
                    success += 1;
                }
                simulation -= 1;
            }
            Console.WriteLine($"During this round of simulations, we found {success} successful bank robberieis and {failure} failures.");
            percentage = (success / totalRuns) * 100;
            Console.WriteLine($"You're looking at a {percentage} % success rating.");
        }
    }
}