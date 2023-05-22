using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    public class Answers
    {
        public string[] Answer;
        public Answers()
        {
            Answer = new string[6];
        }
        public override string ToString()
        {
            StringBuilder Str = new StringBuilder();
            for (int i = 1; i < Answer.Length; i++) 
            {
                Str.Append(Answer[i]).Append("\t\t");
            }
            return Str.ToString();
        }
    }
}
