using System;

namespace Publish_Subscribe
{
    public class MessageService : IVideoEncodeService
    {
        public void OnVideoEncoded(object source, IVideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending an text message...{0}", args.Video.Title);
        }
    }
}