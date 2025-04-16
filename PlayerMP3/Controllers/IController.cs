namespace PlayerMP3.Controllers;

public interface IController
{
    public void Start(IProgress<TimeSpan> progress);
    
    public void Stop();

    public void Pause();

    public void SetVolume(int volume);
}
