namespace rev_B_App
{
    partial class FreqForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Freq = new System.Windows.Forms.Label();
            this.freqdrop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(370, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Freq
            // 
            this.Freq.AutoSize = true;
            this.Freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freq.Location = new System.Drawing.Point(180, 131);
            this.Freq.Name = "Freq";
            this.Freq.Size = new System.Drawing.Size(172, 38);
            this.Freq.TabIndex = 1;
            this.Freq.Text = "Frequency";
            // 
            // freqdrop
            // 
            this.freqdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.freqdrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freqdrop.FormattingEnabled = true;
            this.freqdrop.Items.AddRange(new object[] {
            "Hz",
            "kHz"});
            this.freqdrop.Location = new System.Drawing.Point(535, 123);
            this.freqdrop.Name = "freqdrop";
            this.freqdrop.Size = new System.Drawing.Size(114, 50);
            this.freqdrop.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FreqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.freqdrop);
            this.Controls.Add(this.Freq);
            this.Controls.Add(this.textBox1);
            this.Name = "FreqForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Freq;
        private System.Windows.Forms.ComboBox freqdrop;
        private System.Windows.Forms.Button button1;
    }
}