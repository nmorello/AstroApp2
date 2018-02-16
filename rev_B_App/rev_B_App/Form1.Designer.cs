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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.desbut1 = new System.Windows.Forms.Button();
            this.desbut7 = new System.Windows.Forms.Button();
            this.desbut8 = new System.Windows.Forms.Button();
            this.desbut6 = new System.Windows.Forms.Button();
            this.desbut5 = new System.Windows.Forms.Button();
            this.desbut4 = new System.Windows.Forms.Button();
            this.desbut3 = new System.Windows.Forms.Button();
            this.desbut2 = new System.Windows.Forms.Button();
            this.saveBank = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // freqbox
            // 
            this.freqbox.Location = new System.Drawing.Point(260, 78);
            this.freqbox.MaxLength = 3;
            this.freqbox.Name = "freqbox";
            this.freqbox.Size = new System.Drawing.Size(121, 29);
            this.freqbox.TabIndex = 0;
            this.freqbox.TextChanged += new System.EventHandler(this.freqbox_TextChanged);
            this.freqbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.freqbox_KeyPress);
            // 
            // ampbox
            // 
            this.ampbox.Location = new System.Drawing.Point(260, 124);
            this.ampbox.MaxLength = 3;
            this.ampbox.Name = "ampbox";
            this.ampbox.Size = new System.Drawing.Size(121, 29);
            this.ampbox.TabIndex = 1;
            this.ampbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ampbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 128);
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
            this.groupBox1.Size = new System.Drawing.Size(671, 249);
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
            this.ampdrop.Location = new System.Drawing.Point(398, 121);
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
            this.freqdrop.Location = new System.Drawing.Point(398, 78);
            this.freqdrop.Name = "freqdrop";
            this.freqdrop.Size = new System.Drawing.Size(79, 32);
            this.freqdrop.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 429);
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
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox3.Location = new System.Drawing.Point(494, 476);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 50);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Channel 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Channel 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Channel 3\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(650, 619);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Channel 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(650, 666);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 41);
            this.button5.TabIndex = 12;
            this.button5.Text = "Channel 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(650, 713);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 41);
            this.button6.TabIndex = 13;
            this.button6.Text = "Channel 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(650, 760);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 41);
            this.button7.TabIndex = 14;
            this.button7.Text = "Channel 7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(650, 807);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 41);
            this.button8.TabIndex = 15;
            this.button8.Text = "Channel 8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(832, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Start";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(832, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Start\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(832, 583);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(832, 630);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Start";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(832, 677);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Start";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(832, 724);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 30);
            this.label10.TabIndex = 22;
            this.label10.Text = "Start";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(832, 771);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 30);
            this.label11.TabIndex = 21;
            this.label11.Text = "Start";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(832, 818);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 30);
            this.label12.TabIndex = 20;
            this.label12.Text = "Start";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1262, 694);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 173);
            this.button9.TabIndex = 24;
            this.button9.Text = "Connect to WG-800";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1174, 889);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(1254, 889);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(131, 25);
            this.status.TabIndex = 26;
            this.status.Text = "Disconnected";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(636, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 44);
            this.label14.TabIndex = 27;
            this.label14.Text = "Channel";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(814, 429);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 44);
            this.label15.TabIndex = 28;
            this.label15.Text = "Wave";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(956, 429);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(211, 44);
            this.description.TabIndex = 29;
            this.description.Text = "Description";
            // 
            // desbut1
            // 
            this.desbut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut1.Location = new System.Drawing.Point(1033, 476);
            this.desbut1.Name = "desbut1";
            this.desbut1.Size = new System.Drawing.Size(57, 44);
            this.desbut1.TabIndex = 30;
            this.desbut1.Text = "...";
            this.desbut1.UseVisualStyleBackColor = true;
            this.desbut1.Click += new System.EventHandler(this.desbut1_Click);
            // 
            // desbut7
            // 
            this.desbut7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut7.Location = new System.Drawing.Point(1033, 762);
            this.desbut7.Name = "desbut7";
            this.desbut7.Size = new System.Drawing.Size(57, 44);
            this.desbut7.TabIndex = 31;
            this.desbut7.Text = "...";
            this.desbut7.UseVisualStyleBackColor = true;
            // 
            // desbut8
            // 
            this.desbut8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut8.Location = new System.Drawing.Point(1033, 812);
            this.desbut8.Name = "desbut8";
            this.desbut8.Size = new System.Drawing.Size(57, 44);
            this.desbut8.TabIndex = 32;
            this.desbut8.Text = "...";
            this.desbut8.UseVisualStyleBackColor = true;
            // 
            // desbut6
            // 
            this.desbut6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut6.Location = new System.Drawing.Point(1033, 712);
            this.desbut6.Name = "desbut6";
            this.desbut6.Size = new System.Drawing.Size(57, 44);
            this.desbut6.TabIndex = 33;
            this.desbut6.Text = "...";
            this.desbut6.UseVisualStyleBackColor = true;
            // 
            // desbut5
            // 
            this.desbut5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut5.Location = new System.Drawing.Point(1033, 663);
            this.desbut5.Name = "desbut5";
            this.desbut5.Size = new System.Drawing.Size(57, 44);
            this.desbut5.TabIndex = 34;
            this.desbut5.Text = "...";
            this.desbut5.UseVisualStyleBackColor = true;
            // 
            // desbut4
            // 
            this.desbut4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut4.Location = new System.Drawing.Point(1033, 616);
            this.desbut4.Name = "desbut4";
            this.desbut4.Size = new System.Drawing.Size(57, 44);
            this.desbut4.TabIndex = 35;
            this.desbut4.Text = "...";
            this.desbut4.UseVisualStyleBackColor = true;
            // 
            // desbut3
            // 
            this.desbut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut3.Location = new System.Drawing.Point(1033, 569);
            this.desbut3.Name = "desbut3";
            this.desbut3.Size = new System.Drawing.Size(57, 44);
            this.desbut3.TabIndex = 36;
            this.desbut3.Text = "...";
            this.desbut3.UseVisualStyleBackColor = true;
            // 
            // desbut2
            // 
            this.desbut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desbut2.Location = new System.Drawing.Point(1033, 520);
            this.desbut2.Name = "desbut2";
            this.desbut2.Size = new System.Drawing.Size(57, 44);
            this.desbut2.TabIndex = 37;
            this.desbut2.Text = "...";
            this.desbut2.UseVisualStyleBackColor = true;
            this.desbut2.Click += new System.EventHandler(this.desbut2_Click);
            // 
            // saveBank
            // 
            this.saveBank.Location = new System.Drawing.Point(1262, 487);
            this.saveBank.Name = "saveBank";
            this.saveBank.Size = new System.Drawing.Size(123, 173);
            this.saveBank.TabIndex = 38;
            this.saveBank.Text = "Save Bank";
            this.saveBank.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(492, 666);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 173);
            this.button10.TabIndex = 39;
            this.button10.Text = "Restore Defualt Values";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 963);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.saveBank);
            this.Controls.Add(this.desbut2);
            this.Controls.Add(this.desbut3);
            this.Controls.Add(this.desbut4);
            this.Controls.Add(this.desbut5);
            this.Controls.Add(this.desbut6);
            this.Controls.Add(this.desbut8);
            this.Controls.Add(this.desbut7);
            this.Controls.Add(this.desbut1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AstroApp WG-800";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button desbut1;
        private System.Windows.Forms.Button desbut7;
        private System.Windows.Forms.Button desbut8;
        private System.Windows.Forms.Button desbut6;
        private System.Windows.Forms.Button desbut5;
        private System.Windows.Forms.Button desbut4;
        private System.Windows.Forms.Button desbut3;
        private System.Windows.Forms.Button desbut2;
        private System.Windows.Forms.Button saveBank;
        private System.Windows.Forms.Button button10;
    }
}

