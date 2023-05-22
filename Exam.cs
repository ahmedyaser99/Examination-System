using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    public abstract class Exam
    {
        public string Name;
        public int Time;
        public int Mark;
        
        public abstract void GenerateExam();
    }
}
