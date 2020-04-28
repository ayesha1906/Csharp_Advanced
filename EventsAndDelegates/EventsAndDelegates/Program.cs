namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1 " };
            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService();  //subscriber
            var messageService = new MessageService(); //subscriber

            //doing subscription: here videoEncoder is the publisher, VideoEncoded is the event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //reference or pointer to that method
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


            videoEncoder.Encode(video);

        }
    }
}
