using System;
using System.IO;
using System.Text;

/**
 * 
 * Copyright (c) 2020, ahdelron All rights reserved.
 * https://ahdelron.tistory.com/
 * 
 */

namespace MemoNCalendar.Model
{
    public class Note
    {
        private DateTime dateTime; // 미구현
        private string fileName;

        private int fileStatus;

        public static int off = 0x00;
        public static int on = 0x01;
        public static int trash = 0x02;
        public static int error = 0x10;

        //private bool isActivate; // note activate : on / off // note status : trash

        private StringBuilder memo;

        public Note(string fileName, StringBuilder memo, int fileStatus)
        {
            this.fileName = fileName;
            this.memo = memo;
            this.fileStatus = fileStatus;
            //setDateTime();
        }

        public void setDateTime()
        {
            // DateTime 함수를 통해 한번에 dateTime 연동
        }

        public string getFileName()
        {
            return fileName;
        }

        public DateTime getDateTime()
        {
            return dateTime;
        }

        public StringBuilder getMemo()
        {
            return memo;
        }

        public int getFileStatus()
        {
            return fileStatus;
        }

        public void setFileName(string fileName)
        {
            this.fileName = fileName;
        }

        public void setDateTime(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public void setMemo(StringBuilder memo)
        {
            this.memo = memo;
        }

        public void setFileStatus(int fileStatus)
        {
            // FileOut 부분
            this.fileStatus = fileStatus;
            if(fileStatus == on)
            {
                StreamWriter sw = new StreamWriter(@"data\" + this.getFileName());
                sw.Write(Controller.StringConverter.ToFile(this.getMemo().ToString(), Note.on));
                sw.Close();
            } else if(fileStatus == off)
            {
                StreamWriter sw = new StreamWriter(@"data\" + this.getFileName());
                sw.Write(Controller.StringConverter.ToFile(this.getMemo().ToString(), Note.off));
                sw.Close();
            } else if(fileStatus == trash)
            {
                StreamWriter sw = new StreamWriter(@"data\" + this.getFileName());
                sw.Write(Controller.StringConverter.ToFile(this.getMemo().ToString(), Note.trash));
                sw.Close();
            } else
            {
                StreamWriter sw = new StreamWriter(@"data\" + this.getFileName());
                sw.Write(Controller.StringConverter.ToFile(this.getMemo().ToString(), Note.error));
                sw.Close();
            }
        }
    }
}
