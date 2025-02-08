namespace PlayerMP3;

partial class Control
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
        label2 = new Label();
        SoundFrequencyTextBox = new TextBox();
        SetButton = new Button();
        DecreaseButton = new Button();
        IncreaseButton = new Button();
        menuStrip1 = new MenuStrip();
        dJControlToolStripMenuItem = new ToolStripMenuItem();
        startToolStripMenuItem = new ToolStripMenuItem();
        stopToolStripMenuItem = new ToolStripMenuItem();
        quitToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // label2
        // 
        resources.ApplyResources(label2, "label2");
        label2.Name = "label2";
        // 
        // SoundFrequencyTextBox
        // 
        resources.ApplyResources(SoundFrequencyTextBox, "SoundFrequencyTextBox");
        SoundFrequencyTextBox.Name = "SoundFrequencyTextBox";
        // 
        // SetButton
        // 
        resources.ApplyResources(SetButton, "SetButton");
        SetButton.Name = "SetButton";
        SetButton.UseVisualStyleBackColor = true;
        // 
        // DecreaseButton
        // 
        resources.ApplyResources(DecreaseButton, "DecreaseButton");
        DecreaseButton.Name = "DecreaseButton";
        DecreaseButton.UseVisualStyleBackColor = true;
        // 
        // IncreaseButton
        // 
        resources.ApplyResources(IncreaseButton, "IncreaseButton");
        IncreaseButton.Name = "IncreaseButton";
        IncreaseButton.UseVisualStyleBackColor = true;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { dJControlToolStripMenuItem });
        resources.ApplyResources(menuStrip1, "menuStrip1");
        menuStrip1.Name = "menuStrip1";
        // 
        // dJControlToolStripMenuItem
        // 
        dJControlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem, quitToolStripMenuItem });
        dJControlToolStripMenuItem.Name = "dJControlToolStripMenuItem";
        resources.ApplyResources(dJControlToolStripMenuItem, "dJControlToolStripMenuItem");
        // 
        // startToolStripMenuItem
        // 
        startToolStripMenuItem.Name = "startToolStripMenuItem";
        resources.ApplyResources(startToolStripMenuItem, "startToolStripMenuItem");
        // 
        // stopToolStripMenuItem
        // 
        stopToolStripMenuItem.Name = "stopToolStripMenuItem";
        resources.ApplyResources(stopToolStripMenuItem, "stopToolStripMenuItem");
        // 
        // quitToolStripMenuItem
        // 
        quitToolStripMenuItem.Name = "quitToolStripMenuItem";
        resources.ApplyResources(quitToolStripMenuItem, "quitToolStripMenuItem");
        // 
        // Control
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(IncreaseButton);
        Controls.Add(DecreaseButton);
        Controls.Add(SetButton);
        Controls.Add(SoundFrequencyTextBox);
        Controls.Add(label2);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        MainMenuStrip = menuStrip1;
        Name = "Control";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label2;
    private TextBox SoundFrequencyTextBox;
    private Button SetButton;
    private Button DecreaseButton;
    private Button IncreaseButton;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem dJControlToolStripMenuItem;
    private ToolStripMenuItem startToolStripMenuItem;
    private ToolStripMenuItem stopToolStripMenuItem;
    private ToolStripMenuItem quitToolStripMenuItem;
}
