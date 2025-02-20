namespace PlayerMP3.Models;

public interface IBeatModel
{
    public void Initialize();

    public Task On();

    public void Off();

    public void SetBPM(int bpm);

    public int GetBPM();

    public TimeSpan GetPositionPlayer();

    public MusicInfo? GetMusicInfo();

    public void RegisterObserver(IBeatObserver observer);

    public void RemoveObserver(IBeatObserver observer);

    public void RegisterObserver(IBPMObserver observer);

    public void RemoveObserver(IBPMObserver observer);

    public void RegisterObserver(ILongMusicPlayerObserver observer);

    public void RemoveObserver(ILongMusicPlayerObserver observer);

    public void RegisterObserver(IMusicInfoObserver observer);

    public void RemoveObserver(IMusicInfoObserver observer);
}