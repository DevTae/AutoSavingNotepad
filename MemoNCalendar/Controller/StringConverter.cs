using System.Text;

namespace MemoNCalendar.Controller
{
    class StringConverter
    {
        public static int option_on = 0x01;
        public static int option_off = 0x00;

        public static string ToFile(string s, int option)
        {
            string head = null;
            if(option == option_on)
            {
                head = "note activate:on\n";
            } else if(option == option_off)
            {
                head = "note activate:off\n";
            }
            head += s;
            return head;
        }
    }
}
