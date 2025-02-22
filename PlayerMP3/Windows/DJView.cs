using PlayerMP3.Controllers;
using PlayerMP3.Models;

namespace PlayerMP3;

public partial class DJView : Form, ILongMusicPlayerObserver, IMusicInfoObserver
{
    private readonly IController _controller;
    private readonly IPlayerModel _model;

    private readonly MusicInfo _defaultMusicInfo = new()
    {
        Name = string.Empty,
        Path = string.Empty,
        PlayingTime = TimeSpan.Zero
    };

    private MusicInfo _selectMusicInfo;

    public DJView(IController controller, IPlayerModel beatModel)
    {
        InitializeComponent();
        _controller = controller;
        _model = beatModel;

        _selectMusicInfo = _defaultMusicInfo;

        _model.RegisterObserver((ILongMusicPlayerObserver)this);
        _model.RegisterObserver((IMusicInfoObserver)this);
    }

    public void UpdateLongMusicPlayer(TimeSpan position)
    {
        try
        {
            _positionMusicLabel.Text = $"{position.Minutes}:{position.Seconds}";

            int percent = (int)(position / _selectMusicInfo.PlayingTime * 100);

            _longMusicPlayersProgressBar.Value = percent;
        }
        catch (DivideByZeroException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void UpdateMusicInfo(MusicInfo musicInfo)
    {
        if (_selectMusicInfo == null) return;

        _selectMusicInfo = musicInfo;
        _musicNameLabel.Text = musicInfo.Name;
        _longMusicLabel.Text =
            $"{musicInfo.PlayingTime.Minutes}:{musicInfo.PlayingTime.Seconds}";
    }

    private void StartToolStripMenuItemClick(object sender, EventArgs e)
    {
        _controller.Start();
    }

    private void PauseToolStripMenuItemClick(object sender, EventArgs e)
    {
        _controller.Pause();
    }
    private void StopToolStripMenuItemClick(object sender, EventArgs e)
    {
        _controller.Stop();
    }

    public void EnableStopMenuItem()
    {
        _stopToolStripMenuItem.Enabled = true;
    }

    public void DisableStopMenuItem()
    {
        _stopToolStripMenuItem.Enabled = false;
    }

    public void EnableStartMenuItem()
    {
        _startToolStripMenuItem.Enabled = true;
    }

    public void DisableStartMenuItem()
    {
        _startToolStripMenuItem.Enabled = false;
    }

    public void EnablePauseMenuItem()
    {
        _pauseToolStripMenuItem.Enabled = true;
    }

    public void DisablePauseMenuItem()
    {
        _pauseToolStripMenuItem.Enabled = false;
    }

    public void SetSelectDefaultMusicInfo()
    {
        _selectMusicInfo = _defaultMusicInfo;
    }

    private void ExitToolStripMenuItemClick(object sender, EventArgs e)
    {
        _controller.Stop();
        _controller.Dispose();
        _model.Dispose();
        this.Dispose();
        Application.Exit();
    }

    private void VolumeTrackBarScroll(object sender, EventArgs e)
    {
        _controller.SetVolume(_volumeTrackBar.Value);
    }

}
