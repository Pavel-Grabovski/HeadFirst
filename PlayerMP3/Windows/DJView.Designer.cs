

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
        label2 = new Label();
        bpmTextBox = new TextBox();
        SetButton = new Button();
        DecreaseButton = new Button();
        IncreaseButton = new Button();
        menuStrip1 = new MenuStrip();
        dJControlToolStripMenuItem = new ToolStripMenuItem();
        startToolStripMenuItem = new ToolStripMenuItem();
        stopToolStripMenuItem = new ToolStripMenuItem();
        ouitToolStripMenuItem = new ToolStripMenuItem();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        bpmOutputLabel = new Label();
        beatBar = new ProgressBar();
        groupBox3 = new GroupBox();
        label1 = new Label();
        _timerLabel = new Label();
        _longMusicPlayersProgressBar = new ProgressBar();
        menuStrip1.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // label2
        // 
        resources.ApplyResources(label2, "label2");
        label2.Name = "label2";
        // 
        // bpmTextBox
        // 
        resources.ApplyResources(bpmTextBox, "bpmTextBox");
        bpmTextBox.Name = "bpmTextBox";
        // 
        // SetButton
        // 
        resources.ApplyResources(SetButton, "SetButton");
        SetButton.Name = "SetButton";
        SetButton.UseVisualStyleBackColor = true;
        SetButton.Click += SetButtonClick;
        // 
        // DecreaseButton
        // 
        resources.ApplyResources(DecreaseButton, "DecreaseButton");
        DecreaseButton.Name = "DecreaseButton";
        DecreaseButton.UseVisualStyleBackColor = true;
        DecreaseButton.Click += DecreaseButtonClick;
        // 
        // IncreaseButton
        // 
        resources.ApplyResources(IncreaseButton, "IncreaseButton");
        IncreaseButton.Name = "IncreaseButton";
        IncreaseButton.UseVisualStyleBackColor = true;
        IncreaseButton.Click += IncreaseButtonClick;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { dJControlToolStripMenuItem });
        resources.ApplyResources(menuStrip1, "menuStrip1");
        menuStrip1.Name = "menuStrip1";
        // 
        // dJControlToolStripMenuItem
        // 
        dJControlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem, ouitToolStripMenuItem });
        dJControlToolStripMenuItem.Name = "dJControlToolStripMenuItem";
        resources.ApplyResources(dJControlToolStripMenuItem, "dJControlToolStripMenuItem");
        // 
        // startToolStripMenuItem
        // 
        startToolStripMenuItem.Name = "startToolStripMenuItem";
        resources.ApplyResources(startToolStripMenuItem, "startToolStripMenuItem");
        startToolStripMenuItem.Click += startToolStripMenuItemClick;
        // 
        // stopToolStripMenuItem
        // 
        stopToolStripMenuItem.Name = "stopToolStripMenuItem";
        resources.ApplyResources(stopToolStripMenuItem, "stopToolStripMenuItem");
        stopToolStripMenuItem.Click += stopToolStripMenuItemClick;
        // 
        // ouitToolStripMenuItem
        // 
        ouitToolStripMenuItem.Name = "ouitToolStripMenuItem";
        resources.ApplyResources(ouitToolStripMenuItem, "ouitToolStripMenuItem");
        ouitToolStripMenuItem.Click += OuitToolStripMenuItemClick;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(IncreaseButton);
        groupBox1.Controls.Add(bpmTextBox);
        groupBox1.Controls.Add(DecreaseButton);
        groupBox1.Controls.Add(SetButton);
        resources.ApplyResources(groupBox1, "groupBox1");
        groupBox1.Name = "groupBox1";
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(bpmOutputLabel);
        groupBox2.Controls.Add(beatBar);
        resources.ApplyResources(groupBox2, "groupBox2");
        groupBox2.Name = "groupBox2";
        groupBox2.TabStop = false;
        // 
        // bpmOutputLabel
        // 
        resources.ApplyResources(bpmOutputLabel, "bpmOutputLabel");
        bpmOutputLabel.Name = "bpmOutputLabel";
        // 
        // beatBar
        // 
        resources.ApplyResources(beatBar, "beatBar");
        beatBar.Name = "beatBar";
        beatBar.Value = 100;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label1);
        groupBox3.Controls.Add(_timerLabel);
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
        // _timerLabel
        // 
        resources.ApplyResources(_timerLabel, "_timerLabel");
        _timerLabel.Name = "_timerLabel";
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
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        MainMenuStrip = menuStrip1;
        Name = "DJView";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label2;
    private TextBox bpmTextBox;
    private Button SetButton;
    private Button DecreaseButton;
    private Button IncreaseButton;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem dJControlToolStripMenuItem;
    private ToolStripMenuItem startToolStripMenuItem;
    private ToolStripMenuItem stopToolStripMenuItem;
    private ToolStripMenuItem ouitToolStripMenuItem;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label1;
    private Label bpmOutputLabel;
    private ProgressBar beatBar;
    private GroupBox groupBox3;
    private Label _timerLabel;
    private ProgressBar _longMusicPlayersProgressBar;
}
