using System;

namespace Lab8_GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            int userStudentChoice;
            string userInfoChoice, studentName, userInput;
            bool continueLearning = true;
            bool invalidInput = true;

            string[,] students = new string[11,3];
            students[0, 0] = "Bobby Bizon";
            students[0, 1] = "Mexican Food";
            students[0, 2] = "Westland, MI";

            students[1, 0] = "Nick Hickman";
            students[1, 1] = "Steak";
            students[1, 2] = "Livonia, MI";

            students[2, 0] = "Lauren Jensen";
            students[2, 1] = "Pizza";
            students[2, 2] = "Inkster, MI";

            students[3, 0] = "Sonic The Hedgehog";
            students[3, 1] = "Chili dogs";
            students[3, 2] = "Green Emerald Zone";

            students[4, 0] = "Mario Brother";
            students[4, 1] = "Mushrooms";
            students[4, 2] = "World 01 Stage 01";

            students[5, 0] = "Hannibal Lecter";
            students[5, 1] = "People";
            students[5, 2] = "Lithuania";

            students[6, 0] = "Jason Voorhees";
            students[6, 1] = "Bugs";
            students[6, 2] = "Camp Crystal Lake";

            students[7, 0] = "Freddy Krueger";
            students[7, 1] = "Dreams";
            students[7, 2] = "Springwood, OH";

            students[8, 0] = "Leatherface";
            students[8, 1] = "People";
            students[8, 2] = "Texas";

            students[9, 0] = "Pinhead";
            students[9, 1] = "Souls";
            students[9, 2] = "Somewhere far away";

            students[10, 0] = "Stephen Jedlicki";
            students[10, 1] = "Wagyu";
            students[10, 2] = "Inkster, MI";

            //while (continueLearning)
            //{
            //    Console.Write("Welcome to our C# class. Which student would you like to learn about? (enter a number 1-11 or the students name): ");
            //    userStudentChoice = int.Parse(Console.ReadLine()) - 1;

            //    studentName = students[userStudentChoice, 0];

            //    Console.Write($"Student {userStudentChoice + 1} is {studentName}. What would you like to know about {studentName.Split()[0]} (enter \"hometown\" or \"favorite food\"): ");
            //    userInfoChoice = Console.ReadLine();

            //    if (userInfoChoice.Trim().ToLower() == "hometown")
            //    {
            //        Console.Write($"{studentName.Split()[0]} is from {students[userStudentChoice, 2].ToString()}. Would you like to know more? (enter \"yes\" or \"no\"): ");
            //        userInput = Console.ReadLine().Trim().ToLower();
            //        if (userInput == "no")
            //        {
            //            continueLearning = false;
            //        }
            //        else if (!(userInput == "yes"))
            //        {
            //            do
            //            {
            //                Console.Write("Please enter \"yes\" or \"no\": ");
            //                userInput = Console.ReadLine().Trim().ToLower();
            //                if (!(userInput == "yes" || userInput == "no"))
            //                {
            //                    invalidInput = true;
            //                }
            //                else
            //                {
            //                    invalidInput = false;
            //                    continueLearning = false;
            //                }
            //            } while (invalidInput);
            //        }
            //    }
            //    else if (userInfoChoice.Trim().ToLower() == "favorite food")
            //    {
            //        Console.Write($"{studentName.Split()[0]}'s favorite food is {students[userStudentChoice, 1].ToString()}. Would you like to know more? (enter \"yes\" or \"no\"): ");
            //        userInput = Console.ReadLine().Trim().ToLower();
            //        if (userInput == "no")
            //        {
            //            continueLearning = false;
            //        } 
            //        else if(!(userInput == "yes"))
            //        {
            //            do
            //            {
            //                Console.Write("Please enter \"yes\" or \"no\": ");
            //                userInput = Console.ReadLine().Trim().ToLower();
            //                if (!(userInput == "yes" || userInput == "no")){
            //                    invalidInput = true;
            //                }
            //                else
            //                {
            //                    invalidInput = false;
            //                    continueLearning = false;
            //                }
            //            } while (invalidInput);
            //        }
            //    }
            //    else
            //    {
            //        Console.Write($"We do not have information about {userInfoChoice} for {studentName}. Please try again. (enter \"hometown\" or \"favorite food\"): ");
            //    }
            //}
            //Console.WriteLine("Thanks for the interest! Bye!");

            string[] colors = { "red", "green", "blue" };

            Console.WriteLine(colors[2]);

            Console.WriteLine(colors.Length);

            colors[1] = "white";
            Console.WriteLine(colors[1]);
        }
    }
}
