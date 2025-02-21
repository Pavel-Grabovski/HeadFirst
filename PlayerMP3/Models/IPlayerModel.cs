namespace PlayerMP3.Models;

public interface IPlayerModel : IDisposable 
{
    public Task On();

    public void Off();

    public void SetVolume(float volume);

    public TimeSpan GetPositionPlayer();

    public MusicInfo? GetMusicInfo();

    public void RegisterObserver(ILongMusicPlayerObserver observer);

    public void RemoveObserver(ILongMusicPlayerObserver observer);

    public void RegisterObserver(IMusicInfoObserver observer);

    public void RemoveObserver(IMusicInfoObserver observer);
}