using MemoNCalendar.Model;

/**
 * 
 * Copyright (c) 2020, ahdelron All rights reserved.
 * https://ahdelron.tistory.com/
 * 
 */

namespace MemoNCalendar.Controller
{
    class StringConverter
    {
        public static string ToFile(string s, int fileStatus)
        {
            string head = null;
            if(fileStatus == Note.on)
            {
                head = "note status:on\n";
            } else if(fileStatus == Note.off)
            {
                head = "note status:off\n";
            } else if(fileStatus == Note.trash)
            {
                head = "note status:trash\n";
            } else
            {
                head = "note status:error\n";
            }
            head += s;
            return head;
        }
    }
}
