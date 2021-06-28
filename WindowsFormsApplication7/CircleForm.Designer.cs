namespace WindowsFormsApplication7
{
    partial class CircleForm
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
            this.Dia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dia)).BeginInit();
            this.SuspendLayout();
            // 
            // Dia
            // 
            this.Dia.Location = new System.Drawing.Point(105, 11);
            this.Dia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(120, 20);
            this.Dia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите диаметр:";
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(7, 42);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(218, 23);
            this.DrawButton.TabIndex = 6;
            this.DrawButton.Text = "Нарисовать";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 76);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            ((System.ComponentModel.ISupportInitialize)(this.Dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Dia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DrawButton;
    }
}