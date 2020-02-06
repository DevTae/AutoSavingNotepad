using MemoNCalendar.Model;
using System;
using System.IO;
using System.Text;

namespace MemoNCalendar.Controller
{
    class FileOut
    {
        public static Note makeNewMemoFile()
        {
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
            string path = @"data\" + nowTime;
            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                FileStream fs = fileInfo.Create();
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("note activate:on");
                sw.Close();
                fs.Close();
                Note newNote = new Note(nowTime, new StringBuilder(), true);
                return newNote;
            }
            else
            {
                return null; // 이름 같은 파일 있으면 반환
            }
        }
    }
}
