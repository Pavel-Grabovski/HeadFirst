
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using NAudio.Wave.SampleProviders;

using NAudio.Wave;

//using NAudio.Wave;
using WasapiOut = CSCore.SoundOut.WasapiOut;
using CSCore.MediaFoundation;
using NAudio.CoreAudioApi;
using System;
using PlaybackState = CSCore.SoundOut.PlaybackState;

namespace PlayerMP3.Models;

public class BeatModel : IBeatModel
{
    private readonly List<IBeatObserver> _beatObserver = new List<IBeatObserver>();
    private readonly List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();

    private readonly List<IMusicInfoObserver> 
        _musicInfoObservers = new();

    private readonly List<ILongMusicPlayerObserver>
        _playbackPositionObservers = new();


    private WasapiOut _clip;
    string _filePath = @"C:\Users\Home\Music\Paul Mauriat - Pardonne Moi Ce Caprice D'enfant.mp3";

    private int _bpm = 90;

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
        return _bpm;
    }

    public void SetBPM(int bpm)
    {
       _bpm = bpm;
        _clip.Volume = (float)_bpm / 100;
        //NotifyBPMObservers();
    }


    public void RegisterObserver(IBeatObserver observer)
    {
        _beatObserver.Add(observer);
    }

    public void RegisterObserver(IBPMObserver observer)
    {
        _bpmObservers.Add(observer);
    }

    public void RemoveObserver(IBeatObserver observer)
    {
        _beatObserver.Remove(observer);
    }

    public void RemoveObserver(IBPMObserver observer)
    {
        _bpmObservers.Remove(observer);
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


    //private void NotifyBPMObservers()
    //{
    //    foreach(IBPMObserver observer in _bpmObservers)
    //        observer.UpdateBPM();
    //}

    //private void NotifyBeatObservers()
    //{
    //    foreach (IBeatObserver observer in _beatObserver)
    //        observer.UpdateBeat();
    //}

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