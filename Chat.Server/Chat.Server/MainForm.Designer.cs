namespace Chat.Server
{
    partial class MainForm
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
            this.StartListening = new System.Windows.Forms.Button();
            this.PortNumber = new System.Windows.Forms.NumericUpDown();
            this.userbox = new System.Windows.Forms.ListBox();
            this.logbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // StartListening
            // 
            this.StartListening.Location = new System.Drawing.Point(162, 13);
            this.StartListening.Margin = new System.Windows.Forms.Padding(4);
            this.StartListening.MaximumSize = new System.Drawing.Size(160, 26);
            this.StartListening.MinimumSize = new System.Drawing.Size(160, 26);
            this.StartListening.Name = "StartListening";
            this.StartListening.Size = new System.Drawing.Size(160, 26);
            this.StartListening.TabIndex = 0;
            this.StartListening.Text = "Start";
            this.StartListening.UseVisualStyleBackColor = true;
            this.StartListening.Click += new System.EventHandler(this.StartListening_Click);
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(33, 13);
            this.PortNumber.Margin = new System.Windows.Forms.Padding(4);
            this.PortNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(121, 22);
            this.PortNumber.TabIndex = 1;
            this.PortNumber.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // userbox
            // 
            this.userbox.FormattingEnabled = true;
            this.userbox.ItemHeight = 16;
            this.userbox.Location = new System.Drawing.Point(12, 65);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(120, 244);
            this.userbox.TabIndex = 3;
            // 
            // logbox
            // 
            this.logbox.FormattingEnabled = true;
            this.logbox.ItemHeight = 16;
            this.logbox.Location = new System.Drawing.Point(138, 65);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(239, 244);
            this.logbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "LOG";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.StartListening);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(401, 369);
            this.MinimumSize = new System.Drawing.Size(401, 369);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartListening;
        private System.Windows.Forms.NumericUpDown PortNumber;
        private System.Windows.Forms.ListBox userbox;
        private System.Windows.Forms.ListBox logbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}