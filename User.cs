using System;
using System.Collections.Generic;
using System.Text;

namespace userInfo
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string spiritAnimal { get; set; }
        public string favColor { get; set; }
        public string favFood { get; set; }
        public int luckyNum { get; set; }
        public int Age { get; set; }
        public int yearBorn { get; set; }
        public int Siblings { get; set; }

        public string AnswerQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);
        }

    }
}
