namespace Publish_Subscribe
{
    public interface IVideoEncodeService
    {
        void OnVideoEncoded(object source, IVideoEventArgs args);
    }
}