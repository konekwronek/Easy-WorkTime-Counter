using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Timer
{
    public partial class FormMain : Form
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;
        private String timeText;
        private int beeps = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes == 60)
            {
                hours++;
                minutes = 0;
            }
            if (hours < 10) timeText = "0" + hours + ":";
            else timeText = hours + ":";
            if (minutes < 10) timeText += "0" + minutes + ":";
            else timeText += minutes + ":";
            if (seconds < 10) timeText += "0" + seconds;
            else timeText += seconds;
            labelElapsedTime.Text = timeText;

            if (hours == numericUpDownHours.Value && minutes == numericUpDownRingTime.Value && seconds == numericUpDownSeconds.Value)
            {
                if (checkBoxRing.Checked)
                {
                    beeps = 4;
                    timer2.Enabled = true;
                }

                if (checkBoxMessage.Checked)
                {
                    FormAlert frm = new FormAlert();
                    frm.AlertLabel.Text = richTextBoxMessage.Text;
                    frm.Show();
                }

                if (checkBoxStop.Checked)
                {
                    timer1.Enabled = false;
                    buttonStart.Text = "Start";
                }
                
                if (checkBoxReset.Checked)
                {
                    seconds = 0; minutes = 0; hours = 0;
                    labelElapsedTime.Text = "00:00:00";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                buttonStart.Text = "Pause";
            }
            else
            {
                timer1.Enabled = false;
                buttonStart.Text = "Continue";
            }
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownRingTime.Value == 60)
            { 
                numericUpDownRingTime.Value = 0;
                numericUpDownHours.Value++;
            }
            if (numericUpDownRingTime.Value == -1)
            { 
                numericUpDownRingTime.Value = 59;
                if (numericUpDownHours.Value > 0) numericUpDownHours.Value--;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Console.Beep(880, 500);
            beeps--;
            if (beeps <= 0) timer2.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            seconds = 0; minutes = 0; hours = 0;
            labelElapsedTime.Text = "00:00:00";
            buttonStart.Text = "Start";
        }

        private void checkBoxMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTopMost.Checked) Form.ActiveForm.TopMost = true;
            else Form.ActiveForm.TopMost = false;
        }

        private void numericUpDownSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSeconds.Value == 60) numericUpDownSeconds.Value = 0;
        }

        private void numericUpDownHours_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
