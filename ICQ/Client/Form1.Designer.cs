namespace Client
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.ListBox();
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.chatText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SendTO = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chat";
            // 
            // portNumber
            // 
            this.portNumber.AutoSize = true;
            this.portNumber.Location = new System.Drawing.Point(52, 307);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(88, 17);
            this.portNumber.TabIndex = 0;
            this.portNumber.Text = "Port Number";
            // 
            // UserBox
            // 
            this.UserBox.Enabled = false;
            this.UserBox.FormattingEnabled = true;
            this.UserBox.ItemHeight = 16;
            this.UserBox.Location = new System.Drawing.Point(15, 29);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(124, 260);
            this.UserBox.TabIndex = 1;
            // 
            // ChatBox
            // 
            this.ChatBox.Enabled = false;
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.ItemHeight = 16;
            this.ChatBox.Location = new System.Drawing.Point(146, 29);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(295, 260);
            this.ChatBox.TabIndex = 2;
            // 
            // chatText
            // 
            this.chatText.Location = new System.Drawing.Point(146, 295);
            this.chatText.Multiline = true;
            this.chatText.Name = "chatText";
            this.chatText.Size = new System.Drawing.Size(179, 56);
            this.chatText.TabIndex = 3;
            this.chatText.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendTO
            // 
            this.SendTO.FormattingEnabled = true;
            this.SendTO.Location = new System.Drawing.Point(12, 312);
            this.SendTO.Name = "SendTO";
            this.SendTO.Size = new System.Drawing.Size(121, 24);
            this.SendTO.TabIndex = 6;
            this.SendTO.Text = "Server";
            this.SendTO.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 332);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 17);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Nick Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(145, 329);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(180, 22);
            this.NameBox.TabIndex = 8;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(146, 300);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(179, 22);
            this.portText.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 363);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.SendTO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chatText);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.portNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label portNumber;
        private System.Windows.Forms.ListBox UserBox;
        private System.Windows.Forms.ListBox ChatBox;
        private System.Windows.Forms.TextBox chatText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SendTO;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox portText;
    }
}

