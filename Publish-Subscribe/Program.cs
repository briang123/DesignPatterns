using System;

namespace Publish_Subscribe
{
    public class Program
    {
        private static void Main()
        {
            var video = new Video() { Title = "Video 1" };

            // publisher
            var videoEncoder = new VideoEncoder();

            // subscribers
            var mailService = new MailService();
            var messageService = new MessageService();

            // register subscribers
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

