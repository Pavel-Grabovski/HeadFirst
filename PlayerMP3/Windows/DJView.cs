using PlayerMP3.Controllers;
using PlayerMP3.Models;

namespace PlayerMP3;

public partial class DJView : Form, IBeatObserver, IBPMObserver
{
    private readonly IController _controller;
    private readonly IBeatModel _model;
    public DJView(IController controller, IBeatModel beatModel)
    {
        InitializeComponent();
        _controller = controller;
        _model = beatModel;

        _model.RegisterObserver((IBeatObserver)this);
        _model.RegisterObserver((IBeatObserver)this);
    }

    public void UpdateBPM()
    {
        int bpm = _model.GetBPM();

        if (bpm == 0)
            bpmOutputLabel.Text = "Offline";
        else
            bpmOutputLabel.Text = $"Current BPM: {bpm}";
    }

    public void UpdateBeat()
    {
        beatBar.Value = 100;
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

    private void IncreaseButtonClick(object sender, EventArgs e)
    {
        _controller.IncreaseBPM();
    }

    private void DecreaseButtonClick(object sender, EventArgs e)
    {
        _controller.DecreaseBPM();
    }

    private void SetButtonClick(object sender, EventArgs e)
    {
        int bpm = 0;
        bool IsNum = int.TryParse(bpmTextBox.Text, out bpm);

        if(IsNum)
            _controller.SetBPM(bpm);
    }
}
