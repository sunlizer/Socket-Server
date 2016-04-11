namespace Chat.ClientApplication
{
    partial class ClientConsole
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
            this.Connect = new System.Windows.Forms.Button();
            this.PortNumber = new System.Windows.Forms.NumericUpDown();
            this.IpAdress = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserList = new System.Windows.Forms.ListBox();
            this.GlobalMessages = new System.Windows.Forms.TextBox();
            this.GlobalMessageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(415, 22);
            this.Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(100, 56);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(303, 26);
            this.PortNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PortNumber.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(87, 22);
            this.PortNumber.TabIndex = 1;
            this.PortNumber.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // IpAdress
            // 
            this.IpAdress.ForeColor = System.Drawing.Color.Navy;
            this.IpAdress.Location = new System.Drawing.Point(118, 26);
            this.IpAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IpAdress.Name = "IpAdress";
            this.IpAdress.ReadOnly = true;
            this.IpAdress.Size = new System.Drawing.Size(177, 22);
            this.IpAdress.TabIndex = 2;
            this.IpAdress.Text = "127.0.0.1";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(258, 56);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(132, 22);
            this.UserName.TabIndex = 3;
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.ItemHeight = 16;
            this.UserList.Location = new System.Drawing.Point(13, 96);
            this.UserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(159, 244);
            this.UserList.TabIndex = 4;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            this.UserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserList_MouseDoubleClick);
            // 
            // GlobalMessages
            // 
            this.GlobalMessages.Location = new System.Drawing.Point(180, 96);
            this.GlobalMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GlobalMessages.Multiline = true;
            this.GlobalMessages.Name = "GlobalMessages";
            this.GlobalMessages.Size = new System.Drawing.Size(335, 178);
            this.GlobalMessages.TabIndex = 5;
            // 
            // GlobalMessageBox
            // 
            this.GlobalMessageBox.Location = new System.Drawing.Point(180, 282);
            this.GlobalMessageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GlobalMessageBox.Multiline = true;
            this.GlobalMessageBox.Name = "GlobalMessageBox";
            this.GlobalMessageBox.Size = new System.Drawing.Size(257, 56);
            this.GlobalMessageBox.TabIndex = 6;
            this.GlobalMessageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GlobalMessageBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(440, 282);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(75, 56);
            this.SendMessageButton.TabIndex = 8;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // ClientConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 353);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GlobalMessageBox);
            this.Controls.Add(this.GlobalMessages);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.IpAdress);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(583, 358);
            this.Name = "ClientConsole";
            this.Text = "ClientConsole";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.NumericUpDown PortNumber;
        private System.Windows.Forms.TextBox IpAdress;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.TextBox GlobalMessages;
        private System.Windows.Forms.TextBox GlobalMessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendMessageButton;
    }
}