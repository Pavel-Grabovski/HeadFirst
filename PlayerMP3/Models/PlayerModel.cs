using CSCore;
using CSCore.Codecs;
using PlaybackState = CSCore.SoundOut.PlaybackState;
using WasapiOut = CSCore.SoundOut.WasapiOut;

namespace PlayerMP3.Models;

public class PlayerModel : IPlayerModel
{
    private readonly List<IMusicInfoObserver> 
        _musicInfoObservers = new();

    private readonly List<ILongMusicPlayerObserver>
        _playbackPositionObservers = new();


    private WasapiOut _clip;
    string _filePath = @"C:\Users\Home\Music\Paul Mauriat - Pardonne Moi Ce Caprice D'enfant.mp3";

    private float _volume = 0.5F;

    bool stop = false;

    public async Task On()
    {
        stop = false;
        await Run();
    }

    public void Off()
    {
        StopMusic();
        stop = true;
    }


    public async Task Run()
    {
        try
        {
            IWaveSource _audioSource = CodecFactory.Instance.GetCodec(_filePath);

            _clip = new WasapiOut();
            _clip.Initialize(_audioSource);
            _clip.Volume = _volume;

            MusicInfo selectMusicInfo = new()
            {
                Name = Path.GetFileName(_filePath),
                Path = _filePath,
                PlayingTime = _clip.WaveSource.GetLength()
            };
            NotifyMusicInfoObservers(selectMusicInfo);

            PlayMusic();
            while (_clip.PlaybackState == PlaybackState.Playing)
            {
                TimeSpan position = _clip.WaveSource.GetPosition();
                NotifyPlaybackPositionObservers(position);
                await Task.Delay(1000);
            }
        }
        catch { }
    }

    /// <summary>
    ///  Sets the volume of the playback. Valid values are in the range from 0.0
    //     (0%) to 1.0 (100%).
    /// </summary>
    /// <param name="volume"></param>
    public void SetVolume(float volume)
    {
        _clip.Volume = volume;
    }

    public void RegisterObserver(ILongMusicPlayerObserver observer)
    {
        _playbackPositionObservers.Add(observer);
    }

    public void RemoveObserver(ILongMusicPlayerObserver observer)
    {
        _playbackPositionObservers.Remove(observer);
    }

    public void RegisterObserver(IMusicInfoObserver observer)
    {
        _musicInfoObservers.Add(observer);
    }

    public void RemoveObserver(IMusicInfoObserver observer)
    {
        _musicInfoObservers.Remove(observer);
    }

    private void NotifyPlaybackPositionObservers(TimeSpan position)
    {
        foreach (ILongMusicPlayerObserver observer in _playbackPositionObservers)
            observer.UpdateLongMusicPlayer(position);
    }

    private void NotifyMusicInfoObservers(MusicInfo musicInfo)
    {
        foreach (IMusicInfoObserver observer in _musicInfoObservers)
            observer.UpdateMusicInfo(musicInfo);
    }


    private void PlayMusic()
    {
        _clip.Play();
    }

    private void StopMusic()
    {
        _clip.Stop();
    }

    public void Dispose()
    {
        _clip.Dispose();
    }
}