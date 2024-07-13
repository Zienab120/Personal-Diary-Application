
namespace Personal_Diary
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
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AllowDrop = true;
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(88, 85);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(54, 23);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(88, 157);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(85, 23);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(191, 85);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(173, 20);
            this.email_txtbox.TabIndex = 4;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(191, 157);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(173, 20);
            this.password_txtbox.TabIndex = 5;
            // 
            // logIn_btn
            // 
            this.logIn_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_btn.Location = new System.Drawing.Point(92, 254);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(272, 36);
            this.logIn_btn.TabIndex = 6;
            this.logIn_btn.Text = "Log in";
            this.logIn_btn.UseVisualStyleBackColor = true;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 397);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Name = "LogIn";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button logIn_btn;
    }
}

