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
}

