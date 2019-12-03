using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class OQuestionCreator
    {

        public static List<IQuiz> create()
        {
            IQuiz q1 = new OpenQuestion()
            {
                Answer = "6",
                Difficulty = 1,
                Category = "Math",
                Question = "i=5; i -=- i; What is i?"
            };
            IQuiz q2 = new OpenQuestion()
            {
                Answer = "11",
                Difficulty = 3,
                Category = "Math",
                Question = "Hoeveel vingers steek ik op?"
            };
            IQuiz q3 = new OpenQuestion()
            {
                Answer = "",
                Difficulty = 3,
                Category = "C#",
                Question = "Ho",
            };
            IQuiz q4 = new OpenQuestion()
            {
                Answer = "C#",
                Difficulty = 1,
                Category = "C#",
                Question = "What is better? C# or JAVA?",
            };

            return new List<IQuiz>() { q1, q2, q3, q4 };
        }
    }
}
