using MemoNCalendar.Model;
using System;
using System.IO;
using System.Text;

/**
 * 
 * Copyright (c) 2020, ahdelron All rights reserved.
 * https://ahdelron.tistory.com/
 * 
 */

namespace MemoNCalendar.Controller
{
    class FileOut
    {
        public static Note makeNewMemoFile()
        {
            string nowTime = DateTime.Now.ToString("yyyy/MM/dd, HH시 mm분 ss초");
            string path = @"data\" + nowTime;
            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                FileStream fs = fileInfo.Create();
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("note status:on");
                sw.Close();
                fs.Close();
                Note newNote = new Note(nowTime, new StringBuilder(), Note.on);
                return newNote;
            }
            else
            {
                return null; // 이름 같은 파일 있으면 반환
            }
        }

        public static bool removeMemoFile(string fileName)
        {
            string path = @"data\" + fileName;
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                try
                {
                    fileInfo.Delete();
                } catch(FileLoadException e)
                {
                    Console.WriteLine("{0}", e.StackTrace);
                    return false;
                }
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
