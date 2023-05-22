using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    public class QuestionList : List<Question>
    {
        public new void Add(Question item) 
        {
        var path = "D:\\Yasser\\C#\\Task10\\Task10\\Task07Test\\QuestionListTxt.txt";
        TextWriter tsw = new StreamWriter(path, true);
        tsw.WriteLine(item.Header);
            tsw.Close();
            base.Add(item);
        }
    }
}
