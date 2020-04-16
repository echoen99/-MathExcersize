using MathExcersize.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathExcersize
{

  public partial class FormMain : Form
  {
    private const int NUM_MIN_VALUE = 2;
    private const int NUM_MAX_VALUE = 9;
    private Equation currentEquation = null;
    public FormMain()
    {
      InitializeComponent();
      initForm();
    }

    private void initForm()
    {
      timer1.Enabled = false;
      timer1.Interval = 100;
      uxTimeProgressBar.Minimum = 0;
      uxTimeProgressBar.Maximum = 100; // 10 sec = 100 times 100ms (interval)
      uxTimeProgressBar.Value = 0;
    }

    private void uxStartStopButton_Click(object sender, EventArgs e)
    {
      SetNewCurrentEquation();
    }

    private void SetNewCurrentEquation()
    {
      var rnd = new Random();
      int num1 = rnd.Next(NUM_MIN_VALUE, NUM_MAX_VALUE + 1);
      int num2 = rnd.Next(NUM_MIN_VALUE, NUM_MAX_VALUE + 1);

      currentEquation = new Model.Equation(num1, num2, Operation.Multipling);

      UpdateUI(currentEquation);
    }

    private void UpdateUI(Equation equation)
    {
      uxEquationLabel.Text = equation.ToString();
      UpdateResultFieldsPosition();

      RunWaitingForAnswerProgressBar(3);
    }

    private void UpdateResultFieldsPosition()
    {
      uxInputResultTextBox.Left = uxEquationLabel.Left + uxEquationLabel.Width;
    }

    private void RunWaitingForAnswerProgressBar(int timeoutInSec)
    {
      uxTimeProgressBar.Value = 0;
      uxTimeProgressBar.Minimum = 0;
      uxTimeProgressBar.Maximum = timeoutInSec * (timer1.Interval / 10); // interval == 100ms
      uxTimeProgressBar.Step = 1;
      timer1.Start();
    }

    private void ShowResult(bool wasAnswerInTime)
    {
      if (wasAnswerInTime)
      {
        uxAtemptResult.Text = "Well done!!";
      }
      else
      {
        uxAtemptResult.Text = $"Time's up :(, correct answer is: {currentEquation.Result}";
        
      }
    }

    private void uxInputResultTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {

    }
  }
}
