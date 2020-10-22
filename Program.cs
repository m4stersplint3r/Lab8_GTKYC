using System;
using System.Linq;

namespace Lab8_GetToKnowYourClassmates
{
    class Program
    {
        const int offset = 1;
        static void Main(string[] args)
        {
            string searchMethod;
            int userStudentChoice;
            bool continueLearning = true;
            string[,] students = InitiateArray();

            searchMethod = ChooseSearchMethod();
            while (continueLearning)
            {
                if(searchMethod == "student number")
                {
                    userStudentChoice = ChooseStudentByNumber();
                } else
                {
                    userStudentChoice = ChooseStudentByName(students);
                }
                continueLearning = GetStudentInfo(userStudentChoice, students);
            }
            Console.WriteLine(Environment.NewLine + "Thanks for the interest! Bye!");
        }
        static string[,] InitiateArray()
        {
            string[,] students = new string[11, 4];
            students[0, 0] = "Bobby Bizon";
            students[0, 1] = "Mexican Food";
            students[0, 2] = "Westland, MI";
            students[0, 3] = "Black";

            students[1, 0] = "Nick Hickman";
            students[1, 1] = "Steak";
            students[1, 2] = "Livonia, MI";
            students[1, 3] = "Green";

            students[2, 0] = "Lauren Jensen";
            students[2, 1] = "Pizza";
            students[2, 2] = "Inkster, MI";
            students[2, 3] = "Red";

            students[3, 0] = "Sonic The Hedgehog";
            students[3, 1] = "Chili dogs";
            students[3, 2] = "Green Emerald Zone";
            students[3, 3] = "Blue";

            students[4, 0] = "Mario Brother";
            students[4, 1] = "Mushrooms";
            students[4, 2] = "World 01 Stage 01";
            students[4, 3] = "Red";

            students[5, 0] = "Hannibal Lecter";
            students[5, 1] = "People";
            students[5, 2] = "Lithuania";
            students[5, 3] = "Black";

            students[6, 0] = "Jason Voorhees";
            students[6, 1] = "Bugs";
            students[6, 2] = "Camp Crystal Lake";
            students[6, 3] = "Red";

            students[7, 0] = "Freddy Krueger";
            students[7, 1] = "Dreams";
            students[7, 2] = "Springwood, OH";
            students[7, 3] = "Brown";

            students[8, 0] = "Leatherface";
            students[8, 1] = "People";
            students[8, 2] = "Texas";
            students[8, 3] = "Yellow";

            students[9, 0] = "Pinhead";
            students[9, 1] = "Souls";
            students[9, 2] = "Somewhere far away";
            students[9, 3] = "Grey";

            students[10, 0] = "Stephen Jedlicki";
            students[10, 1] = "Wagyu";
            students[10, 2] = "Inkster, MI";
            students[10, 3] = "Purple";

            return students;
        }

        static string ChooseSearchMethod()
        {
            string userInput;
            Console.Write("Welcome to our C# class. How would you like to search the students? (enter \"student name\" or \"student number\"): ");
            userInput = Console.ReadLine().Trim().ToLower();
            while (userInput.Length == 0 || !(userInput == "student name" || userInput == "student number"))
            {
                Console.Write($"If you want to search , you must (enter \"student name\" or \"student number\"): ");
                userInput = Console.ReadLine().Trim().ToLower();
            }
            return userInput;
        }
        static int ChooseStudentByNumber()
        {
            int userStudentChoice = 0;
            bool validInput = false;

            Console.Write("Which student would you like to learn about? (enter a number 1-11): ");
            while (!validInput)
            {
                try
                {
                    userStudentChoice = int.Parse(Console.ReadLine()) - offset;
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.Write("You must enter a NUMBER from 1-11, please try again: ");
                }
            }            
            return userStudentChoice;
        }

