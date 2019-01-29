using System;

namespace Publish_Subscribe
{
    public class VideoEventArgs : EventArgs, IVideoEventArgs
    {
        public IVideo Video { get; set; }
    }
}