using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    public class ChooseOne : Question
    {
        public new Answers Answers1; 
        public ChooseOne(string question,string title,Answers answers, int _correct)
        {
            Header = question;
            Title = title;
            Answers1 = answers;
            CorrectAnswer = _correct;
        }
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header} ({Title}) \n {Answers1.ToString()}");
        }
        public void ChooseOneQs() 
        {
            List<ChooseOne> List1 = new List<ChooseOne>();
            Answers answers1 = new Answers();
            answers1.Answer[1] = "1)Html & CSS";
            answers1.Answer[2] = "2)JavaScript";
            answers1.Answer[3] = "3)OOP C#";
            ChooseOne test = new("What Is Our First Course ? ", "Choose One", answers1, 3);
            Answers answers2 = new Answers();
            answers1.Answer[1] = "1)Html & CSS";
            answers1.Answer[2] = "2)JavaScript";
            answers1.Answer[3] = "3)OOP C#";
            ChooseOne test2 = new("What Is Our Second Course ? ", "Choose One", answers2, 1);

            List1.Add(test);
            List1.Add(test2);
        }
        
    }
}
