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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownRingTime
            // 
            resources.ApplyResources(this.numericUpDownRingTime, "numericUpDownRingTime");
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
            this.numericUpDownRingTime.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDownRingTime.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // checkBoxRing
            // 
            resources.ApplyResources(this.checkBoxRing, "checkBoxRing");
            this.checkBoxRing.Name = "checkBoxRing";
            this.checkBoxRing.UseVisualStyleBackColor = true;
            // 
            // checkBoxStop
            // 
            resources.ApplyResources(this.checkBoxStop, "checkBoxStop");
            this.checkBoxStop.Name = "checkBoxStop";
            this.checkBoxStop.UseVisualStyleBackColor = true;
            // 
            // labelElapsedTime
            // 
            resources.ApplyResources(this.labelElapsedTime, "labelElapsedTime");
            this.labelElapsedTime.Name = "labelElapsedTime";
            // 
            // checkBoxReset
            // 
            resources.ApplyResources(this.checkBoxReset, "checkBoxReset");
            this.checkBoxReset.Name = "checkBoxReset";
            this.checkBoxReset.UseVisualStyleBackColor = true;
            // 
            // buttonStopReset
            // 
            resources.ApplyResources(this.buttonStopReset, "buttonStopReset");
            this.buttonStopReset.Name = "buttonStopReset";
            this.buttonStopReset.UseVisualStyleBackColor = true;
            this.buttonStopReset.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // richTextBoxMessage
            // 
            resources.ApplyResources(this.richTextBoxMessage, "richTextBoxMessage");
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            // 
            // checkTopMost
            // 
            resources.ApplyResources(this.checkTopMost, "checkTopMost");
            this.checkTopMost.Name = "checkTopMost";
            this.checkTopMost.UseVisualStyleBackColor = true;
            this.checkTopMost.CheckedChanged += new System.EventHandler(this.checkBoxMessage_CheckedChanged);
            // 
            // checkBoxMessage
            // 
            resources.ApplyResources(this.checkBoxMessage, "checkBoxMessage");
            this.checkBoxMessage.Name = "checkBoxMessage";
            this.checkBoxMessage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numericUpDownSeconds
            // 
            resources.ApplyResources(this.numericUpDownSeconds, "numericUpDownSeconds");
            this.numericUpDownSeconds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            this.numericUpDownSeconds.ValueChanged += new System.EventHandler(this.numericUpDownSeconds_ValueChanged);
            // 
            // numericUpDownHours
            // 
            resources.ApplyResources(this.numericUpDownHours, "numericUpDownHours");
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.ValueChanged += new System.EventHandler(this.numericUpDownHours_ValueChanged);
            this.numericUpDownHours.Enter += new System.EventHandler(this.numericUpDownHours_Enter);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
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

