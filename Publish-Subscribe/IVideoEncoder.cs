using System;

namespace Publish_Subscribe
{
    public interface IVideoEncoder
    {
        event EventHandler<IVideoEventArgs> VideoEncoded;
        void Encode(IVideo video);
        void OnVideoEncoded(IVideo video);
    }
}