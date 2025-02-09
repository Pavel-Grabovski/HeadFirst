namespace PlayerMP3.Controllers;

public interface IController
{
    public void Start();
    
    public void Stop();

    public void IncreaseBPM();
    
    public void DecreaseBPM();

    public void SetBPM(int bpm);
}
