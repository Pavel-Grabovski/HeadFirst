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
        label1 = new Label();
        label2 = new Label();
        SoundFrequencyTextBox = new TextBox();
        SetButton = new Button();
        DecreaseButton = new Button();
        IncreaseButton = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
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
        // Control
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(IncreaseButton);
        Controls.Add(DecreaseButton);
        Controls.Add(SetButton);
        Controls.Add(SoundFrequencyTextBox);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Name = "Control";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox SoundFrequencyTextBox;
    private Button SetButton;
    private Button DecreaseButton;
    private Button IncreaseButton;
}
