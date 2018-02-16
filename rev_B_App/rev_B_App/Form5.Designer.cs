namespace rev_B_App
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wave = new System.Windows.Forms.Label();
            this.freqtext = new System.Windows.Forms.Label();
            this.amptext = new System.Windows.Forms.Label();
            this.offsettext = new System.Windows.Forms.Label();
            this.phasetext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Wave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parameter(s)";
            // 
            // wave
            // 
            this.wave.AutoSize = true;
            this.wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wave.Location = new System.Drawing.Point(165, 150);
            this.wave.Name = "wave";
            this.wave.Size = new System.Drawing.Size(0, 32);
            this.wave.TabIndex = 2;
            this.wave.Click += new System.EventHandler(this.wave_Click);
            // 
            // freqtext
            // 
            this.freqtext.AutoSize = true;
            this.freqtext.Location = new System.Drawing.Point(424, 110);
            this.freqtext.Name = "freqtext";
            this.freqtext.Size = new System.Drawing.Size(0, 25);
            this.freqtext.TabIndex = 3;
            // 
            // amptext
            // 
            this.amptext.AutoSize = true;
            this.amptext.Location = new System.Drawing.Point(429, 150);
            this.amptext.Name = "amptext";
            this.amptext.Size = new System.Drawing.Size(64, 25);
            this.amptext.TabIndex = 4;
            this.amptext.Text = "label3";
            // 
            // offsettext
            // 
            this.offsettext.AutoSize = true;
            this.offsettext.Location = new System.Drawing.Point(429, 186);
            this.offsettext.Name = "offsettext";
            this.offsettext.Size = new System.Drawing.Size(64, 25);
            this.offsettext.TabIndex = 5;
            this.offsettext.Text = "label4";
            // 
            // phasetext
            // 
            this.phasetext.AutoSize = true;
            this.phasetext.Location = new System.Drawing.Point(429, 220);
            this.phasetext.Name = "phasetext";
            this.phasetext.Size = new System.Drawing.Size(64, 25);
            this.phasetext.TabIndex = 6;
            this.phasetext.Text = "label5";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 564);
            this.Controls.Add(this.phasetext);
            this.Controls.Add(this.offsettext);
            this.Controls.Add(this.amptext);
            this.Controls.Add(this.freqtext);
            this.Controls.Add(this.wave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wave;
        private System.Windows.Forms.Label freqtext;
        private System.Windows.Forms.Label amptext;
        private System.Windows.Forms.Label offsettext;
        private System.Windows.Forms.Label phasetext;
    }
}