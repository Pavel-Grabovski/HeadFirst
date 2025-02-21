
using CSCore;
using CSCore.Codecs;
using PlaybackState = CSCore.SoundOut.PlaybackState;
using WasapiOut = CSCore.SoundOut.WasapiOut;

namespace PlayerMP3.Models;

public class BeatModel : IBeatModel
{
    private readonly List<IMusicInfoObserver> 
        _musicInfoObservers = new();

    private readonly List<ILongMusicPlayerObserver>
        _playbackPositionObservers = new();


    private WasapiOut _clip;
    string _filePath = @"C:\Users\Home\Music\Paul Mauriat - Pardonne Moi Ce Caprice D'enfant.mp3";

    private int _volume = 90;

    bool stop = false;

    private MusicInfo? _selectMusicInfo;

    public void Initialize()
    {
        try
        {
            IWaveSource _audioSource = CodecFactory.Instance.GetCodec(_filePath);

            _clip = new WasapiOut();
            _clip.Initialize(_audioSource);

            _selectMusicInfo = new MusicInfo()
            {
                Name = Path.GetFileName(_filePath),
                Path = _filePath,
                PlayingTime = _clip.WaveSource.GetLength()
            };
            NotifyMusicInfoObservers();
        }
        catch { }
    }

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
        PlayMusic();
        while (_clip.PlaybackState == PlaybackState.Playing)
        {
            NotifyPlaybackPositionObservers();
            await Task.Delay(500);
        }
    }

    public int GetBPM()
    {
        return _volume;
    }

    public void SetVolume(int bpm)
    {
       _volume = bpm;
        _clip.Volume = (float)_volume / 100;
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

    public TimeSpan GetPositionPlayer()
    {
        TimeSpan position = _clip.WaveSource.GetPosition();
        return position;
    }

    private void NotifyPlaybackPositionObservers()
    {
        foreach (ILongMusicPlayerObserver observer in _playbackPositionObservers)
            observer.UpdateLongMusicPlayer();
    }

    private void NotifyMusicInfoObservers()
    {
        foreach (IMusicInfoObserver observer in _musicInfoObservers)
            observer.UpdateMusicInfo();
    }


    private void PlayMusic()
    {
        _clip.Play();
    }

    private void StopMusic()
    {
        _clip.Stop();
    }

    public MusicInfo? GetMusicInfo()
        => _selectMusicInfo;
}