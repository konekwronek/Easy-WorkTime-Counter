using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class FormAlert : Form
    {
        public FormAlert()
        {
            InitializeComponent();
        }

        public FormAlert(FormMain formMain)
        {
        }
        private void buttonAlertClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
