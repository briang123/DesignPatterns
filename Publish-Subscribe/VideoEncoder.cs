using System;
using System.Threading;

namespace Publish_Subscribe
{
    public class VideoEncoder : IVideoEncoder
    {
        public event EventHandler<IVideoEventArgs> VideoEncoded;

        public void Encode(IVideo video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        public virtual void OnVideoEncoded(IVideo video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
        }
    }
}