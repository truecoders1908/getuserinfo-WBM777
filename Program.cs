using System;
using System.Collections.Generic;

namespace userInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            User you = new User();
            Console.WriteLine("I would like to bother you for a few minutes to ask you a few questions.");
            Console.WriteLine("If you answer them honestly i will be able use them to figure out very personal things about you. Want to find out?");
            string response;
            response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("Awesome thank you let's jump right in.");
            }
           
            else
            {
                Console.WriteLine("Sorry to bother you.");
                System.Environment.Exit(1);
            }

            you.FirstName = you.AnswerQuestion("What's your first name?");
            you.LastName = you.AnswerQuestion("What's your last name?");
            you.spiritAnimal = you.AnswerQuestion("What wold you say your spirit animal is?");
            you.favColor = you.AnswerQuestion("What is your favorite color?");
            you.favFood = you.AnswerQuestion("What is your favorite thing to eat?");
            you.luckyNum = you.AnswerQuestionWithInteger("What has been your lucky number thus far?");
            you.Age = you.AnswerQuestionWithInteger("How old would you say you are?");
            you.yearBorn = you.AnswerQuestionWithInteger("When were you born?");
            you.Siblings = you.AnswerQuestionWithInteger("Lastly, how many siblings do you know you have?");

            Console.WriteLine($"So you are {you.FirstName} {you.LastName}.");
            Console.WriteLine($"You were born a child of {you.Siblings} in {you.yearBorn}, but you say you are {you.Age}.");
            Console.WriteLine($"You feel a strong connection to a {you.spiritAnimal} and will often eat {you.favFood} while acting like a {you.spiritAnimal}.");
            Console.WriteLine($"Finally, if you were ever to see a giant {you.favColor} {you.luckyNum} you would faint from excitment.");



            
        }
    }
}
