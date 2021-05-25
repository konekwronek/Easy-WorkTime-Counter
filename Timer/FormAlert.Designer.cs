
namespace Timer
{
    partial class FormAlert
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
            this.AlertLabel = new System.Windows.Forms.Label();
            this.buttonAlertClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlertLabel.Location = new System.Drawing.Point(12, 29);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(95, 30);
            this.AlertLabel.TabIndex = 0;
            this.AlertLabel.Text = "Message";
            // 
            // buttonAlertClose
            // 
            this.buttonAlertClose.Location = new System.Drawing.Point(318, 75);
            this.buttonAlertClose.Name = "buttonAlertClose";
            this.buttonAlertClose.Size = new System.Drawing.Size(79, 32);
            this.buttonAlertClose.TabIndex = 1;
            this.buttonAlertClose.Text = "Close";
            this.buttonAlertClose.UseVisualStyleBackColor = true;
            this.buttonAlertClose.Click += new System.EventHandler(this.buttonAlertClose_Click);
            // 
            // FormAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 119);
            this.Controls.Add(this.buttonAlertClose);
            this.Controls.Add(this.AlertLabel);
            this.Name = "FormAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Alert!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Button buttonAlertClose;
    }
}