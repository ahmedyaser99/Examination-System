using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    
    public class TrueOrFalse : Question
    {
        public TrueOrFalse(string question, string title, Answers answers, int _correct)
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
    }
}
