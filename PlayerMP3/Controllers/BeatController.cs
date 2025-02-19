using PlayerMP3.Models;

namespace PlayerMP3.Controllers;

public class BeatController : IController
{
    private readonly IBeatModel _model;
    private readonly DJView _view;

    public BeatController(IBeatModel model)
    {
        _model = model;
        _view = new DJView(this, model);
        _view.DisableStopMenuItem();
        _view.EnableStartMenuItem();
        _model.Initialize();
    }

    public void Start()
    {
        _model.On();
        _view.DisableStartMenuItem();
        _view.EnableStopMenuItem();
    }

    public void Stop()
    {
        _model.Off();
        _view.DisableStopMenuItem();
        _view.EnableStartMenuItem();
    }

    public void IncreaseBPM()
    {
        int bpm = _model.GetBPM();
        _model.SetBPM(bpm++);
    }


    public void DecreaseBPM()
    {
        int bpm = _model.GetBPM();
        _model.SetBPM(bpm--);
    }


    public void SetBPM(int bpm)
    {
        _model.SetBPM(bpm);
    }

    public Form GetView()
    {
        return _view;
    }
}