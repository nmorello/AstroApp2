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
            this.loopIn = new System.Windows.Forms.TextBox();
            this.ampIn = new System.Windows.Forms.TextBox();
            this.dutyIn = new System.Windows.Forms.TextBox();
            this.offsetIn = new System.Windows.Forms.TextBox();
            this.rampTimeIn = new System.Windows.Forms.TextBox();
            this.phaseIn = new System.Windows.Forms.TextBox();
            this.selectbut = new System.Windows.Forms.Button();
            this.cancelbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modeSelect
            // 
            this.modeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeSelect.FormattingEnabled = true;
            this.modeSelect.Items.AddRange(new object[] {
            "Select",
            "Sine",
            "Square",
            "Pulse",
            "Triangle",
            "Sawtooth",
            "DC",
            "Arb"});
            this.modeSelect.Location = new System.Drawing.Point(227, 196);
            this.modeSelect.Name = "modeSelect";
            this.modeSelect.Size = new System.Drawing.Size(182, 40);
            this.modeSelect.TabIndex = 0;
            this.modeSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 163);
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
            this.frequency.Location = new System.Drawing.Point(497, 163);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(143, 31);
            this.frequency.TabIndex = 3;
            this.frequency.Text = "Frequency";
            // 
            // amplitude
            // 
            this.amplitude.AutoSize = true;
            this.amplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitude.Location = new System.Drawing.Point(497, 205);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(134, 31);
            this.amplitude.TabIndex = 4;
            this.amplitude.Text = "Amplitude";
            // 
            // offset
            // 
            this.offset.AutoSize = true;
            this.offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offset.Location = new System.Drawing.Point(497, 246);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(88, 31);
            this.offset.TabIndex = 5;
            this.offset.Text = "Offset";
            // 
            // phase
            // 
            this.phase.AutoSize = true;
            this.phase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phase.Location = new System.Drawing.Point(497, 287);
            this.phase.Name = "phase";
            this.phase.Size = new System.Drawing.Size(91, 31);
            this.phase.TabIndex = 6;
            this.phase.Text = "Phase";
            // 
            // duty
            // 
            this.duty.AutoSize = true;
            this.duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duty.Location = new System.Drawing.Point(498, 246);
            this.duty.Name = "duty";
            this.duty.Size = new System.Drawing.Size(71, 31);
            this.duty.TabIndex = 7;
            this.duty.Text = "Duty";
            // 
            // rampTime
            // 
            this.rampTime.AutoSize = true;
            this.rampTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rampTime.Location = new System.Drawing.Point(498, 287);
            this.rampTime.Name = "rampTime";
            this.rampTime.Size = new System.Drawing.Size(153, 31);
            this.rampTime.TabIndex = 8;
            this.rampTime.Text = "Ramp Time";
            // 
            // timeDelta
            // 
            this.timeDelta.AutoSize = true;
            this.timeDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDelta.Location = new System.Drawing.Point(497, 163);
            this.timeDelta.Name = "timeDelta";
            this.timeDelta.Size = new System.Drawing.Size(145, 31);
            this.timeDelta.TabIndex = 9;
            this.timeDelta.Text = "Time Delta";
            // 
            // loopCount
            // 
            this.loopCount.AutoSize = true;
            this.loopCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopCount.Location = new System.Drawing.Point(497, 205);
            this.loopCount.Name = "loopCount";
            this.loopCount.Size = new System.Drawing.Size(154, 31);
            this.loopCount.TabIndex = 10;
            this.loopCount.Text = "Loop Count";
            // 
            // voltage
            // 
            this.voltage.AutoSize = true;
            this.voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltage.Location = new System.Drawing.Point(497, 163);
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
            this.posOrNeg.Location = new System.Drawing.Point(227, 258);
            this.posOrNeg.Name = "posOrNeg";
            this.posOrNeg.Size = new System.Drawing.Size(182, 40);
            this.posOrNeg.TabIndex = 12;
            this.posOrNeg.SelectedIndexChanged += new System.EventHandler(this.posOrNeg_SelectedIndexChanged);
            // 
            // voltageIn
            // 
            this.voltageIn.Location = new System.Drawing.Point(684, 170);
            this.voltageIn.Name = "voltageIn";
            this.voltageIn.Size = new System.Drawing.Size(182, 29);
            this.voltageIn.TabIndex = 13;
            this.voltageIn.TextChanged += new System.EventHandler(this.voltageIn_TextChanged);
            // 
            // timeDIn
            // 
            this.timeDIn.Location = new System.Drawing.Point(684, 170);
            this.timeDIn.Name = "timeDIn";
            this.timeDIn.Size = new System.Drawing.Size(182, 29);
            this.timeDIn.TabIndex = 14;
            // 
            // freqIn
            // 
            this.freqIn.Location = new System.Drawing.Point(684, 170);
            this.freqIn.Name = "freqIn";
            this.freqIn.Size = new System.Drawing.Size(182, 29);
            this.freqIn.TabIndex = 15;
            this.freqIn.TextChanged += new System.EventHandler(this.freqIn_TextChanged);
            // 
            // loopIn
            // 
            this.loopIn.Location = new System.Drawing.Point(684, 209);
            this.loopIn.Name = "loopIn";
            this.loopIn.Size = new System.Drawing.Size(182, 29);
            this.loopIn.TabIndex = 16;
            // 
            // ampIn
            // 
            this.ampIn.Location = new System.Drawing.Point(684, 209);
            this.ampIn.Name = "ampIn";
            this.ampIn.Size = new System.Drawing.Size(182, 29);
            this.ampIn.TabIndex = 17;
            // 
            // dutyIn
            // 
            this.dutyIn.Location = new System.Drawing.Point(684, 248);
            this.dutyIn.Name = "dutyIn";
            this.dutyIn.Size = new System.Drawing.Size(182, 29);
            this.dutyIn.TabIndex = 18;
            // 
            // offsetIn
            // 
            this.offsetIn.Location = new System.Drawing.Point(684, 248);
            this.offsetIn.Name = "offsetIn";
            this.offsetIn.Size = new System.Drawing.Size(182, 29);
            this.offsetIn.TabIndex = 19;
            // 
            // rampTimeIn
            // 
            this.rampTimeIn.Location = new System.Drawing.Point(684, 287);
            this.rampTimeIn.Name = "rampTimeIn";
            this.rampTimeIn.Size = new System.Drawing.Size(182, 29);
            this.rampTimeIn.TabIndex = 20;
            // 
            // phaseIn
            // 
            this.phaseIn.Location = new System.Drawing.Point(684, 287);
            this.phaseIn.Name = "phaseIn";
            this.phaseIn.Size = new System.Drawing.Size(182, 29);
            this.phaseIn.TabIndex = 21;
            // 
            // selectbut
            // 
            this.selectbut.Location = new System.Drawing.Point(370, 452);
            this.selectbut.Name = "selectbut";
            this.selectbut.Size = new System.Drawing.Size(153, 45);
            this.selectbut.TabIndex = 22;
            this.selectbut.Text = "Select";
            this.selectbut.UseVisualStyleBackColor = true;
            this.selectbut.Click += new System.EventHandler(this.selectbut_Click);
            // 
            // cancelbut
            // 
            this.cancelbut.Location = new System.Drawing.Point(540, 452);
            this.cancelbut.Name = "cancelbut";
            this.cancelbut.Size = new System.Drawing.Size(153, 45);
            this.cancelbut.TabIndex = 23;
            this.cancelbut.Text = "Cancel";
            this.cancelbut.UseVisualStyleBackColor = true;
            this.cancelbut.Click += new System.EventHandler(this.cancelbut_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 559);
            this.Controls.Add(this.cancelbut);
            this.Controls.Add(this.selectbut);
            this.Controls.Add(this.phaseIn);
            this.Controls.Add(this.rampTimeIn);
            this.Controls.Add(this.offsetIn);
            this.Controls.Add(this.dutyIn);
            this.Controls.Add(this.ampIn);
            this.Controls.Add(this.loopIn);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.TextBox loopIn;
        private System.Windows.Forms.TextBox ampIn;
        private System.Windows.Forms.TextBox dutyIn;
        private System.Windows.Forms.TextBox offsetIn;
        private System.Windows.Forms.TextBox rampTimeIn;
        private System.Windows.Forms.TextBox phaseIn;
        private System.Windows.Forms.Button selectbut;
        private System.Windows.Forms.Button cancelbut;
    }
}