using NAudio.Wave;

namespace PlayerMP3.Models;

public class BeatModel : IBeatModel
{
    private List<IBeatObserver> beatObserver = new List<IBeatObserver>();
    private List<IBPMObserver> bpmObservers = new List<IBPMObserver>();

    int bpm = 90;
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
        //bpm = 90;
        //NotifyBPMObservers();
        //thread = new Thread(this);
        //stop = false;
        //thread.start();
    }

    public void Off()
    {
        throw new NotImplementedException();
    }


    public void Run()
    {
        throw new NotImplementedException();

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
        return bpm;
    }

    public void SetBPM(int bpm)
    {
        throw new NotImplementedException();
    }


    public void RegisterObserver(IBeatObserver observer)
    {
        throw new NotImplementedException();
    }

    public void RegisterObserver(IBPMObserver observer)
    {
        throw new NotImplementedException();
    }

    public void RemoveObserver(IBeatObserver observer)
    {
        throw new NotImplementedException();
    }

    public void RemoveObserver(IBPMObserver observer)
    {
        throw new NotImplementedException();
    }

    private void NotifyBPMObservers()
    {
        throw new NotImplementedException();
    }
}