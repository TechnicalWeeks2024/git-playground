namespace Task2
{
  partial class Form1
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
      components = new System.ComponentModel.Container();
      dataLabel = new Label();
      submitDataButton = new Button();
      maskedTextBox1 = new MaskedTextBox();
      toolTip1 = new ToolTip(components);
      label1 = new Label();
      label2 = new Label();
      dayLabel = new Label();
      daysDisplayLabel = new Label();
      hoursDisplayLabel = new Label();
      hourLabel = new Label();
      secondsDisplayLabel = new Label();
      secondLabel = new Label();
      minutesDisplayLabel = new Label();
      minuteLabel = new Label();
      SuspendLayout();
      // 
      // dataLabel
      // 
      dataLabel.AutoSize = true;
      dataLabel.Location = new Point(163, 226);
      dataLabel.Margin = new Padding(7, 0, 7, 0);
      dataLabel.Name = "dataLabel";
      dataLabel.Size = new Size(80, 37);
      dataLabel.TabIndex = 3;
      dataLabel.Text = "Дата";
      // 
      // submitDataButton
      // 
      submitDataButton.Location = new Point(259, 277);
      submitDataButton.Margin = new Padding(7);
      submitDataButton.Name = "submitDataButton";
      submitDataButton.Size = new Size(475, 114);
      submitDataButton.TabIndex = 2;
      submitDataButton.Text = "Результат";
      submitDataButton.UseVisualStyleBackColor = true;
      submitDataButton.Click += submitDataButton_Click;
      // 
      // maskedTextBox1
      // 
      maskedTextBox1.Location = new Point(259, 220);
      maskedTextBox1.Margin = new Padding(7);
      maskedTextBox1.Mask = "00.00.0000 00:00:00";
      maskedTextBox1.Name = "maskedTextBox1";
      maskedTextBox1.Size = new Size(475, 43);
      maskedTextBox1.TabIndex = 0;
      // 
      // toolTip1
      // 
      toolTip1.IsBalloon = true;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(753, 301);
      label1.Margin = new Padding(7, 0, 7, 0);
      label1.Name = "label1";
      label1.Size = new Size(0, 37);
      label1.TabIndex = 5;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(753, 301);
      label2.Margin = new Padding(7, 0, 7, 0);
      label2.Name = "label2";
      label2.Size = new Size(24, 37);
      label2.TabIndex = 6;
      label2.Text = " ";
      // 
      // dayLabel
      // 
      dayLabel.AutoSize = true;
      dayLabel.Location = new Point(319, 402);
      dayLabel.Margin = new Padding(7, 0, 7, 0);
      dayLabel.Name = "dayLabel";
      dayLabel.Size = new Size(63, 37);
      dayLabel.TabIndex = 7;
      dayLabel.Text = "Дні";
      // 
      // daysDisplayLabel
      // 
      daysDisplayLabel.AutoSize = true;
      daysDisplayLabel.Location = new Point(575, 402);
      daysDisplayLabel.Margin = new Padding(7, 0, 7, 0);
      daysDisplayLabel.Name = "daysDisplayLabel";
      daysDisplayLabel.Size = new Size(0, 37);
      daysDisplayLabel.TabIndex = 8;
      // 
      // hoursDisplayLabel
      // 
      hoursDisplayLabel.AutoSize = true;
      hoursDisplayLabel.Location = new Point(575, 454);
      hoursDisplayLabel.Margin = new Padding(7, 0, 7, 0);
      hoursDisplayLabel.Name = "hoursDisplayLabel";
      hoursDisplayLabel.Size = new Size(0, 37);
      hoursDisplayLabel.TabIndex = 10;
      // 
      // hourLabel
      // 
      hourLabel.AutoSize = true;
      hourLabel.Location = new Point(319, 454);
      hourLabel.Margin = new Padding(7, 0, 7, 0);
      hourLabel.Name = "hourLabel";
      hourLabel.Size = new Size(114, 37);
      hourLabel.TabIndex = 9;
      hourLabel.Text = "Години";
      // 
      // secondsDisplayLabel
      // 
      secondsDisplayLabel.AutoSize = true;
      secondsDisplayLabel.Location = new Point(575, 564);
      secondsDisplayLabel.Margin = new Padding(7, 0, 7, 0);
      secondsDisplayLabel.Name = "secondsDisplayLabel";
      secondsDisplayLabel.Size = new Size(0, 37);
      secondsDisplayLabel.TabIndex = 14;
      // 
      // secondLabel
      // 
      secondLabel.AutoSize = true;
      secondLabel.Location = new Point(319, 564);
      secondLabel.Margin = new Padding(7, 0, 7, 0);
      secondLabel.Name = "secondLabel";
      secondLabel.Size = new Size(130, 37);
      secondLabel.TabIndex = 13;
      secondLabel.Text = "Секунди";
      // 
      // minutesDisplayLabel
      // 
      minutesDisplayLabel.AutoSize = true;
      minutesDisplayLabel.Location = new Point(575, 506);
      minutesDisplayLabel.Margin = new Padding(7, 0, 7, 0);
      minutesDisplayLabel.Name = "minutesDisplayLabel";
      minutesDisplayLabel.Size = new Size(0, 37);
      minutesDisplayLabel.TabIndex = 12;
      // 
      // minuteLabel
      // 
      minuteLabel.AutoSize = true;
      minuteLabel.Location = new Point(319, 506);
      minuteLabel.Margin = new Padding(7, 0, 7, 0);
      minuteLabel.Name = "minuteLabel";
      minuteLabel.Size = new Size(135, 37);
      minuteLabel.TabIndex = 11;
      minuteLabel.Text = "Хвилини";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(16F, 37F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(987, 677);
      Controls.Add(secondsDisplayLabel);
      Controls.Add(secondLabel);
      Controls.Add(minutesDisplayLabel);
      Controls.Add(minuteLabel);
      Controls.Add(hoursDisplayLabel);
      Controls.Add(hourLabel);
      Controls.Add(daysDisplayLabel);
      Controls.Add(dayLabel);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(maskedTextBox1);
      Controls.Add(submitDataButton);
      Controls.Add(dataLabel);
      Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
      Margin = new Padding(7);
      Name = "Form1";
      Text = "Form1";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label dataLabel;
    private TextBox textBox1;
    private Button submitDataButton;
    private MaskedTextBox maskedTextBox1;
    private ToolTip toolTip1;
    private Label label1;
    private Label label2;
    private Label dayLabel;
    private Label daysDisplayLabel;
    private Label hoursDisplayLabel;
    private Label hourLabel;
    private Label secondsDisplayLabel;
    private Label secondLabel;
    private Label minutesDisplayLabel;
    private Label minuteLabel;
  }
}