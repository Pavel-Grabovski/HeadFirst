using NAudio.Wave;

namespace PlayerMP3.Models;

public class BeatModel : IBeatModel
{
    private readonly List<IBeatObserver> _beatObserver = new List<IBeatObserver>();
    private readonly List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();

    private int _bpm = 90;
    Thread thread;

    bool stop = false;

    public void Initialize()
    {
        try
        {
            
        }
        catch { }
    }

    public void On()
    {
        throw new NotImplementedException();
        _bpm = 90;
        NotifyBPMObservers();
        //thread = new Thread(this);
        stop = false;
        //thread.start();
    }

    public void Off()
    {
        throw new NotImplementedException();
    }


    public void Run()
    {
        //throw new NotImplementedException();

        while (!stop)
        {
            string filePath = @"C:\Users\Home\Music\Paul Mauriat - Pardonne Moi Ce Caprice D'enfant.mp3";

            using (var audioFileReader = new Mp3FileReader(filePath))
            using (var waveOutDevice = new WaveOutEvent())
            {
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();

                Console.WriteLine("Press any key to stop playback...");
                Console.ReadKey();

                waveOutDevice.Stop();
            }
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
}