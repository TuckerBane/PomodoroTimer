namespace WindowsFormsTimer
{
    partial class PomodoroTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.TimeRemainingUpdater = new System.Windows.Forms.Timer(this.components);
            this.TimeRemainingLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.StartButton.Location = new System.Drawing.Point(161, 132);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(217, 82);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseUp);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(12, 340);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(157, 53);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Reset Round";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RestartRound_MouseUp);
            // 
            // TimeRemainingUpdater
            // 
            this.TimeRemainingUpdater.Enabled = true;
            this.TimeRemainingUpdater.Tick += new System.EventHandler(this.TimeRemainingUpdater_Tick_1);
            // 
            // TimeRemainingLabel
            // 
            this.TimeRemainingLabel.AutoSize = true;
            this.TimeRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemainingLabel.Location = new System.Drawing.Point(141, 9);
            this.TimeRemainingLabel.Name = "TimeRemainingLabel";
            this.TimeRemainingLabel.Size = new System.Drawing.Size(260, 120);
            this.TimeRemainingLabel.TabIndex = 2;
            this.TimeRemainingLabel.Text = "0:00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Restart Pattern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RestartPattern_MouseUp);
            // 
            // PomodoroTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeRemainingLabel);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Name = "PomodoroTimer";
            this.Text = "Pomodoro Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Timer TimeRemainingUpdater;
        private System.Windows.Forms.Label TimeRemainingLabel;
        private System.Windows.Forms.Button button1;
    }
}

