using NAudio.Wave;

namespace PlayerMP3.Models;

public class BeatModel : IBeatModel
{
    private readonly List<IBeatObserver> _beatObserver = new List<IBeatObserver>();
    private readonly List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();

    private int _bpm = 90;
    Thread thread;

    bool stop = false;

    WaveOutEvent _clip;

    public void Initialize()
    {
        try
        {
            string filePath = @"C:\Users\Home\Music\Paul Mauriat - Pardonne Moi Ce Caprice D'enfant.mp3";
            var audioFileReader = new Mp3FileReader(filePath);

            _clip = new WaveOutEvent();
            _clip.Init(audioFileReader);
            _clip.Play();
        }
        catch { }
    }

    public void On()
    {
        _bpm = 90;
        NotifyBPMObservers();
        PlayBeat();
        //thread = new Thread(this);
        stop = false;
        //thread.start();
    }

    public void Off()
    {
        StopBeat();
        stop = true;
    }


    public void Run()
    {
        //throw new NotImplementedException();

        while (!stop)
        {
            PlayBeat();
            NotifyBeatObservers();
            try
            {
                Thread.Sleep(60000 / GetBPM());
            }
            catch { }
        }
    }

    public int GetBPM()
    {
        return _bpm;
    }

    public void SetBPM(int bpm)
    {
        _bpm = bpm;
        NotifyBPMObservers();
    }


    public void RegisterObserver(IBeatObserver observer)
    {
        _beatObserver.Add(observer);
    }

    public void RegisterObserver(IBPMObserver observer)
    {
        _bpmObservers.Remove(observer);
    }

    public void RemoveObserver(IBeatObserver observer)
    {
        _beatObserver.Remove(observer);
    }

    public void RemoveObserver(IBPMObserver observer)
    {
        _bpmObservers.Remove(observer);
    }

    private void NotifyBPMObservers()
    {
        foreach(IBPMObserver observer in _bpmObservers)
            observer.UpdateBPM();
    }

    private void NotifyBeatObservers()
    {
        foreach (IBeatObserver observer in _beatObserver)
            observer.UpdateBeat();
    }

    private void PlayBeat()
    {
        _clip.Play();
    }

    private void StopBeat()
    {
        _clip.Stop();
    }
}