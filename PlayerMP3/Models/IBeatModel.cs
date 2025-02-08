namespace PlayerMP3.Models;

public interface IBeatModel
{
    public void Initialize();
    
    public void On();
    
    public void Off();

    public void SetBPM(int bpm);
    
    public int GetBPM();

    public void RegisterObserver(BeatObserver observer);

    public void RemoveObserver(BeatObserver observer);

    public void RegisterObserver(BPMObserver observer);

    public void RemoveObserver(BPMObserver observer);
}
