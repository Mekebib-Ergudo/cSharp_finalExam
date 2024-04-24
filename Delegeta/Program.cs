using static Delegeta.VideoEventArgs;

namespace Delegeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video One" };
            var videoEncoder = new VideoEncoder(); // Publisher

            var mailService = new MailService(); // Subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // Subscription
        }
    }

    //cls
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs e); // Delegate

    //cls 
    public class VideoEncoder
    {
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
    public class MailService //subs
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending an Email...." + e.Video.Title);
        }
    }
}
