namespace Delegeta
{
    //cls 
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs e); // Delegate

        public event VideoEncodedEventHandler VideoEncoded; // Event.

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video) // Raissing an Event
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
