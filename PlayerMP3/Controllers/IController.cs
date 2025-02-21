namespace PlayerMP3.Controllers;

public interface IController
{
    public void Start();
    
    public void Stop();

    public void SetVolume(int volume);

    public Form GetView();
}
