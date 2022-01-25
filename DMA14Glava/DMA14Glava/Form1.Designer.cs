
namespace DMA14Glava
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCulture = new System.Windows.Forms.ComboBox();
            this.lstMonth = new System.Windows.Forms.ListBox();
            this.lstWeek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboCulture
            // 
            this.cboCulture.FormattingEnabled = true;
            this.cboCulture.Location = new System.Drawing.Point(221, 124);
            this.cboCulture.Name = "cboCulture";
            this.cboCulture.Size = new System.Drawing.Size(121, 21);
            this.cboCulture.TabIndex = 0;
            this.cboCulture.SelectedIndexChanged += new System.EventHandler(this.cboCulture_SelectedIndexChanged);
            // 
            // lstMonth
            // 
            this.lstMonth.FormattingEnabled = true;
            this.lstMonth.Location = new System.Drawing.Point(105, 215);
            this.lstMonth.Name = "lstMonth";
            this.lstMonth.Size = new System.Drawing.Size(120, 95);
            this.lstMonth.TabIndex = 1;
            // 
            // lstWeek
            // 
            this.lstWeek.FormattingEnabled = true;
            this.lstWeek.Location = new System.Drawing.Point(320, 215);
            this.lstWeek.Name = "lstWeek";
            this.lstWeek.Size = new System.Drawing.Size(120, 95);
            this.lstWeek.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstWeek);
            this.Controls.Add(this.lstMonth);
            this.Controls.Add(this.cboCulture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCulture;
        private System.Windows.Forms.ListBox lstMonth;
        private System.Windows.Forms.ListBox lstWeek;
    }
}

