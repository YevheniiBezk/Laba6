namespace Laba6
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
            this.PyramidH = new System.Windows.Forms.TextBox();
            this.PyramidA = new System.Windows.Forms.TextBox();
            this.SphereR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPyramidVolume = new System.Windows.Forms.Label();
            this.lblSphereVolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PyramidH
            // 
            this.PyramidH.Location = new System.Drawing.Point(192, 172);
            this.PyramidH.Name = "PyramidH";
            this.PyramidH.Size = new System.Drawing.Size(100, 20);
            this.PyramidH.TabIndex = 0;
            // 
            // PyramidA
            // 
            this.PyramidA.Location = new System.Drawing.Point(355, 172);
            this.PyramidA.Name = "PyramidA";
            this.PyramidA.Size = new System.Drawing.Size(100, 20);
            this.PyramidA.TabIndex = 1;
            // 
            // SphereR
            // 
            this.SphereR.Location = new System.Drawing.Point(516, 172);
            this.SphereR.Name = "SphereR";
            this.SphereR.Size = new System.Drawing.Size(100, 20);
            this.SphereR.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "обчислення";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPyramidVolume
            // 
            this.lblPyramidVolume.AutoSize = true;
            this.lblPyramidVolume.Location = new System.Drawing.Point(210, 304);
            this.lblPyramidVolume.Name = "lblPyramidVolume";
            this.lblPyramidVolume.Size = new System.Drawing.Size(82, 13);
            this.lblPyramidVolume.TabIndex = 4;
            this.lblPyramidVolume.Text = "Об\'єм піраміди";
            this.lblPyramidVolume.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSphereVolume
            // 
            this.lblSphereVolume.AutoSize = true;
            this.lblSphereVolume.Location = new System.Drawing.Point(513, 304);
            this.lblSphereVolume.Name = "lblSphereVolume";
            this.lblSphereVolume.Size = new System.Drawing.Size(59, 13);
            this.lblSphereVolume.TabIndex = 5;
            this.lblSphereVolume.Text = "Об\'єм кулі";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "довжина сторони основи піраміди (A)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "висота піраміди (H)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "радіус кулі (R)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSphereVolume);
            this.Controls.Add(this.lblPyramidVolume);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SphereR);
            this.Controls.Add(this.PyramidA);
            this.Controls.Add(this.PyramidH);
            this.Name = "Form1";
            this.Text = "Лабораторна 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PyramidH;
        private System.Windows.Forms.TextBox PyramidA;
        private System.Windows.Forms.TextBox SphereR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPyramidVolume;
        private System.Windows.Forms.Label lblSphereVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

