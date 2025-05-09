﻿namespace PlayerMP3.Controllers;

public class PlayerController : IController
{
    private readonly IPlayerModel _model;
    private readonly DJView _view;

    public PlayerController(IPlayerModel model)
    {
        _model = model;
        _view = new DJView(this, model);
        _view.DisableStopMenuItem();
        _view.DisablePauseMenuItem();
        _view.EnableStartMenuItem();
        _view.Show();
    }

    public void Start(IProgress<TimeSpan>? progress = null)
    {
        _model.On(progress);
        _view.DisableStartMenuItem();
        _view.EnableStopMenuItem();
        _view.EnablePauseMenuItem();
    }

    public void Pause()
    {
        _model.Pause();
        _view.DisablePauseMenuItem();
        _view.EnableStartMenuItem();

    }

    public void Stop()
    {
        _model.Off();
        _view.DisableStopMenuItem();
        _view.EnableStartMenuItem();
        _view.DisablePauseMenuItem();
        _view.SetSelectDefaultMusicInfo();
    }

    public void SetVolume(int volume)
    {
        float convertedValue = (float)volume / 20;
        _model.SetVolume(convertedValue);
    }
}