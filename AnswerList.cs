using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07Test
{
    public class AnswerList : List<Answers>
    {
        public new void Add(Question qus)
        {
            if (qus is TrueOrFalse)
            {
                var path = "D:\\Yasser\\C#\\Task10\\Task10\\Task07Test\\AnswerListTxt.txt";
                TextWriter tsw = new StreamWriter(path, true);
                tsw.WriteLine(((TrueOrFalse)qus).Answers1.Answer[((TrueOrFalse)qus).CorrectAnswer]);
                tsw.Close();

                base.Add(((TrueOrFalse)qus).Answers1);

            }

            if (qus is ChooseOne)
            {
                var path = "D:\\Yasser\\C#\\Task10\\Task10\\Task07Test\\AnswerListTxt.txt";
                TextWriter tsw = new StreamWriter(path, true);
                tsw.WriteLine(((ChooseOne)qus).Answers1.Answer[((ChooseOne)qus).CorrectAnswer]);
                tsw.Close();

                base.Add(((ChooseOne)qus).Answers1);
            }
            if (qus is ChooseAll)
            {
                var path = "D:\\Yasser\\C#\\Task10\\Task10\\Task07Test\\AnswerListTxt.txt";
                TextWriter tsw = new StreamWriter(path, true);
                tsw.WriteLine(((ChooseAll)qus).Answers1.Answer[((ChooseAll)qus).CorrectAnswer]);
                tsw.Close();

                base.Add(((ChooseAll)qus).Answers1);

            }

        }
    }
}
