namespace rev_B_App
{
    partial class Form3
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
            this.modeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.Label();
            this.amplitude = new System.Windows.Forms.Label();
            this.offset = new System.Windows.Forms.Label();
            this.phase = new System.Windows.Forms.Label();
            this.duty = new System.Windows.Forms.Label();
            this.rampTime = new System.Windows.Forms.Label();
            this.timeDelta = new System.Windows.Forms.Label();
            this.loopCount = new System.Windows.Forms.Label();
            this.voltage = new System.Windows.Forms.Label();
            this.posOrNeg = new System.Windows.Forms.ComboBox();
            this.voltageIn = new System.Windows.Forms.TextBox();
            this.timeDIn = new System.Windows.Forms.TextBox();
            this.freqIn = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modeSelect
            // 
            this.modeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeSelect.FormattingEnabled = true;
            this.modeSelect.Items.AddRange(new object[] {
            "Select",
            "SINE",
            "SQUARE",
            "PULSE",
            "TRIANGLE",
            "SAWTOOTH",
            "ARB",
            "DC"});
            this.modeSelect.Location = new System.Drawing.Point(82, 157);
            this.modeSelect.Name = "modeSelect";
            this.modeSelect.Size = new System.Drawing.Size(182, 40);
            this.modeSelect.TabIndex = 0;
            this.modeSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frequency
            // 
            this.frequency.AutoSize = true;
            this.frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequency.Location = new System.Drawing.Point(363, 157);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(143, 31);
            this.frequency.TabIndex = 3;
            this.frequency.Text = "Frequency";
            // 
            // amplitude
            // 
            this.amplitude.AutoSize = true;
            this.amplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitude.Location = new System.Drawing.Point(363, 199);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(134, 31);
            this.amplitude.TabIndex = 4;
            this.amplitude.Text = "Amplitude";
            // 
            // offset
            // 
            this.offset.AutoSize = true;
            this.offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offset.Location = new System.Drawing.Point(363, 240);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(88, 31);
            this.offset.TabIndex = 5;
            this.offset.Text = "Offset";
            // 
            // phase
            // 
            this.phase.AutoSize = true;
            this.phase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phase.Location = new System.Drawing.Point(363, 281);
            this.phase.Name = "phase";
            this.phase.Size = new System.Drawing.Size(91, 31);
            this.phase.TabIndex = 6;
            this.phase.Text = "Phase";
            // 
            // duty
            // 
            this.duty.AutoSize = true;
            this.duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duty.Location = new System.Drawing.Point(364, 240);
            this.duty.Name = "duty";
            this.duty.Size = new System.Drawing.Size(71, 31);
            this.duty.TabIndex = 7;
            this.duty.Text = "Duty";
            // 
            // rampTime
            // 
            this.rampTime.AutoSize = true;
            this.rampTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rampTime.Location = new System.Drawing.Point(364, 281);
            this.rampTime.Name = "rampTime";
            this.rampTime.Size = new System.Drawing.Size(153, 31);
            this.rampTime.TabIndex = 8;
            this.rampTime.Text = "Ramp Time";
            // 
            // timeDelta
            // 
            this.timeDelta.AutoSize = true;
            this.timeDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDelta.Location = new System.Drawing.Point(363, 157);
            this.timeDelta.Name = "timeDelta";
            this.timeDelta.Size = new System.Drawing.Size(145, 31);
            this.timeDelta.TabIndex = 9;
            this.timeDelta.Text = "Time Delta";
            // 
            // loopCount
            // 
            this.loopCount.AutoSize = true;
            this.loopCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopCount.Location = new System.Drawing.Point(363, 199);
            this.loopCount.Name = "loopCount";
            this.loopCount.Size = new System.Drawing.Size(154, 31);
            this.loopCount.TabIndex = 10;
            this.loopCount.Text = "Loop Count";
            // 
            // voltage
            // 
            this.voltage.AutoSize = true;
            this.voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltage.Location = new System.Drawing.Point(363, 157);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(106, 31);
            this.voltage.TabIndex = 11;
            this.voltage.Text = "Voltage";
            // 
            // posOrNeg
            // 
            this.posOrNeg.BackColor = System.Drawing.SystemColors.Window;
            this.posOrNeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.posOrNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posOrNeg.FormattingEnabled = true;
            this.posOrNeg.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.posOrNeg.Location = new System.Drawing.Point(82, 219);
            this.posOrNeg.Name = "posOrNeg";
            this.posOrNeg.Size = new System.Drawing.Size(182, 40);
            this.posOrNeg.TabIndex = 12;
            this.posOrNeg.SelectedIndexChanged += new System.EventHandler(this.posOrNeg_SelectedIndexChanged);
            // 
            // voltageIn
            // 
            this.voltageIn.Location = new System.Drawing.Point(550, 164);
            this.voltageIn.Name = "voltageIn";
            this.voltageIn.Size = new System.Drawing.Size(182, 29);
            this.voltageIn.TabIndex = 13;
            this.voltageIn.TextChanged += new System.EventHandler(this.voltageIn_TextChanged);
            // 
            // timeDIn
            // 
            this.timeDIn.Location = new System.Drawing.Point(550, 164);
            this.timeDIn.Name = "timeDIn";
            this.timeDIn.Size = new System.Drawing.Size(182, 29);
            this.timeDIn.TabIndex = 14;
            // 
            // freqIn
            // 
            this.freqIn.Location = new System.Drawing.Point(550, 164);
            this.freqIn.Name = "freqIn";
            this.freqIn.Size = new System.Drawing.Size(182, 29);
            this.freqIn.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(738, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 29);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(550, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 29);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(550, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 29);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(738, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 29);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(550, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 29);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(738, 283);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 29);
            this.textBox6.TabIndex = 21;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 559);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.freqIn);
            this.Controls.Add(this.timeDIn);
            this.Controls.Add(this.voltageIn);
            this.Controls.Add(this.posOrNeg);
            this.Controls.Add(this.voltage);
            this.Controls.Add(this.loopCount);
            this.Controls.Add(this.timeDelta);
            this.Controls.Add(this.rampTime);
            this.Controls.Add(this.duty);
            this.Controls.Add(this.phase);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.amplitude);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modeSelect);
            this.Name = "Form3";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frequency;
        private System.Windows.Forms.Label amplitude;
        private System.Windows.Forms.Label offset;
        private System.Windows.Forms.Label phase;
        private System.Windows.Forms.Label duty;
        private System.Windows.Forms.Label rampTime;
        private System.Windows.Forms.Label timeDelta;
        private System.Windows.Forms.Label loopCount;
        private System.Windows.Forms.Label voltage;
        private System.Windows.Forms.ComboBox posOrNeg;
        private System.Windows.Forms.TextBox voltageIn;
        private System.Windows.Forms.TextBox timeDIn;
        private System.Windows.Forms.TextBox freqIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}