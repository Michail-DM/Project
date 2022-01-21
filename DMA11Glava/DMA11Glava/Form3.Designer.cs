
namespace DMA11Glava
{
    partial class Form3
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
            this.butLoadMP3 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGenres = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // butLoadMP3
            // 
            this.butLoadMP3.Location = new System.Drawing.Point(656, 64);
            this.butLoadMP3.Name = "butLoadMP3";
            this.butLoadMP3.Size = new System.Drawing.Size(107, 23);
            this.butLoadMP3.TabIndex = 0;
            this.butLoadMP3.Text = "Открыть MP3";
            this.butLoadMP3.UseVisualStyleBackColor = true;
            
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(656, 93);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить MP3";
            this.SaveButton.UseVisualStyleBackColor = true;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заголовок";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 61);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(173, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(100, 87);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(173, 20);
            this.txtArtist.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Артист";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(100, 113);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(173, 20);
            this.txtAlbum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Альбом";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 139);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(173, 20);
            this.txtYear.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Год";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(100, 165);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(173, 20);
            this.txtComment.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Комментарий";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(100, 203);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(34, 20);
            this.txtGenre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Жанр";
            // 
            // cboGenres
            // 
            this.cboGenres.FormattingEnabled = true;
            this.cboGenres.Location = new System.Drawing.Point(152, 203);
            this.cboGenres.Name = "cboGenres";
            this.cboGenres.Size = new System.Drawing.Size(121, 21);
            this.cboGenres.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboGenres);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.butLoadMP3);
            this.Name = "Form3";
            this.Text = "Form3";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLoadMP3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGenres;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}