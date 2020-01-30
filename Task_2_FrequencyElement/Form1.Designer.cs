namespace Task_2_FrequencyElement
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
            this.listElements = new System.Windows.Forms.ListBox();
            this.BtnGetElements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listElements
            // 
            this.listElements.FormattingEnabled = true;
            this.listElements.Location = new System.Drawing.Point(6, 44);
            this.listElements.Name = "listElements";
            this.listElements.Size = new System.Drawing.Size(542, 433);
            this.listElements.TabIndex = 0;
            // 
            // BtnGetElements
            // 
            this.BtnGetElements.Location = new System.Drawing.Point(239, 505);
            this.BtnGetElements.Name = "BtnGetElements";
            this.BtnGetElements.Size = new System.Drawing.Size(75, 23);
            this.BtnGetElements.TabIndex = 1;
            this.BtnGetElements.Text = "GetElments";
            this.BtnGetElements.UseVisualStyleBackColor = true;
            this.BtnGetElements.Click += new System.EventHandler(this.BtnGetElements_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 578);
            this.Controls.Add(this.BtnGetElements);
            this.Controls.Add(this.listElements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listElements;
        private System.Windows.Forms.Button BtnGetElements;
    }
}

