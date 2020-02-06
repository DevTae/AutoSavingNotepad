using System;
using System.Text;

namespace MemoNCalendar.Model
{
    public class Note
    {
        private DateTime dateTime; // 메모 생성 날짜
        private string fileName;
        //private string title; // 제목 구현 X // memo에서 앞 몇글자만 "bulabulabulabula ..." 식으로 표현

        private bool isActivate; // note activate : on / off // note status : trash
        private StringBuilder memo;

        public Note(string fileName, StringBuilder memo, bool isActivate)
        {
            this.fileName = fileName;
            this.memo = memo;
            this.isActivate = isActivate;
            setDateTime();
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

        public bool getIsActivate()
        {
            return isActivate;
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

        public void setIsActivate(bool isActivate)
        {
            this.isActivate = isActivate;
        }
    }
}
