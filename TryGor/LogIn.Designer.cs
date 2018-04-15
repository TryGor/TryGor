namespace TryGor
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogOn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(281, 54);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(55, 13);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(383, 54);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(221, 20);
            this.textBox_Username.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.AcceptsTab = true;
            this.textBox_Password.Location = new System.Drawing.Point(383, 105);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(221, 20);
            this.textBox_Password.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(281, 105);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(383, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(166, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TryGor.Properties.Resources.user_login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(514, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOn
            // 
            this.btnLogOn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOn.Location = new System.Drawing.Point(383, 199);
            this.btnLogOn.Name = "btnLogOn";
            this.btnLogOn.Size = new System.Drawing.Size(90, 35);
            this.btnLogOn.TabIndex = 9;
            this.btnLogOn.Text = "Logon";
            this.btnLogOn.UseVisualStyleBackColor = false;
            this.btnLogOn.Click += new System.EventHandler(this.btnLogOn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(383, 271);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(234, 23);
            this.progressBar.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(58, 254);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(129, 13);
            this.lblDateTime.TabIndex = 11;
            this.lblDateTime.Text = "System Date and Time:    ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 279);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "   ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(161, 279);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "  ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogIn
            // 
            this.AcceptButton = this.btnLogOn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(771, 318);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnLogOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogOn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

