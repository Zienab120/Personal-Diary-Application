
namespace Personal_Diary
{
    partial class Navigation
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
            this.signOut_btn = new System.Windows.Forms.Button();
            this.addDiary_btn = new System.Windows.Forms.Button();
            this.mySharedDiaries_btn = new System.Windows.Forms.Button();
            this.Report1 = new System.Windows.Forms.Button();
            this.Report2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signOut_btn
            // 
            this.signOut_btn.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut_btn.Location = new System.Drawing.Point(16, 15);
            this.signOut_btn.Margin = new System.Windows.Forms.Padding(4);
            this.signOut_btn.Name = "signOut_btn";
            this.signOut_btn.Size = new System.Drawing.Size(140, 32);
            this.signOut_btn.TabIndex = 15;
            this.signOut_btn.Text = "<< Sign out";
            this.signOut_btn.UseVisualStyleBackColor = true;
            this.signOut_btn.Click += new System.EventHandler(this.signOut_btn_Click);
            // 
            // addDiary_btn
            // 
            this.addDiary_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.addDiary_btn.Location = new System.Drawing.Point(192, 65);
            this.addDiary_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addDiary_btn.Name = "addDiary_btn";
            this.addDiary_btn.Size = new System.Drawing.Size(264, 48);
            this.addDiary_btn.TabIndex = 16;
            this.addDiary_btn.Text = "Add Dairy";
            this.addDiary_btn.UseVisualStyleBackColor = true;
            this.addDiary_btn.Click += new System.EventHandler(this.addDiary_btn_Click);
            // 
            // mySharedDiaries_btn
            // 
            this.mySharedDiaries_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.mySharedDiaries_btn.Location = new System.Drawing.Point(192, 142);
            this.mySharedDiaries_btn.Margin = new System.Windows.Forms.Padding(4);
            this.mySharedDiaries_btn.Name = "mySharedDiaries_btn";
            this.mySharedDiaries_btn.Size = new System.Drawing.Size(264, 48);
            this.mySharedDiaries_btn.TabIndex = 17;
            this.mySharedDiaries_btn.Text = "My Shared Diaries";
            this.mySharedDiaries_btn.UseVisualStyleBackColor = true;
            this.mySharedDiaries_btn.Click += new System.EventHandler(this.mySharedDiaries_btn_Click);
            // 
            // Report1
            // 
            this.Report1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.Report1.Location = new System.Drawing.Point(192, 223);
            this.Report1.Margin = new System.Windows.Forms.Padding(4);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(264, 48);
            this.Report1.TabIndex = 18;
            this.Report1.Text = "Report1";
            this.Report1.UseVisualStyleBackColor = true;
            this.Report1.Click += new System.EventHandler(this.Report1_Click);
            // 
            // Report2
            // 
            this.Report2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F);
            this.Report2.Location = new System.Drawing.Point(192, 299);
            this.Report2.Margin = new System.Windows.Forms.Padding(4);
            this.Report2.Name = "Report2";
            this.Report2.Size = new System.Drawing.Size(264, 48);
            this.Report2.TabIndex = 19;
            this.Report2.Text = "Report2";
            this.Report2.UseVisualStyleBackColor = true;
            this.Report2.Click += new System.EventHandler(this.Report2_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 489);
            this.Controls.Add(this.Report2);
            this.Controls.Add(this.Report1);
            this.Controls.Add(this.mySharedDiaries_btn);
            this.Controls.Add(this.addDiary_btn);
            this.Controls.Add(this.signOut_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signOut_btn;
        private System.Windows.Forms.Button addDiary_btn;
        private System.Windows.Forms.Button mySharedDiaries_btn;
        private System.Windows.Forms.Button Report1;
        private System.Windows.Forms.Button Report2;
    }
}