namespace PlayerMP3.Models;

public interface IBeatModel
{
    public void Initialize();

    public void On();

    public void Off();

    public void SetBPM(int bpm);

    public int GetBPM();

    public void RegisterObserver(IBeatObserver observer);

    public void RemoveObserver(IBeatObserver observer);

    public void RegisterObserver(IBPMObserver observer);

    public void RemoveObserver(IBPMObserver observer);
}