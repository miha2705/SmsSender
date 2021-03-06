﻿namespace SmsSender
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.stbComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgrDrivers = new System.Windows.Forms.DataGridView();
            this.btnDelDriver = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmEdit});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(803, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmExit});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(48, 20);
            this.mmFile.Text = "Файл";
            // 
            // mmExit
            // 
            this.mmExit.Name = "mmExit";
            this.mmExit.Size = new System.Drawing.Size(108, 22);
            this.mmExit.Text = "Выход";
            this.mmExit.Click += new System.EventHandler(this.mmExit_Click);
            // 
            // mmEdit
            // 
            this.mmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmSettings});
            this.mmEdit.Name = "mmEdit";
            this.mmEdit.Size = new System.Drawing.Size(59, 20);
            this.mmEdit.Text = "Правка";
            // 
            // mmSettings
            // 
            this.mmSettings.Name = "mmSettings";
            this.mmSettings.Size = new System.Drawing.Size(152, 22);
            this.mmSettings.Text = "Настройки";
            this.mmSettings.Click += new System.EventHandler(this.mmSettings_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(53, 196);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Отправить";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 52);
            this.txtMessage.MaxLength = 160;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(166, 138);
            this.txtMessage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текст сообщения";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbComPort});
            this.statusBar.Location = new System.Drawing.Point(0, 376);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(803, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "stsusBar";
            // 
            // stbComPort
            // 
            this.stbComPort.Name = "stbComPort";
            this.stbComPort.Size = new System.Drawing.Size(118, 17);
            this.stbComPort.Text = "toolStripStatusLabel1";
            // 
            // dgrDrivers
            // 
            this.dgrDrivers.AllowUserToAddRows = false;
            this.dgrDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDrivers.Location = new System.Drawing.Point(224, 27);
            this.dgrDrivers.Name = "dgrDrivers";
            this.dgrDrivers.Size = new System.Drawing.Size(579, 280);
            this.dgrDrivers.TabIndex = 5;
            // 
            // btnDelDriver
            // 
            this.btnDelDriver.Image = global::SmsSender.Properties.Resources.Remove_Male_User;
            this.btnDelDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelDriver.Location = new System.Drawing.Point(525, 324);
            this.btnDelDriver.Name = "btnDelDriver";
            this.btnDelDriver.Size = new System.Drawing.Size(90, 40);
            this.btnDelDriver.TabIndex = 7;
            this.btnDelDriver.Text = "Удалить\r\nВодителя";
            this.btnDelDriver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelDriver.UseVisualStyleBackColor = true;
            this.btnDelDriver.Click += new System.EventHandler(this.btnDelDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Image = global::SmsSender.Properties.Resources.Add_Male_User;
            this.btnAddDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDriver.Location = new System.Drawing.Point(372, 324);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(90, 40);
            this.btnAddDriver.TabIndex = 6;
            this.btnAddDriver.Text = "Добавить\r\nВодителя";
            this.btnAddDriver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 398);
            this.Controls.Add(this.btnDelDriver);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.dgrDrivers);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmsSender";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mmExit;
        private System.Windows.Forms.ToolStripMenuItem mmEdit;
        private System.Windows.Forms.ToolStripMenuItem mmSettings;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.DataGridView dgrDrivers;
        private System.Windows.Forms.ToolStripStatusLabel stbComPort;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnDelDriver;
    }
}

