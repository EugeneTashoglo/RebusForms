namespace RebusForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.Математика = new System.Windows.Forms.Button();
            this.Физкультура = new System.Windows.Forms.Button();
            this.Русский = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Математика
            // 
            this.Математика.Location = new System.Drawing.Point(12, 144);
            this.Математика.Name = "Математика";
            this.Математика.Size = new System.Drawing.Size(249, 182);
            this.Математика.TabIndex = 5;
            this.Математика.Text = "Математика";
            this.Математика.UseVisualStyleBackColor = true;
            this.Математика.Click += new System.EventHandler(this.Математика_Click);
            // 
            // Физкультура
            // 
            this.Физкультура.Location = new System.Drawing.Point(544, 144);
            this.Физкультура.Name = "Физкультура";
            this.Физкультура.Size = new System.Drawing.Size(244, 182);
            this.Физкультура.TabIndex = 6;
            this.Физкультура.Text = "Физкультура";
            this.Физкультура.UseVisualStyleBackColor = true;
            this.Физкультура.Click += new System.EventHandler(this.Физкультура_Click);
            // 
            // Русский
            // 
            this.Русский.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Русский.Location = new System.Drawing.Point(267, 144);
            this.Русский.Name = "Русский";
            this.Русский.Size = new System.Drawing.Size(271, 182);
            this.Русский.TabIndex = 7;
            this.Русский.Text = "Русский";
            this.Русский.UseVisualStyleBackColor = true;
            this.Русский.Click += new System.EventHandler(this.Русский_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Русский);
            this.Controls.Add(this.Физкультура);
            this.Controls.Add(this.Математика);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Математика;
        private System.Windows.Forms.Button Физкультура;
        private System.Windows.Forms.Button Русский;
    }
}

