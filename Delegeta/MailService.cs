namespace Delegeta
{
    public class MailService //subs
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending an Email...." + e.Video.Title);
        }
    }
}