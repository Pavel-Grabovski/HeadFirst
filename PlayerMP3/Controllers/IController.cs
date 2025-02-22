namespace PlayerMP3.Controllers;

public interface IController : IDisposable
{
    public void Start();
    
    public void Stop();

    public void SetVolume(int volume);
}
