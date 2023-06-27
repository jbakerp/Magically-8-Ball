using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_8_Ball
{
    public class Response
    {
        public void Answer()
        {
            Random r = new Random();
            int keyNumber = r.Next(1, 22);
            
                Dictionary<int, string> affirmativeResponsesSetOne = new Dictionary<int, string>();
                affirmativeResponsesSetOne.Add(1, "It is certain.");
                affirmativeResponsesSetOne.Add(2, "It is decidedly so.");
                affirmativeResponsesSetOne.Add(3, "Without a doubt.");
                affirmativeResponsesSetOne.Add(4, "Yes definitely.");
                affirmativeResponsesSetOne.Add(5, "You may rely on it.");

                Dictionary<int, string> AffirmativeResponsesSetTwo = new Dictionary<int, string>();
                AffirmativeResponsesSetTwo.Add(6, "As I see it, yes.");
                AffirmativeResponsesSetTwo.Add(7, "Most likely.");
                AffirmativeResponsesSetTwo.Add(8, "Outlook good.");
                AffirmativeResponsesSetTwo.Add(9, "Yes.");
                AffirmativeResponsesSetTwo.Add(10, "Signs point to yes.");

                Dictionary<int, string> AffirmativeResponsesSetThree = new Dictionary<int, string>();
                AffirmativeResponsesSetThree.Add(11, "Reply hazy, try again.");
                AffirmativeResponsesSetThree.Add(12, "Ask again later.");
                AffirmativeResponsesSetThree.Add(13, "Better not tell you now.");
                AffirmativeResponsesSetThree.Add(14, "Cannot predict now.");
                AffirmativeResponsesSetThree.Add(15, "Concentrate and ask again.");
                AffirmativeResponsesSetTwo.Add(16, "I guess so...maybe on the right day");

                Dictionary<int, string> AffirmativeResponsesSetFour = new Dictionary<int, string>();
                AffirmativeResponsesSetFour.Add(17, "Don't count on it.");
                AffirmativeResponsesSetFour.Add(18, "My reply is no.");
                AffirmativeResponsesSetFour.Add(19, "My sources say no.");
                AffirmativeResponsesSetFour.Add(20, "Outlook not so good.");
                AffirmativeResponsesSetFour.Add(21, "Very doubtful.");
                AffirmativeResponsesSetFour.Add(22, "LOL no");

            if (keyNumber < 5)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(affirmativeResponsesSetOne[keyNumber]);
                Console.ResetColor();
            }
            if (keyNumber > 5 && keyNumber <= 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(AffirmativeResponsesSetTwo[keyNumber]);
                Console.ResetColor();
            }
            if (keyNumber >= 11 && keyNumber <= 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(AffirmativeResponsesSetThree[keyNumber]);
                Console.ResetColor();
            }
            if (keyNumber <= 22 && keyNumber >= 17)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(AffirmativeResponsesSetFour[keyNumber]);
                Console.ResetColor();
            }

        }

    }
}
