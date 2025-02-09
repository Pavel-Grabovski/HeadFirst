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

}
