using System;

namespace EventsAndDelegates
{
    //creating subscriber responsible for sending a text msg
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..");
        }
    }
}
