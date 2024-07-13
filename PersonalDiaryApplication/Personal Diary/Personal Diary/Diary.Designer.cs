
namespace Personal_Diary
{
    partial class Diary
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
            this.diary_txtbox = new System.Windows.Forms.RichTextBox();
            this.date_txtbox = new System.Windows.Forms.TextBox();
            this.feeling_txtbox = new System.Windows.Forms.TextBox();
            this.location_txtbox = new System.Windows.Forms.TextBox();
            this.AddDiary_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.title_cmbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // diary_txtbox
            // 
            this.diary_txtbox.Location = new System.Drawing.Point(91, 230);
            this.diary_txtbox.Name = "diary_txtbox";
            this.diary_txtbox.Size = new System.Drawing.Size(351, 114);
            this.diary_txtbox.TabIndex = 1;
            this.diary_txtbox.Text = "";
            // 
            // date_txtbox
            // 
            this.date_txtbox.Location = new System.Drawing.Point(91, 119);
            this.date_txtbox.Name = "date_txtbox";
            this.date_txtbox.Size = new System.Drawing.Size(121, 20);
            this.date_txtbox.TabIndex = 2;
            // 
            // feeling_txtbox
            // 
            this.feeling_txtbox.Location = new System.Drawing.Point(91, 192);
            this.feeling_txtbox.Name = "feeling_txtbox";
            this.feeling_txtbox.Size = new System.Drawing.Size(121, 20);
            this.feeling_txtbox.TabIndex = 3;
            // 
            // location_txtbox
            // 
            this.location_txtbox.Location = new System.Drawing.Point(91, 156);
            this.location_txtbox.Name = "location_txtbox";
            this.location_txtbox.Size = new System.Drawing.Size(121, 20);
            this.location_txtbox.TabIndex = 4;
            // 
            // AddDiary_btn
            // 
            this.AddDiary_btn.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDiary_btn.Location = new System.Drawing.Point(181, 350);
            this.AddDiary_btn.Name = "AddDiary_btn";
            this.AddDiary_btn.Size = new System.Drawing.Size(123, 35);
            this.AddDiary_btn.TabIndex = 6;
            this.AddDiary_btn.Text = "Add";
            this.AddDiary_btn.UseVisualStyleBackColor = true;
            this.AddDiary_btn.Click += new System.EventHandler(this.AddDiary_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label1.Location = new System.Drawing.Point(209, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Feeling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label6.Location = new System.Drawing.Point(15, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diary";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(18, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(39, 26);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "<<";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // title_cmbox
            // 
            this.title_cmbox.FormattingEnabled = true;
            this.title_cmbox.Location = new System.Drawing.Point(166, 76);
            this.title_cmbox.Name = "title_cmbox";
            this.title_cmbox.Size = new System.Drawing.Size(121, 21);
            this.title_cmbox.TabIndex = 15;
            this.title_cmbox.SelectedIndexChanged += new System.EventHandler(this.title_cmbox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label5.Location = new System.Drawing.Point(88, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.Location = new System.Drawing.Point(119, 17);
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.Size = new System.Drawing.Size(44, 20);
            this.ID_txtbox.TabIndex = 17;
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(490, 397);
            this.Controls.Add(this.ID_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.title_cmbox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDiary_btn);
            this.Controls.Add(this.location_txtbox);
            this.Controls.Add(this.feeling_txtbox);
            this.Controls.Add(this.date_txtbox);
            this.Controls.Add(this.diary_txtbox);
            this.Name = "Diary";
            this.Text = "Diary";
            this.Load += new System.EventHandler(this.Diary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox diary_txtbox;
        private System.Windows.Forms.TextBox date_txtbox;
        private System.Windows.Forms.TextBox feeling_txtbox;
        private System.Windows.Forms.TextBox location_txtbox;
        private System.Windows.Forms.Button AddDiary_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ComboBox title_cmbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_txtbox;
    }
}