using System;

namespace Publish_Subscribe
{
    public class MailService : IVideoEncodeService
    {
        public void OnVideoEncoded(object source, IVideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email...{0}", args.Video.Title);
        }
    }
}