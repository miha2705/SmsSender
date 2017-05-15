namespace SmsSender
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.labComPort = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.butSaveSettings = new System.Windows.Forms.Button();
            this.butCloseSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labComPort
            // 
            this.labComPort.AutoSize = true;
            this.labComPort.Location = new System.Drawing.Point(12, 34);
            this.labComPort.Name = "labComPort";
            this.labComPort.Size = new System.Drawing.Size(102, 13);
            this.labComPort.TabIndex = 0;
            this.labComPort.Text = "COM Порт модема";
            // 
            // txtComPort
            // 
            this.txtComPort.Location = new System.Drawing.Point(120, 31);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(85, 20);
            this.txtComPort.TabIndex = 1;
            // 
            // butSaveSettings
            // 
            this.butSaveSettings.Location = new System.Drawing.Point(76, 167);
            this.butSaveSettings.Name = "butSaveSettings";
            this.butSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.butSaveSettings.TabIndex = 2;
            this.butSaveSettings.Text = "Сохранить";
            this.butSaveSettings.UseVisualStyleBackColor = true;
            this.butSaveSettings.Click += new System.EventHandler(this.butSaveSettings_Click);
            // 
            // butCloseSettings
            // 
            this.butCloseSettings.Location = new System.Drawing.Point(194, 167);
            this.butCloseSettings.Name = "butCloseSettings";
            this.butCloseSettings.Size = new System.Drawing.Size(75, 23);
            this.butCloseSettings.TabIndex = 3;
            this.butCloseSettings.Text = "Отмена";
            this.butCloseSettings.UseVisualStyleBackColor = true;
            this.butCloseSettings.Click += new System.EventHandler(this.butCloseSettings_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 202);
            this.Controls.Add(this.butCloseSettings);
            this.Controls.Add(this.butSaveSettings);
            this.Controls.Add(this.txtComPort);
            this.Controls.Add(this.labComPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labComPort;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.Button butSaveSettings;
        private System.Windows.Forms.Button butCloseSettings;
    }
}