namespace Draw
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.Rpoint = new System.Windows.Forms.RadioButton();
            this.Rline = new System.Windows.Forms.RadioButton();
            this.Rtriangle = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(292, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(148, 12);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 1;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(148, 38);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 20);
            this.txtY1.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(148, 64);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 20);
            this.txtX2.TabIndex = 3;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(148, 90);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 20);
            this.txtY2.TabIndex = 4;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(148, 116);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 5;
            // 
            // Rpoint
            // 
            this.Rpoint.AutoSize = true;
            this.Rpoint.Location = new System.Drawing.Point(148, 155);
            this.Rpoint.Name = "Rpoint";
            this.Rpoint.Size = new System.Drawing.Size(85, 17);
            this.Rpoint.TabIndex = 6;
            this.Rpoint.TabStop = true;
            this.Rpoint.Text = "radioButton1";
            this.Rpoint.UseVisualStyleBackColor = true;
            // 
            // Rline
            // 
            this.Rline.AutoSize = true;
            this.Rline.Location = new System.Drawing.Point(148, 178);
            this.Rline.Name = "Rline";
            this.Rline.Size = new System.Drawing.Size(85, 17);
            this.Rline.TabIndex = 7;
            this.Rline.TabStop = true;
            this.Rline.Text = "radioButton2";
            this.Rline.UseVisualStyleBackColor = true;
            // 
            // Rtriangle
            // 
            this.Rtriangle.AutoSize = true;
            this.Rtriangle.Location = new System.Drawing.Point(148, 201);
            this.Rtriangle.Name = "Rtriangle";
            this.Rtriangle.Size = new System.Drawing.Size(85, 17);
            this.Rtriangle.TabIndex = 8;
            this.Rtriangle.TabStop = true;
            this.Rtriangle.Text = "radioButton3";
            this.Rtriangle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rtriangle);
            this.Controls.Add(this.Rline);
            this.Controls.Add(this.Rpoint);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.RadioButton Rpoint;
        private System.Windows.Forms.RadioButton Rline;
        private System.Windows.Forms.RadioButton Rtriangle;
        private System.Windows.Forms.Button button1;
    }
}

