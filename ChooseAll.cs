using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    public class ChooseAll : Question
    {

        protected string[] ans;
        public ChooseAll(string question, string title, Answers answers, int _correct)
        {
            Header = question;
            Title = title;
            Answers1 = answers;
            CorrectAnswer = _correct;
        }


        public ChooseAll(string question, string title, Answers answers, string[] rans)
        {
            Header = question;
            Title = title;
            Answers1 = answers;
            ans=rans;
        }
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header} ({Title}) \n {Answers1.ToString()}");
        }

    }
}
