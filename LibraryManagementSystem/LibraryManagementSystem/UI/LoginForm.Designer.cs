namespace LibraryManagementSystem
{
    partial class LoginForm
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
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.readerLoginButton = new System.Windows.Forms.Button();
            this.readerIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Location = new System.Drawing.Point(197, 53);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.Size = new System.Drawing.Size(130, 20);
            this.adminPasswordTextBox.TabIndex = 1;
            this.adminPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminPasswordTextBox_KeyDown);
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(333, 51);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(75, 23);
            this.adminLoginButton.TabIndex = 2;
            this.adminLoginButton.Text = "Login";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // readerLoginButton
            // 
            this.readerLoginButton.Location = new System.Drawing.Point(333, 135);
            this.readerLoginButton.Name = "readerLoginButton";
            this.readerLoginButton.Size = new System.Drawing.Size(75, 23);
            this.readerLoginButton.TabIndex = 5;
            this.readerLoginButton.Text = "Login";
            this.readerLoginButton.UseVisualStyleBackColor = true;
            this.readerLoginButton.Click += new System.EventHandler(this.readerLoginButton_Click);
            // 
            // readerIDTextBox
            // 
            this.readerIDTextBox.Location = new System.Drawing.Point(197, 137);
            this.readerIDTextBox.Name = "readerIDTextBox";
            this.readerIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.readerIDTextBox.TabIndex = 4;
            this.readerIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readerIDTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BookReader";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 235);
            this.Controls.Add(this.readerLoginButton);
            this.Controls.Add(this.readerIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.adminPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Movable = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Button readerLoginButton;
        private System.Windows.Forms.TextBox readerIDTextBox;
        private System.Windows.Forms.Label label2;
    }
}

