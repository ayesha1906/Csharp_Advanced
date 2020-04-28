using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1.Define  delegate
        // 2.Define an event based on that delegate
        // 3.Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
       // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

            public void Encode(Video video)
            {
                Console.WriteLine("Encoding Video..");
                Thread.Sleep(1000);

                OnVideoEncoded();
            }
        
        protected virtual void OnVideoEncoded()  //to notify subscribers
        {
            //if the liat is not empty it means someone has subscribed to that event
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty); //source of the event i.e who is publishing the event is the current class thats why 'this'. 
        }
    }
}