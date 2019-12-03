using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class MCQuestionCreator
    {
        //hard coded mc questions
        public static List<IQuiz> create()
        {
            IQuiz q1 = new MultipleChoiceQuestion()
            {
                Answer = "B",
                Difficulty = 2,
                Category = "Animals",
                Question = "What animal is animal?",
                choices = new List<string> { "A: Dog", "B: Cat", "C: Elephant" }
            };
            IQuiz q2 = new MultipleChoiceQuestion()
            {
                Answer = "A",
                Difficulty = 3,
                Category = "Animals",
                Question = "Where animal live?",
                choices = new List<string> { "A: Hotel", "B: Water", "C: Gas" }
            };
            IQuiz q3 = new MultipleChoiceQuestion()
            {
                Answer = "B",
                Difficulty = 3,
                Category = "Technology",
                Question = "Just buy a?",
                choices = new List<string> { "A: Lamp", "B: Laptop", "C: House" }
            };
            IQuiz q4 = new MultipleChoiceQuestion()
            {
                Answer = "C",
                Difficulty = 2,
                Category = "Technology",
                Question = "Do you know when to go to how you will know?",
                choices = new List<string> { "A: Ok", "B: Yes", "C: No" }
            };

            return new List<IQuiz>() { q1, q2, q3, q4 };
        }
    }
}
