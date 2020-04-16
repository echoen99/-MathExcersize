namespace MathExcersize
{
  partial class FormMain
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
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.uxAtemptResult = new System.Windows.Forms.Label();
      this.uxInputResultTextBox = new System.Windows.Forms.TextBox();
      this.uxEquationLabel = new System.Windows.Forms.Label();
      this.uxTimeProgressBar = new System.Windows.Forms.ProgressBar();
      this.panel2 = new System.Windows.Forms.Panel();
      this.listTopChallenge = new System.Windows.Forms.ListView();
      this.colHdrEquation = new System.Windows.Forms.ColumnHeader();
      this.colHdrTime = new System.Windows.Forms.ColumnHeader();
      this.uxTopChallengeLabel = new System.Windows.Forms.Label();
      this.uxStartStopButton = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.uxAtemptResult);
      this.panel1.Controls.Add(this.uxInputResultTextBox);
      this.panel1.Controls.Add(this.uxEquationLabel);
      this.panel1.Controls.Add(this.uxTimeProgressBar);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(522, 209);
      this.panel1.TabIndex = 2;
      // 
      // uxAtemptResult
      // 
      this.uxAtemptResult.AutoSize = true;
      this.uxAtemptResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.uxAtemptResult.Location = new System.Drawing.Point(35, 116);
      this.uxAtemptResult.Name = "uxAtemptResult";
      this.uxAtemptResult.Size = new System.Drawing.Size(172, 32);
      this.uxAtemptResult.TabIndex = 6;
      this.uxAtemptResult.Text = "Attempt Result";
      // 
      // uxInputResultTextBox
      // 
      this.uxInputResultTextBox.BackColor = System.Drawing.SystemColors.Control;
      this.uxInputResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.uxInputResultTextBox.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.uxInputResultTextBox.Location = new System.Drawing.Point(257, 26);
      this.uxInputResultTextBox.MaxLength = 2;
      this.uxInputResultTextBox.Name = "uxInputResultTextBox";
      this.uxInputResultTextBox.Size = new System.Drawing.Size(83, 67);
      this.uxInputResultTextBox.TabIndex = 1;
      this.uxInputResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxInputResultTextBox_KeyPress);
      // 
      // uxEquationLabel
      // 
      this.uxEquationLabel.AutoSize = true;
      this.uxEquationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.uxEquationLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.uxEquationLabel.Location = new System.Drawing.Point(35, 26);
      this.uxEquationLabel.Name = "uxEquationLabel";
      this.uxEquationLabel.Size = new System.Drawing.Size(216, 67);
      this.uxEquationLabel.TabIndex = 0;
      this.uxEquationLabel.Text = "Equation";
      // 
      // uxTimeProgressBar
      // 
      this.uxTimeProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.uxTimeProgressBar.Location = new System.Drawing.Point(0, 186);
      this.uxTimeProgressBar.Name = "uxTimeProgressBar";
      this.uxTimeProgressBar.Size = new System.Drawing.Size(522, 23);
      this.uxTimeProgressBar.TabIndex = 5;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.listTopChallenge);
      this.panel2.Controls.Add(this.uxTopChallengeLabel);
      this.panel2.Location = new System.Drawing.Point(540, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(307, 426);
      this.panel2.TabIndex = 3;
      // 
      // listTopChallenge
      // 
      this.listTopChallenge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHdrEquation,
            this.colHdrTime});
      this.listTopChallenge.HideSelection = false;
      this.listTopChallenge.Location = new System.Drawing.Point(0, 59);
      this.listTopChallenge.Name = "listTopChallenge";
      this.listTopChallenge.Size = new System.Drawing.Size(307, 367);
      this.listTopChallenge.TabIndex = 0;
      this.listTopChallenge.UseCompatibleStateImageBehavior = false;
      // 
      // colHdrEquation
      // 
      this.colHdrEquation.Name = "colHdrEquation";
      this.colHdrEquation.Text = "Equation";
      // 
      // colHdrTime
      // 
      this.colHdrTime.Name = "colHdrTime";
      this.colHdrTime.Text = "Time";
      // 
      // uxTopChallengeLabel
      // 
      this.uxTopChallengeLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.uxTopChallengeLabel.Location = new System.Drawing.Point(0, 0);
      this.uxTopChallengeLabel.Name = "uxTopChallengeLabel";
      this.uxTopChallengeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.uxTopChallengeLabel.Size = new System.Drawing.Size(307, 59);
      this.uxTopChallengeLabel.TabIndex = 1;
      this.uxTopChallengeLabel.Text = "אתגרים";
      this.uxTopChallengeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // uxStartStopButton
      // 
      this.uxStartStopButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.uxStartStopButton.Location = new System.Drawing.Point(115, 369);
      this.uxStartStopButton.Name = "uxStartStopButton";
      this.uxStartStopButton.Size = new System.Drawing.Size(237, 69);
      this.uxStartStopButton.TabIndex = 4;
      this.uxStartStopButton.Text = "Start";
      this.uxStartStopButton.UseVisualStyleBackColor = true;
      this.uxStartStopButton.Click += new System.EventHandler(this.uxStartStopButton_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(859, 447);
      this.Controls.Add(this.uxStartStopButton);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FormMain";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox uxInputResultTextBox;
        private System.Windows.Forms.Label uxEquationLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listTopChallenge;
        private System.Windows.Forms.ColumnHeader colHdrEquation;
        private System.Windows.Forms.ColumnHeader colHdrTime;
        private System.Windows.Forms.Button uxStartStopButton;
        private System.Windows.Forms.Label uxTopChallengeLabel;
        private System.Windows.Forms.ProgressBar uxTimeProgressBar;
        private System.Windows.Forms.Label uxAtemptResult;
        private System.Windows.Forms.Timer timer1;
    }
}

