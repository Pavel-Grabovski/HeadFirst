using PlayerMP3.Models;

namespace PlayerMP3.Controllers;

public class PlayerController : IController
{
    private readonly IPlayerModel _model;
    private readonly DJView _view;

    public PlayerController(IPlayerModel model)
    {
        _model = model;
        _view = new DJView(this, model);
        _view.DisableStopMenuItem();
        _view.EnableStartMenuItem();
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

    public void SetVolume(int volume)
    {
        float convertedValue = (float)volume / 20;
        _model.SetVolume(convertedValue);
    }

    public Form GetView()
    {
        return _view;
    }

    public void Dispose()
    {
        _model?.Dispose();
        _view?.Dispose();
    }
}