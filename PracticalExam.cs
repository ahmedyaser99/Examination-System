using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    internal class PracticalExam : Exam

    {
        public Dictionary<string, int> dict = new Dictionary<string,int>();
        QuestionList QL;
        AnswerList AL;
        public PracticalExam(string _n, int _t, int _m)
        {
            Name = _n;
            Time = _t;
            Mark = _m;
            QL = new QuestionList();
            AL = new AnswerList();
        }
        public override void GenerateExam()
        {
            ShowDetails();
            int mark = 0;
            #region Old
            //Answers answers1 = new Answers();
            //answers1.Answer[1] = "1)Html & CSS";
            //answers1.Answer[2] = "2)JavaScript";
            //answers1.Answer[3] = "3)OOP C#";
            //ChooseOne test = new("Q1) What Is Our First Course ? ", "Choose One", answers1, 3);
            //QL.Add(test);
            //AL.Add(test);

            //dict.Add(test.Header,test.CorrectAnswer);

            //test.ShowQuestion();
            //Console.Write("Enter Your Answer: ");
            //int a;
            //while (!(int.TryParse(Console.ReadLine(), out a)) || a <= 0 || a > 3)
            //{
            //    Console.WriteLine("Enter a Correct Answer");
            //}
            //if (dict[test.Header] == a)
            //{
            //    mark += 5;
            //}

            //Console.WriteLine();

            //#region ChooseAll
            ////Answers answers2 = new Answers();
            ////answers2.Answer[1] = "1)abstraction";
            ////answers2.Answer[2] = "2)Encapsulation";
            ////answers2.Answer[3] = "3)Inheritance";
            ////answers2.Answer[4] = "4)Polymorphism";
            ////answers2.Answer[5] = "5)All Of Them";
            ////ChooseAll test1 = new("Q2) What is OOP Main Priciples", "Choose All", answers2, 5);
            ////test1.ShowQuestion();

            ////Console.Write("Enter Your Answer: ");
            ////int b;
            ////while (!(int.TryParse(Console.ReadLine(), out b)) || b <= 0 || b > 5)
            ////{
            ////    Console.WriteLine("Enter a Correct Answer");
            ////}
            ////if (b == test1.CorrectAnswer)
            ////{
            ////    mark += 5;
            ////}

            ////Console.WriteLine(); 
            //#endregion

            //Answers answers3 = new Answers();
            //answers3.Answer[1] = "1)False";
            //answers3.Answer[2] = "2)True";
            //TrueOrFalse test3 = new("Q3) Is Recursion from the OOP Main Priciples ?", "T-F", answers3, 1);

            //QL.Add(test3);
            //AL.Add(test3);

            //dict.Add(test3.Header, test3.CorrectAnswer);

            //test3.ShowQuestion();
            //Console.Write("Enter Your Answer: ");
            //int b;
            //while (!(int.TryParse(Console.ReadLine(), out b)) || b <= 0 || b > 2)
            //{
            //    Console.WriteLine("Enter Correct Answer (1)True-2)False)");
            //}
            //if (dict[test3.Header] == b)
            //{
            //    mark += 5;
            //} 
            #endregion

            Answers answers1 = new Answers();
            answers1.Answer[1] = "1)Html & CSS";
            answers1.Answer[2] = "2)JavaScript";
            answers1.Answer[3] = "3)OOP C#";
            List<ChooseOne> List1 = new List<ChooseOne>() 
            {
                new("What Is Our First Course ? ", "Choose One", answers1, 3),
                new("What Is Our Third Course ? ", "Choose One", answers1, 2),
                new("What Is Our Second Course ? ", "Choose One", answers1, 1)

            };
            Random rnd = new Random();
            int index = rnd.Next(List1.Count);
            List1[index].ShowQuestion();
            QL.Add(List1[index]);
            AL.Add(List1[index]);

            
            Console.Write("Enter Your Answer: ");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)) || a <= 0 || a > 3)
            {
                Console.WriteLine("Enter a Correct Answer");
            }
            dict.Add(List1[index].Header, a );
            if (dict[List1[index].Header] == List1[index].CorrectAnswer)
            {
                mark += 5;
            }

            Console.WriteLine();

            Answers answers3 = new Answers();
            answers3.Answer[1] = "1)False";
            answers3.Answer[2] = "2)True";
            List<TrueOrFalse> List2 = new List<TrueOrFalse>() 
            { 
                new("Is Recursion from the OOP Main Priciples ?", "T-F", answers3, 1),
                new("Is Abstraction from the OOP Main Priciples ?", "T-F", answers3, 2),
                new("Is Inheritance from the OOP Main Priciples ?", "T-F", answers3, 2)
            };
            Random rnd2 = new Random();
            int index2 = rnd2.Next(List2.Count);
            List2[index2].ShowQuestion();
            QL.Add(List2[index2]);
            AL.Add(List2[index2]);
            

            
            Console.Write("Enter Your Answer: ");
            int b;
            while (!(int.TryParse(Console.ReadLine(), out b)) || b <= 0 || b > 2)
            {
                Console.WriteLine("Enter Correct Answer (1)True-2)False)");
            }
            dict.Add(List2[index2].Header, b);
            if (dict[List2[index2].Header] == (List2[index2].CorrectAnswer))
            {
                mark += 5;
            }
            Console.WriteLine();


            Answers answers2 = new Answers();
            answers2.Answer[1] = "1)abstraction";
            answers2.Answer[2] = "2)Encapsulation";
            answers2.Answer[3] = "3)Inheritance";
            answers2.Answer[4] = "4)Polymorphism";
            answers2.Answer[5] = "5)All Of Them";
            Answers answers4 = new Answers();
            answers4.Answer[1] = "1)Value Type";
            answers4.Answer[2] = "2)Reference Type";
            answers4.Answer[3] = "3)All Of Them";
            List<ChooseAll> List3 = new List<ChooseAll> 
            { 
                new("What is OOP Main Priciples?", "Choose All", answers2, 5),
                new("What Are Types Of Variables in C#?", "Choose All", answers4, 3)
            };
            

            Random rnd3 = new Random();
            int index3 = rnd3.Next(List3.Count);
            List3[index3].ShowQuestion();
            QL.Add(List3[index3]);
            AL.Add(List3[index3]);

            Console.Write("Enter Your Answer: ");
            int c;
            while (!(int.TryParse(Console.ReadLine(), out c)) || c <= 0 || c > 5)
            {
                Console.WriteLine("Enter a Correct Answer");
            }
            dict.Add(List3[index3].Header, c);
            if (dict[List3[index3].Header] == (List3[index3].CorrectAnswer))
            {
                mark += 5;
            }

            Console.WriteLine();
            Console.WriteLine($"Your Total Grade: {mark} / {Mark}");
            Console.WriteLine();
            Console.WriteLine($"Answer Of Question1: {List1[index].CorrectAnswer} \n" +
                     $"Answer Of Question2: {List2[index2].CorrectAnswer} \n" +
                $"Answer Of Question2: {List3[index3].CorrectAnswer}");
        }
        public void ShowDetails() { Console.WriteLine($"Name: ({Name}) Time: ({Time} Min.) Total Marks: ({Mark})"); }

    }
}
