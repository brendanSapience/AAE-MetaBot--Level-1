using System;

namespace MyApp4Lib
{
    public class VisibleBotMethods
    {
        public String SayHiTo(String Name)
        {
            String MyMessage = "Hi There, " + Name;
            return MyMessage;
        }

        public String SayByeTo(String Name)
        {
            String MyMessage = "Goodbye " + Name;
            return MyMessage;
        }
    }
}
