
namespace LicmanChat
{
    partial class ChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this.tbEnterMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMessagehistory = new System.Windows.Forms.TextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnBacktoUserList = new System.Windows.Forms.Button();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.btnLightDark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEnterMessage
            // 
            this.tbEnterMessage.Location = new System.Drawing.Point(54, 590);
            this.tbEnterMessage.Multiline = true;
            this.tbEnterMessage.Name = "tbEnterMessage";
            this.tbEnterMessage.Size = new System.Drawing.Size(228, 34);
            this.tbEnterMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(288, 594);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(37, 26);
            this.btnSend.TabIndex = 1;
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbMessagehistory
            // 
            this.tbMessagehistory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbMessagehistory.Location = new System.Drawing.Point(12, 59);
            this.tbMessagehistory.Multiline = true;
            this.tbMessagehistory.Name = "tbMessagehistory";
            this.tbMessagehistory.Size = new System.Drawing.Size(308, 526);
            this.tbMessagehistory.TabIndex = 2;
            // 
            // btnAttach
            // 
            this.btnAttach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttach.BackgroundImage")));
            this.btnAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttach.Location = new System.Drawing.Point(12, 591);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(36, 33);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // btnBacktoUserList
            // 
            this.btnBacktoUserList.BackColor = System.Drawing.Color.Transparent;
            this.btnBacktoUserList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBacktoUserList.BackgroundImage")));
            this.btnBacktoUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBacktoUserList.Location = new System.Drawing.Point(12, 16);
            this.btnBacktoUserList.Name = "btnBacktoUserList";
            this.btnBacktoUserList.Size = new System.Drawing.Size(36, 36);
            this.btnBacktoUserList.TabIndex = 4;
            this.btnBacktoUserList.UseVisualStyleBackColor = false;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Location = new System.Drawing.Point(55, 19);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(227, 32);
            this.panelUserInfo.TabIndex = 5;
            // 
            // btnLightDark
            // 
            this.btnLightDark.BackColor = System.Drawing.Color.Transparent;
            this.btnLightDark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLightDark.BackgroundImage")));
            this.btnLightDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLightDark.Location = new System.Drawing.Point(288, 19);
            this.btnLightDark.Name = "btnLightDark";
            this.btnLightDark.Size = new System.Drawing.Size(37, 35);
            this.btnLightDark.TabIndex = 7;
            this.btnLightDark.UseVisualStyleBackColor = false;
            this.btnLightDark.Click += new System.EventHandler(this.btnLightDark_Click);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 626);
            this.Controls.Add(this.btnLightDark);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.btnBacktoUserList);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.tbMessagehistory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbEnterMessage);
            this.Name = "ChatWindow";
            this.ShowIcon = false;
            this.Text = "ChatWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnterMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMessagehistory;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnBacktoUserList;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Button btnLightDark;
    }
}
