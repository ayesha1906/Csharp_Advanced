using System;


namespace EventsAndDelegates
{
    //creating subscribers :
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService : Sending an email...");
        }
    }
}
