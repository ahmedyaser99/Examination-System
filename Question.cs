using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public Answers Answers1 { get; set; }
        public int CorrectAnswer { get; set; }

        public abstract void ShowQuestion();
        public override string ToString() 
        {
            return $"{Header} ({Title}) \n {Answers1.ToString()}";
        }
        //public abstract bool ShowQuestion();
    }
}
