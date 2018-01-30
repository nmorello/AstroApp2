namespace rev_B_App
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
            this.freqbox = new System.Windows.Forms.TextBox();
            this.ampbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ampdrop = new System.Windows.Forms.ComboBox();
            this.freqdrop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.channel1 = new System.Windows.Forms.TextBox();
            this.channel2 = new System.Windows.Forms.TextBox();
            this.channel3 = new System.Windows.Forms.TextBox();
            this.channel4 = new System.Windows.Forms.TextBox();
            this.channel5 = new System.Windows.Forms.TextBox();
            this.channel6 = new System.Windows.Forms.TextBox();
            this.channel7 = new System.Windows.Forms.TextBox();
            this.channel8 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // freqbox
            // 
            this.freqbox.Location = new System.Drawing.Point(311, 65);
            this.freqbox.Name = "freqbox";
            this.freqbox.Size = new System.Drawing.Size(121, 29);
            this.freqbox.TabIndex = 0;
            // 
            // ampbox
            // 
            this.ampbox.Location = new System.Drawing.Point(311, 111);
            this.ampbox.Name = "ampbox";
            this.ampbox.Size = new System.Drawing.Size(121, 29);
            this.ampbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frequency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amplitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "AstroNova WG-800 Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ampdrop);
            this.groupBox1.Controls.Add(this.freqdrop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ampbox);
            this.groupBox1.Controls.Add(this.freqbox);
            this.groupBox1.Location = new System.Drawing.Point(496, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master";
            // 
            // ampdrop
            // 
            this.ampdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ampdrop.FormattingEnabled = true;
            this.ampdrop.Items.AddRange(new object[] {
            "mV",
            "V"});
            this.ampdrop.Location = new System.Drawing.Point(449, 108);
            this.ampdrop.Name = "ampdrop";
            this.ampdrop.Size = new System.Drawing.Size(79, 32);
            this.ampdrop.TabIndex = 5;
            // 
            // freqdrop
            // 
            this.freqdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.freqdrop.FormattingEnabled = true;
            this.freqdrop.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz"});
            this.freqdrop.Location = new System.Drawing.Point(449, 65);
            this.freqdrop.Name = "freqdrop";
            this.freqdrop.Size = new System.Drawing.Size(79, 32);
            this.freqdrop.TabIndex = 4;
            this.freqdrop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bank";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox3.Location = new System.Drawing.Point(807, 405);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 50);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Channel 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Channel 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Channel 3\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 610);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Channel 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 657);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 41);
            this.button5.TabIndex = 12;
            this.button5.Text = "Channel 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(123, 704);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 41);
            this.button6.TabIndex = 13;
            this.button6.Text = "Channel 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(123, 751);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 41);
            this.button7.TabIndex = 14;
            this.button7.Text = "Channel 7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(123, 798);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 41);
            this.button8.TabIndex = 15;
            this.button8.Text = "Channel 8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // channel1
            // 
            this.channel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel1.Location = new System.Drawing.Point(258, 467);
            this.channel1.Name = "channel1";
            this.channel1.Size = new System.Drawing.Size(100, 39);
            this.channel1.TabIndex = 16;
            // 
            // channel2
            // 
            this.channel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel2.Location = new System.Drawing.Point(258, 516);
            this.channel2.Name = "channel2";
            this.channel2.Size = new System.Drawing.Size(100, 39);
            this.channel2.TabIndex = 17;
            // 
            // channel3
            // 
            this.channel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel3.Location = new System.Drawing.Point(258, 561);
            this.channel3.Name = "channel3";
            this.channel3.Size = new System.Drawing.Size(100, 39);
            this.channel3.TabIndex = 18;
            // 
            // channel4
            // 
            this.channel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel4.Location = new System.Drawing.Point(258, 612);
            this.channel4.Name = "channel4";
            this.channel4.Size = new System.Drawing.Size(100, 39);
            this.channel4.TabIndex = 19;
            // 
            // channel5
            // 
            this.channel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel5.Location = new System.Drawing.Point(258, 657);
            this.channel5.Name = "channel5";
            this.channel5.Size = new System.Drawing.Size(100, 39);
            this.channel5.TabIndex = 20;
            // 
            // channel6
            // 
            this.channel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel6.Location = new System.Drawing.Point(258, 706);
            this.channel6.Name = "channel6";
            this.channel6.Size = new System.Drawing.Size(100, 39);
            this.channel6.TabIndex = 21;
            // 
            // channel7
            // 
            this.channel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel7.Location = new System.Drawing.Point(258, 751);
            this.channel7.Name = "channel7";
            this.channel7.Size = new System.Drawing.Size(100, 39);
            this.channel7.TabIndex = 22;
            // 
            // channel8
            // 
            this.channel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel8.Location = new System.Drawing.Point(258, 800);
            this.channel8.Name = "channel8";
            this.channel8.Size = new System.Drawing.Size(100, 39);
            this.channel8.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 963);
            this.Controls.Add(this.channel8);
            this.Controls.Add(this.channel7);
            this.Controls.Add(this.channel6);
            this.Controls.Add(this.channel5);
            this.Controls.Add(this.channel4);
            this.Controls.Add(this.channel3);
            this.Controls.Add(this.channel2);
            this.Controls.Add(this.channel1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "AstroApp WG-800";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox freqbox;
        private System.Windows.Forms.TextBox ampbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ampdrop;
        private System.Windows.Forms.ComboBox freqdrop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox channel1;
        private System.Windows.Forms.TextBox channel2;
        private System.Windows.Forms.TextBox channel3;
        private System.Windows.Forms.TextBox channel4;
        private System.Windows.Forms.TextBox channel5;
        private System.Windows.Forms.TextBox channel6;
        private System.Windows.Forms.TextBox channel7;
        private System.Windows.Forms.TextBox channel8;
    }
}

