namespace TryGor
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.AcceptsTab = true;
            this.textBox_Password.Location = new System.Drawing.Point(232, 117);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(221, 20);
            this.textBox_Password.TabIndex = 8;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(130, 117);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 7;
            this.label_Password.Text = "Password";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(232, 66);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(221, 20);
            this.textBox_Username.TabIndex = 6;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(130, 66);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(55, 13);
            this.label_Username.TabIndex = 5;
            this.label_Username.Text = "Username";
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.Location = new System.Drawing.Point(232, 161);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(115, 35);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "Register New User";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(363, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::TryGor.Properties.Resources.newUser;
            this.pictureBox.Location = new System.Drawing.Point(89, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(45, 50);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(166, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(287, 18);
            this.label.TabIndex = 14;
            this.label.Text = "Register New Operator (Power User)";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(576, 222);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Username);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
    }
}