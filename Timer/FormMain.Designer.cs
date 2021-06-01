namespace Timer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownRingTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRing = new System.Windows.Forms.CheckBox();
            this.checkBoxStop = new System.Windows.Forms.CheckBox();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.checkBoxReset = new System.Windows.Forms.CheckBox();
            this.buttonStopReset = new System.Windows.Forms.Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.checkTopMost = new System.Windows.Forms.CheckBox();
            this.checkBoxMessage = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonStart.Location = new System.Drawing.Point(205, 8);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(71, 25);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownRingTime
            // 
            this.numericUpDownRingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numericUpDownRingTime.Location = new System.Drawing.Point(116, 8);
            this.numericUpDownRingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownRingTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownRingTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownRingTime.Name = "numericUpDownRingTime";
            this.numericUpDownRingTime.Size = new System.Drawing.Size(40, 23);
            this.numericUpDownRingTime.TabIndex = 1;
            this.numericUpDownRingTime.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDownRingTime.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elapsed time:";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set Time:";
            // 
            // checkBoxRing
            // 
            this.checkBoxRing.AutoSize = true;
            this.checkBoxRing.Location = new System.Drawing.Point(70, 41);
            this.checkBoxRing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRing.Name = "checkBoxRing";
            this.checkBoxRing.Size = new System.Drawing.Size(50, 19);
            this.checkBoxRing.TabIndex = 5;
            this.checkBoxRing.Text = "Ring";
            this.checkBoxRing.UseVisualStyleBackColor = true;
            // 
            // checkBoxStop
            // 
            this.checkBoxStop.AutoSize = true;
            this.checkBoxStop.Location = new System.Drawing.Point(247, 41);
            this.checkBoxStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxStop.Name = "checkBoxStop";
            this.checkBoxStop.Size = new System.Drawing.Size(50, 19);
            this.checkBoxStop.TabIndex = 7;
            this.checkBoxStop.Text = "Stop";
            this.checkBoxStop.UseVisualStyleBackColor = true;
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelElapsedTime.Location = new System.Drawing.Point(133, 65);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(119, 37);
            this.labelElapsedTime.TabIndex = 6;
            this.labelElapsedTime.Text = "00:00:00";
            // 
            // checkBoxReset
            // 
            this.checkBoxReset.AutoSize = true;
            this.checkBoxReset.Location = new System.Drawing.Point(308, 41);
            this.checkBoxReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxReset.Name = "checkBoxReset";
            this.checkBoxReset.Size = new System.Drawing.Size(54, 19);
            this.checkBoxReset.TabIndex = 8;
            this.checkBoxReset.Text = "Reset";
            this.checkBoxReset.UseVisualStyleBackColor = true;
            // 
            // buttonStopReset
            // 
            this.buttonStopReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonStopReset.Location = new System.Drawing.Point(281, 8);
            this.buttonStopReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStopReset.Name = "buttonStopReset";
            this.buttonStopReset.Size = new System.Drawing.Size(110, 25);
            this.buttonStopReset.TabIndex = 4;
            this.buttonStopReset.Text = "Stop and Reset";
            this.buttonStopReset.UseVisualStyleBackColor = true;
            this.buttonStopReset.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(8, 109);
            this.richTextBoxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(383, 29);
            this.richTextBoxMessage.TabIndex = 10;
            this.richTextBoxMessage.Text = "Message";
            // 
            // checkTopMost
            // 
            this.checkTopMost.AutoSize = true;
            this.checkTopMost.Location = new System.Drawing.Point(269, 78);
            this.checkTopMost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkTopMost.Name = "checkTopMost";
            this.checkTopMost.Size = new System.Drawing.Size(92, 19);
            this.checkTopMost.TabIndex = 9;
            this.checkTopMost.Text = "Top Window";
            this.checkTopMost.UseVisualStyleBackColor = true;
            this.checkTopMost.CheckedChanged += new System.EventHandler(this.checkBoxMessage_CheckedChanged);
            // 
            // checkBoxMessage
            // 
            this.checkBoxMessage.AutoSize = true;
            this.checkBoxMessage.Location = new System.Drawing.Point(125, 41);
            this.checkBoxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMessage.Name = "checkBoxMessage";
            this.checkBoxMessage.Size = new System.Drawing.Size(104, 19);
            this.checkBoxMessage.TabIndex = 6;
            this.checkBoxMessage.Text = "Show Message";
            this.checkBoxMessage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "On time:";
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSeconds.Location = new System.Drawing.Point(159, 8);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSeconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(40, 23);
            this.numericUpDownSeconds.TabIndex = 2;
            this.numericUpDownSeconds.ValueChanged += new System.EventHandler(this.numericUpDownSeconds_ValueChanged);
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(72, 8);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(40, 23);
            this.numericUpDownHours.TabIndex = 0;
            this.numericUpDownHours.ValueChanged += new System.EventHandler(this.numericUpDownHours_ValueChanged);
            this.numericUpDownHours.Enter += new System.EventHandler(this.numericUpDownHours_Enter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 146);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxMessage);
            this.Controls.Add(this.checkTopMost);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.buttonStopReset);
            this.Controls.Add(this.checkBoxReset);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.checkBoxStop);
            this.Controls.Add(this.checkBoxRing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownRingTime);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy WorkTime Counter - KonSoftware";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownRingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxRing;
        private System.Windows.Forms.CheckBox checkBoxStop;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.CheckBox checkBoxReset;
        private System.Windows.Forms.Button buttonStopReset;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.CheckBox checkTopMost;
        private System.Windows.Forms.CheckBox checkBoxMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
    }
}

