namespace WindowsFormsApplication7
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CircleFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CircleFormButton
            // 
            this.CircleFormButton.Location = new System.Drawing.Point(12, 12);
            this.CircleFormButton.Name = "CircleFormButton";
            this.CircleFormButton.Size = new System.Drawing.Size(268, 23);
            this.CircleFormButton.TabIndex = 0;
            this.CircleFormButton.Text = "Ввести радиус круга";
            this.CircleFormButton.UseVisualStyleBackColor = true;
            this.CircleFormButton.Click += new System.EventHandler(this.CircleFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 426);
            this.Controls.Add(this.CircleFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CircleFormButton;
    }
}

