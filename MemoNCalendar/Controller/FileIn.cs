using MemoNCalendar.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MemoNCalendar.Controller
{
    class FileIn
    {
        // FileIn : data 폴더에서의 모든 파일 접근.
        public static List<Note> LoadAllMemos(string path)
        {
            try
            {
                List<Note> memos = new List<Note>();
                string[] files = System.IO.Directory.GetFiles(path);
                //GetFiles 함수의 인자는 하위 디렉토리까지 포함하나,

                int length = files.Length;

                for (int i = 0; i < length; i++)
                {
                    string[] token = files[i].Split(new char[] { '\\' });
                    files[i] = token[token.Length - 1];
                }

                // StreamReader 클래스의 인자는 하위 디렉토리를 포함하지 않는다.
                for (int i = 0; i < length; i++)
                {
                    StreamReader sr = new StreamReader(@"data\" + files[i]);
                    StringBuilder sb_data = new StringBuilder();
                    string status = sr.ReadLine();
                    Console.WriteLine("{0}", status);
                    sb_data.Append(sr.ReadToEnd());
                    Note note = null;
                    bool isActivate = false;
                    if (status.Equals("note activate:on"))
                    {
                        isActivate = true;
                    }
                    else if (status.Equals("note activate:off"))
                    {
                        isActivate = false;
                    }
                    else if (status.Equals("note activate:trash"))
                    {
                        sr.Close();
                        continue;
                        // 구현하려면 클래스들 속성 조정해야함.
                    }
                    note = new Note(files[i], sb_data, isActivate);
                    memos.Add(note);
                    sr.Close();
                }
                return memos;
            } catch (FileNotFoundException e)
            {
                Console.WriteLine("{0}", e.StackTrace);
            }
            return null;
        }
    }
}