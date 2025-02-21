using PlayerMP3.Controllers;
using PlayerMP3.Models;

namespace PlayerMP3;

public partial class DJView : Form, ILongMusicPlayerObserver, IMusicInfoObserver
{
    private readonly IController _controller;
    private readonly IPlayerModel _model;

    private MusicInfo _musicInfo = new()
    { 
        Name = string.Empty,
        Path = string.Empty,
        PlayingTime = TimeSpan.Zero
    };

    public DJView(IController controller, IPlayerModel beatModel)
    {
        InitializeComponent();
        _controller = controller;
        _model = beatModel;

        _model.RegisterObserver((ILongMusicPlayerObserver)this);
        _model.RegisterObserver((IMusicInfoObserver)this);
    }

    public void UpdateLongMusicPlayer(TimeSpan position)
    {
        try
        {
            _positionMusicLabel.Text = $"{position.Minutes}:{position.Seconds}";

            int percent = (int)(position / _musicInfo.PlayingTime * 100);

            _longMusicPlayersProgressBar.Value = percent;
        }
        catch(DivideByZeroException ex) 
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void UpdateMusicInfo(MusicInfo musicInfo)
    {
        if (_musicInfo == null) return;

        _musicInfo = musicInfo;
        _musicNameLabel.Text = musicInfo.Name;
        _longMusicLabel.Text =
            $"{musicInfo.PlayingTime.Minutes}:{musicInfo.PlayingTime.Seconds}";
    }

    private void stopToolStripMenuItemClick(object sender, EventArgs e)
    {
        _controller.Stop();
    }

    private void startToolStripMenuItemClick(object sender, EventArgs e)
    {
        _controller.Start();
    }

    public void EnableStopMenuItem()
    {
        stopToolStripMenuItem.Enabled = true;
    }

    public void DisableStopMenuItem()
    {
        stopToolStripMenuItem.Enabled = false;
    }

    public void EnableStartMenuItem()
    {
        startToolStripMenuItem.Enabled = true;
    }

    public void DisableStartMenuItem()
    {
        startToolStripMenuItem.Enabled = false;
    }

    private void OuitToolStripMenuItemClick(object sender, EventArgs e)
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
