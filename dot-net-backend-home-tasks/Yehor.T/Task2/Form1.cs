using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace Task2
{
  public partial class Form1 : Form
  {
    private bool _flag;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      maskedTextBox1.ValidatingType = typeof(System.DateTime);
      maskedTextBox1.TypeValidationCompleted += new TypeValidationEventHandler(MaskedTextBox1_TypeValidationCompleted);
      maskedTextBox1.TextChanged += MaskedTextBox1_TextChanged;
    }

    private void MaskedTextBox1_TextChanged(object? sender, EventArgs e)
    {
      try
      {
        var result = CalcDiff();
        daysDisplayLabel.Text = result.Days.ToString();
        hoursDisplayLabel.Text = result.Hours.ToString();
        minutesDisplayLabel.Text = result.Minutes.ToString();
        secondsDisplayLabel.Text = result.Seconds.ToString();
      }
      catch (FormatException _) { }
    }

    private TimeSpan CalcDiff() =>
      DateTime.Now - DateTime.Parse(maskedTextBox1.Text);

    private void MaskedTextBox1_TypeValidationCompleted(object? sender, TypeValidationEventArgs e)
    {
      if (!e.IsValidInput)
      {
        toolTip1.Show("Date is invalid!", maskedTextBox1, 3000);
        _flag = false;
        return;
      }
      _flag = true;
    }

    private void submitDataButton_Click(object sender, EventArgs e)
    {
      if (_flag)
      {
        MessageBox.Show($"The result is {CalcDiff()}", "Result", MessageBoxButtons.OK);
      }
    }
  }
}