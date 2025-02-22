

namespace PlayerMP3;

partial class DJView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DJView));
        menuStrip1 = new MenuStrip();
        dJControlToolStripMenuItem = new ToolStripMenuItem();
        _startToolStripMenuItem = new ToolStripMenuItem();
        _pauseToolStripMenuItem = new ToolStripMenuItem();
        _stopToolStripMenuItem = new ToolStripMenuItem();
        _exitToolStripMenuItem = new ToolStripMenuItem();
        groupBox1 = new GroupBox();
        _volumeTrackBar = new TrackBar();
        groupBox3 = new GroupBox();
        label1 = new Label();
        label3 = new Label();
        _longMusicLabel = new Label();
        _musicNameLabel = new Label();
        _positionMusicLabel = new Label();
        _longMusicPlayersProgressBar = new ProgressBar();
        menuStrip1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_volumeTrackBar).BeginInit();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { dJControlToolStripMenuItem });
        resources.ApplyResources(menuStrip1, "menuStrip1");
        menuStrip1.Name = "menuStrip1";
        // 
        // dJControlToolStripMenuItem
        // 
        dJControlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _startToolStripMenuItem, _pauseToolStripMenuItem, _stopToolStripMenuItem, _exitToolStripMenuItem });
        dJControlToolStripMenuItem.Name = "dJControlToolStripMenuItem";
        resources.ApplyResources(dJControlToolStripMenuItem, "dJControlToolStripMenuItem");
        // 
        // _startToolStripMenuItem
        // 
        _startToolStripMenuItem.Name = "_startToolStripMenuItem";
        resources.ApplyResources(_startToolStripMenuItem, "_startToolStripMenuItem");
        _startToolStripMenuItem.Click += StartToolStripMenuItemClick;
        // 
        // _pauseToolStripMenuItem
        // 
        _pauseToolStripMenuItem.Name = "_pauseToolStripMenuItem";
        resources.ApplyResources(_pauseToolStripMenuItem, "_pauseToolStripMenuItem");
        _pauseToolStripMenuItem.Click += PauseToolStripMenuItemClick;
        // 
        // _stopToolStripMenuItem
        // 
        _stopToolStripMenuItem.Name = "_stopToolStripMenuItem";
        resources.ApplyResources(_stopToolStripMenuItem, "_stopToolStripMenuItem");
        _stopToolStripMenuItem.Click += StopToolStripMenuItemClick;
        // 
        // _exitToolStripMenuItem
        // 
        _exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
        resources.ApplyResources(_exitToolStripMenuItem, "_exitToolStripMenuItem");
        _exitToolStripMenuItem.Click += ExitToolStripMenuItemClick;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(_volumeTrackBar);
        resources.ApplyResources(groupBox1, "groupBox1");
        groupBox1.Name = "groupBox1";
        groupBox1.TabStop = false;
        // 
        // _volumeTrackBar
        // 
        resources.ApplyResources(_volumeTrackBar, "_volumeTrackBar");
        _volumeTrackBar.Maximum = 20;
        _volumeTrackBar.Name = "_volumeTrackBar";
        _volumeTrackBar.Value = 10;
        _volumeTrackBar.Scroll += VolumeTrackBarScroll;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label1);
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(_longMusicLabel);
        groupBox3.Controls.Add(_musicNameLabel);
        groupBox3.Controls.Add(_positionMusicLabel);
        groupBox3.Controls.Add(_longMusicPlayersProgressBar);
        resources.ApplyResources(groupBox3, "groupBox3");
        groupBox3.Name = "groupBox3";
        groupBox3.TabStop = false;
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
        // 
        // label3
        // 
        resources.ApplyResources(label3, "label3");
        label3.Name = "label3";
        // 
        // _longMusicLabel
        // 
        resources.ApplyResources(_longMusicLabel, "_longMusicLabel");
        _longMusicLabel.Name = "_longMusicLabel";
        // 
        // _musicNameLabel
        // 
        resources.ApplyResources(_musicNameLabel, "_musicNameLabel");
        _musicNameLabel.Name = "_musicNameLabel";
        // 
        // _positionMusicLabel
        // 
        resources.ApplyResources(_positionMusicLabel, "_positionMusicLabel");
        _positionMusicLabel.Name = "_positionMusicLabel";
        // 
        // _longMusicPlayersProgressBar
        // 
        resources.ApplyResources(_longMusicPlayersProgressBar, "_longMusicPlayersProgressBar");
        _longMusicPlayersProgressBar.Name = "_longMusicPlayersProgressBar";
        // 
        // DJView
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox3);
        Controls.Add(groupBox1);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.None;
        MainMenuStrip = menuStrip1;
        Name = "DJView";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_volumeTrackBar).EndInit();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private MenuStrip menuStrip1;
    private ToolStripMenuItem dJControlToolStripMenuItem;
    private ToolStripMenuItem _startToolStripMenuItem;
    private ToolStripMenuItem _stopToolStripMenuItem;
    private ToolStripMenuItem _exitToolStripMenuItem;
    private GroupBox groupBox1;
    private Label label1;
    private GroupBox groupBox3;
    private Label _positionMusicLabel;
    private ProgressBar _longMusicPlayersProgressBar;
    private Label _longMusicLabel;
    private Label _musicNameLabel;
    private Label label3;
    private TrackBar _volumeTrackBar;
    private ToolStripMenuItem _pauseToolStripMenuItem;
}
