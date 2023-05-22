using System;
using System.Threading;

namespace Task07Test
{
    public enum TOrF { True, False }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exams
            int z = 0;
            do
            {
                Console.WriteLine("1-Final Exam\n2-Practical Exam\n");
                z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    case 1:
                        generate();
                        Console.WriteLine();
                        FinalExam Exam = new("C#", 90, 15);
                        Exam.GenerateExam();
                        break;
                    case 2:
                        generate();
                        Console.WriteLine();
                        PracticalExam ExamTest = new("Programming", 90, 15);
                        ExamTest.GenerateExam();
                        break;
                }
            } while (!(z == 1 || z == 2));
            #endregion

            #region files
            //QuestionList QL = new QuestionList();
            //Answers answers1 = new Answers();
            //answers1.Answer[1] = "1)Html & CSS";
            //answers1.Answer[2] = "2)JavaScript";
            //answers1.Answer[3] = "3)OOP C#";
            //ChooseOne chooseOne = new ChooseOne("Q1) What Is Our First Course ? ", "Choose One", answers1, 3);

            //TrueOrFalse TF = new("Q3) Is Recursion from the OOP Main Priciples ?", "T-F");

            ////QL.Add(chooseOne);
            ////QL.Add(TF);

            //AnswerList AL = new AnswerList();
            //AL.Add(chooseOne); 
            #endregion

        }
                 
        static void generate() {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rGenerating Exam: {i}%   ");
                Thread.Sleep(15);
            }
        } 
    }
}
