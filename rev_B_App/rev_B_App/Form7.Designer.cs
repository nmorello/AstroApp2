namespace rev_B_App
{
    partial class AmpForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ampdrop = new System.Windows.Forms.ComboBox();
            this.Ampl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ampdrop
            // 
            this.ampdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ampdrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampdrop.FormattingEnabled = true;
            this.ampdrop.Items.AddRange(new object[] {
            "mV",
            "V"});
            this.ampdrop.Location = new System.Drawing.Point(555, 62);
            this.ampdrop.Name = "ampdrop";
            this.ampdrop.Size = new System.Drawing.Size(114, 50);
            this.ampdrop.TabIndex = 9;
            // 
            // Ampl
            // 
            this.Ampl.AutoSize = true;
            this.Ampl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ampl.Location = new System.Drawing.Point(200, 70);
            this.Ampl.Name = "Ampl";
            this.Ampl.Size = new System.Drawing.Size(161, 38);
            this.Ampl.TabIndex = 8;
            this.Ampl.Text = "Amplitude";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(390, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 44);
            this.textBox1.TabIndex = 7;
            // 
            // AmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ampdrop);
            this.Controls.Add(this.Ampl);
            this.Controls.Add(this.textBox1);
            this.Name = "AmpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amplitude";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ampdrop;
        private System.Windows.Forms.Label Ampl;
        private System.Windows.Forms.TextBox textBox1;
    }
}