        static int ChooseStudentByName(string[,] students)
        {
            string studentName;
            string[] studentNames = new string[students.Length / 4];

            Console.Write("Which student would you like to learn about? (choose a student from the list): ");
            // had to divide by 4 because its an array of [11,4] so the length is 44 and I want to iterate 11 times for the name
            for (int i = 0; i < students.Length / 4; i++)
            {
                Console.Write(students[i,0].Split()[0]);
                studentNames[i] = students[i, 0].Split()[0].ToLower();
                if (i < (students.Length / 4) - 1)
                {
                    Console.Write(", ");
                } else
                {
                    Console.Write(": ");
                }
            }
            studentName = Console.ReadLine().Trim().ToLower();
            while (!(studentNames.Contains(studentName)))
            {
                Console.Write("You must enter a name from the list above: ");
                studentName = Console.ReadLine().Trim().ToLower();
            }
                for (int i = 0; i < studentNames.Length; i++)
                {
                    if(studentNames[i] == studentName)
                    {
                        return i;
                    }
                }
                // will never pass this point but IDE was complaining
            return 0;
        }

        static string ValidateUserInfoChoice(string userInfoChoice, string studentFirstName)
        {
            while (userInfoChoice.Length == 0 || !(userInfoChoice == "hometown" || userInfoChoice == "favorite food" || userInfoChoice == "favorite color" || userInfoChoice == "quit"))
            {
                Console.Write($"If you want to know more about {studentFirstName}, you must (enter \"hometown\", \"favorite food\" or \"favorite color\"): ");
                userInfoChoice = Console.ReadLine().Trim().ToLower();
            }
            return userInfoChoice;
        }

        static bool EnterYesOrNo(string userInput)
        {
            bool continueLearning = true;
            bool invalidInput = true;
            if (userInput == "no")
            {
                continueLearning = false;
            }
            else if (!(userInput == "yes"))
            {
                do
                {
                    Console.Write("Please enter \"yes\" or \"no\": ");
                    userInput = Console.ReadLine().Trim().ToLower();
                    if (!(userInput == "yes" || userInput == "no"))
                    {
                        invalidInput = true;
                    }
                    else if (userInput == "yes")
                    {
                        invalidInput = false;
                        continueLearning = true;
                    }
                    else if (userInput == "no")
                    {
                        invalidInput = false;
                        continueLearning = false;
                    }
                } while (invalidInput);
            }
            return continueLearning;
        }
        static bool GetStudentInfo(int studentIndex, string[,] students)
        {
            string userInfoChoice, studentFirstName, userInput, favFood, favColor;
            string studentName = "";
            bool validInput = false;
            bool continueLearning = true;

            while (!validInput)
            {
                // this makes it so that setting up a valid range checker is not necessary due to entering a value out of range cycles back to the catch statement
                try
                {
                    studentName = students[studentIndex, 0];
                    validInput = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Write("You must enter a number FROM 1-11, please try again: ");
                    studentIndex = int.Parse(Console.ReadLine()) - offset;
                }
            }

            studentFirstName = studentName.Split()[0];
            
            Console.Write($"Student {studentIndex + offset} is {studentName}. What would you like to know about {studentFirstName} (enter \"hometown\", \"favorite food\" or \"favorite color\"): ");
            userInfoChoice = Console.ReadLine().Trim().ToLower();
            userInfoChoice = ValidateUserInfoChoice(userInfoChoice, studentFirstName);

            

            if (userInfoChoice == "hometown")
            {

                string hometown = students[studentIndex, 2].ToString();
                Console.Write($"{students[studentIndex, 0]} is from {hometown}. Would you like to learn about another student? (enter \"yes\" or \"no\"): ");
                userInput = Console.ReadLine().Trim().ToLower();
                continueLearning = EnterYesOrNo(userInput);

            }
            else if (userInfoChoice == "favorite food")
            {
                favFood = students[studentIndex, 1].ToString();
                Console.Write($"{students[studentIndex, 0]}'s favorite food is {favFood}. Would you like to learn about another student? (enter \"yes\" or \"no\"): ");
                userInput = Console.ReadLine().Trim().ToLower();

                continueLearning = EnterYesOrNo(userInput);
            }
            else if (userInfoChoice == "favorite color")
            {
                favColor = students[studentIndex, 3].ToString();
                Console.Write($"{students[studentIndex, 0]}'s favorite color is {favColor}. Would you like to learn about another student? (enter \"yes\" or \"no\"): ");
                userInput = Console.ReadLine().Trim().ToLower();

                continueLearning = EnterYesOrNo(userInput);
            } else
            {
                Console.WriteLine("YOU WILL NEVER SEE ME");
            }

            return continueLearning;
        }
    }
}
