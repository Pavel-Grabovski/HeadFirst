namespace PlayerMP3.Models;

public interface IPlayerModel
{
    public Task On(IProgress<TimeSpan>? progress = null);

    public void Off();

    public void Pause();

    public void SetVolume(float volume);

    public void RegisterObserver(ILongMusicPlayerObserver observer);

    public void RemoveObserver(ILongMusicPlayerObserver observer);

    public void RegisterObserver(IMusicInfoObserver observer);

    public void RemoveObserver(IMusicInfoObserver observer);
}