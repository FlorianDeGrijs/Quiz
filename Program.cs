using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IQuiz> questions = Initialize();
            StartQuiz(questions);
            Console.WriteLine("**********************\nEnd of this quiz.\nPress any key to exit...");
            Console.ReadKey(true);
        }

        //start de quiz met alle ingevoerde gebruikersvoorwaarden
        private static void StartQuiz(List<IQuiz> questions)
        {
            int totalQuestions = questions.Count();
            int questionCounter = 1;
            int i = 0;
            string answer = "";

            while (i < totalQuestions)
            {
                questions[i].ShowQuestion(questionCounter);
                answer = Console.ReadLine();
                if (answer.ToLower().Equals(questions[i].Answer.ToLower()))
                {
                    Console.WriteLine($"That was the correct answer!");
                }
                else
                {
                    Console.WriteLine($"False. The correct answer was: {questions[i].Answer}");
                }
                i++;
                questionCounter++;
            }
        }

        //initialization of program
        private static List<IQuiz> Initialize()
        {
            List<IQuiz> questions = MCQuestionCreator.create();
            questions.AddRange(OQuestionCreator.create());
            List<string> catagories = createCatagories(questions);
            List<string> difficulties = new List<string>();

            string catagory = chooseCatagory(catagories);
            if (!catagory.Equals("any"))
            {
                questions = questions.Where(q => q.Category.ToLower().Equals(catagory)).ToList();
                difficulties = createDifficulties(questions);
            }
            else
            {
                difficulties = createDifficulties(questions);
            }
            Console.WriteLine("****************************");
            string difficulty = chooseDifficulty(difficulties);
            if (!difficulty.Equals("any"))
            {
                questions = questions.Where(q => q.Difficulty.ToString() == difficulty).ToList();
            }
            Console.WriteLine("****************************");
            return questions;
        }

        //checks if list op options contains answer given
        private static bool isValidAnswer(string answer, List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                if (options[i].ToLower().Equals(answer.ToLower()) || answer.ToLower().Equals("any"))
                {
                    return true;
                }
            }
            return false;
        }

        //Write to console which difficulty the user would like to use
        private static string chooseDifficulty(List<string> difficulties)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string q in difficulties)
            {
                sb.Append($"{q}, ");
            }
            sb.Append("Any");
            string answer = getValidAnswer(difficulties, sb, "difficulty");
            return answer.ToLower();
        }

        //Write to consol which catagory the user would like to use
        private static string chooseCatagory(List<string> catagories)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string catagory in catagories)
            {
                sb.Append($"{catagory}\n");
            }
            sb.Append("Any");
            string answer = getValidAnswer(catagories, sb, "catagory");
            return answer.ToLower();
        }

        //checks if the answer given is a valid answer
        private static string getValidAnswer(List<string> options, StringBuilder sb, string type)
        {
            string answer = "";
            while (!isValidAnswer(answer.ToLower(), options))
            {
                Console.WriteLine($"Which {type} would you like?\n" + sb.ToString());
                answer = Console.ReadLine();
                if (!isValidAnswer(answer.ToLower(), options))
                {
                    Console.WriteLine($"{answer} is not a valid answer, try again");
                }
                else
                {
                    Console.WriteLine($"You have chosen: {answer} :)");
                }
            }
            return answer;
        }

        //creating difficulties from the chosen list of questions
        private static List<string> createDifficulties(List<IQuiz> questions)
        {
            if (questions == null)
            {
                throw new ArgumentNullException("No Quiz found");
            }
            List<string> difficulties = new List<string>();
            foreach (IQuiz q in questions)
            {
                if (!difficulties.Contains(q.Difficulty.ToString()))
                {
                    difficulties.Add(q.Difficulty.ToString());
                }
            }
            return difficulties;
        }

        //creating catagories from the questions
        private static List<string> createCatagories(List<IQuiz> questions)
        {
            if(questions == null)
            {
                throw new ArgumentNullException("No Quiz found");
            }
            List<string> catagories = new List<string>();
            foreach (IQuiz q in questions)
            {
                if (!catagories.Contains(q.Category))
                {
                    catagories.Add(q.Category);
                }
            }
            return catagories;
        }
    }
}
