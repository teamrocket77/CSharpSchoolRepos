/*
 * Student: Vincent Cradler
 * Date: 08292021
 * Class: CSE 1322L 
 * section: #02
 * 
 * Assignment: {Lab 3}
 * Instructor: Kavitha
 */
using System;
using System.Collections; // for arraylist


namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string prompt =
@"1. Add Question
2. Remove Question
3. Modify Question
4. Give Quiz
5. Exit";
            Quiz quiz1 = new Quiz();
            while (i != 5)
            {
                Console.WriteLine(prompt);
                Console.WriteLine("What would you like to do?");
                i = Int16.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        quiz1.add_question();
                        break;
                    case 2:
                        quiz1.remove_question();
                        break;
                    case 3:
                        quiz1.modify_question();
                        break;
                    case 4:
                        quiz1.give_quiz();
                        break;

                }
            }
                Console.WriteLine("Bye!");

        }
    }
    public class Question
    {
        //private set variable is hidden
        public string question { get; private set; }
        public string answer { get; private set; }
        private int difficulty
        {
            get
            {
                return _diff;
            }
            set
            {
                if (value > 0 && value <= 3) _diff = value;
            }
        }
        private int _diff;

        public Question(string question, string answer, int difficulty)
        {
            this.question = question;
            this.answer = answer;
            this.difficulty = difficulty;
        }
        public void edit_question()
        {
            //probably a no-no ideally we want to sanitize input
            Console.WriteLine("What is your new question?");
            question = Console.ReadLine();
        }
        public void edit_answer()
        {
            Console.WriteLine("What is the new answer");
            answer = Console.ReadLine();
        }
        public void edit_diff()
        {
            Console.WriteLine("What's the new difficulty");
            difficulty = Int16.Parse(Console.ReadLine());
        }
        public string answer_q()
        {
            return this.answer;
        }
    }
    class Quiz
    {
        ArrayList questions = new ArrayList();
        int QuestionNumInt, questions_correct;
        string Answer;
        Question q;
        public Quiz()
        {

        }
        //Add question normal way 
        public void add_question()
        {
            string question, answer;
            int difficulty;
            Console.WriteLine("What's your question?");
            question = Console.ReadLine();
            Console.WriteLine("What's your answer?");
            answer = Console.ReadLine();
            Console.WriteLine("What's the difficulty?");
            difficulty = Int16.Parse(Console.ReadLine());
            Question q = new Question(question, answer, difficulty);
            questions.Add(q);
        }
        //EZ add for testing
        public void add_question(string question, string answer, int diff)
        {
            Question q = new Question(question, answer, diff);
            questions.Add(q);
        }
        public void remove_question()
        {
            if (this.questions.Count == 0)
            {
                Console.WriteLine("There at no questions to remove");
                return;
            }
            // Attempt to remove questions
            int i = 0;
            Console.WriteLine("What question would you like to remove?");
                foreach( Question _question in questions){
                Console.WriteLine("Question {0}: {1}",i, _question.question);
                i++;
            }
            Console.WriteLine("Please enter the number of the question you would like to remove.");
                QuestionNumInt = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Attempting to remove {0}", QuestionNumInt);
                questions.RemoveAt(QuestionNumInt);
        }
        public void modify_question()
        {
            int i = 0;
            Console.WriteLine("Which Question would you like to modify?");
            Console.WriteLine("Writing Questions:");
            foreach( Question _q in questions)
            {
                Console.WriteLine("Question {0}: {1}", i, _q.question);
                i++;
            }
            q = (Question)questions[Int16.Parse(Console.ReadLine())];
            q.edit_question();
            q.edit_answer();
            q.edit_diff();


        }
        public void give_quiz()
        {
            foreach (Question _q in questions)
            {
                Console.WriteLine(_q.question);
                Console.WriteLine("Answer: ");
                Answer = Console.ReadLine();
                Answer = Answer.ToLower();

                if (Answer == _q.answer)
                {
                    questions_correct += 1;
                    Console.WriteLine("Correct");
                }
                else Console.WriteLine("Incorrect");
            }
            Console.WriteLine("You {0}/{1} correct", questions_correct, questions.Count);
        }
    }
}