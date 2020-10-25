namespace SystemTemperature
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.PerformanceMeasure = new LiveCharts.WinForms.SolidGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fieldLoad1 = new System.Windows.Forms.TextBox();
            this.fieldLoad2 = new System.Windows.Forms.TextBox();
            this.fieldLoad3 = new System.Windows.Forms.TextBox();
            this.fieldLoad4 = new System.Windows.Forms.TextBox();
            this.fieldLoad5 = new System.Windows.Forms.TextBox();
            this.fieldLoad6 = new System.Windows.Forms.TextBox();
            this.fieldCurrentTemp = new System.Windows.Forms.TextBox();
            this.fieldMinTemp = new System.Windows.Forms.TextBox();
            this.fieldMaxTemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fieldCpuModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fieldC1MaxTemp = new System.Windows.Forms.TextBox();
            this.fieldC1MinTemp = new System.Windows.Forms.TextBox();
            this.fieldC2MaxTemp = new System.Windows.Forms.TextBox();
            this.fieldC2MinTemp = new System.Windows.Forms.TextBox();
            this.fieldC3MaxTemp = new System.Windows.Forms.TextBox();
            this.fieldC3MinTemp = new System.Windows.Forms.TextBox();
            this.fieldC4MaxTemp = new System.Windows.Forms.TextBox();
            this.fieldC4MinTemp = new System.Windows.Forms.TextBox();
            this.fieldC5MaxTemp = new System.Windows.Forms.TextBox();
            this.fieldC5MinTemp = new System.Windows.Forms.TextBox();
            this.fieldC6MaxTemp = new System.Windows.Forms.TextBox();
            this.fieldC6MinTemp = new System.Windows.Forms.TextBox();
            this.TemperatureBar = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.fieldGpuN = new System.Windows.Forms.TextBox();
            this.fieldGPUName = new System.Windows.Forms.Label();
            this.lGpuTemp = new System.Windows.Forms.Label();
            this.fMBN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(337, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(442, 359);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // PerformanceMeasure
            // 
            this.PerformanceMeasure.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.PerformanceMeasure.CausesValidation = false;
            this.PerformanceMeasure.Location = new System.Drawing.Point(316, -15);
            this.PerformanceMeasure.Name = "PerformanceMeasure";
            this.PerformanceMeasure.Size = new System.Drawing.Size(204, 167);
            this.PerformanceMeasure.TabIndex = 4;
            this.PerformanceMeasure.Text = "solidGauge1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Core #1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Core #2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Core #3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Core #4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Core #5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Core #6:";
            // 
            // fieldLoad1
            // 
            this.fieldLoad1.Enabled = false;
            this.fieldLoad1.Location = new System.Drawing.Point(86, 35);
            this.fieldLoad1.Name = "fieldLoad1";
            this.fieldLoad1.ReadOnly = true;
            this.fieldLoad1.Size = new System.Drawing.Size(100, 20);
            this.fieldLoad1.TabIndex = 11;
            // 
            // fieldLoad2
            // 
            this.fieldLoad2.Enabled = false;
            this.fieldLoad2.Location = new System.Drawing.Point(86, 65);
            this.fieldLoad2.Name = "fieldLoad2";
            this.fieldLoad2.ReadOnly = true;
            this.fieldLoad2.Size = new System.Drawing.Size(100, 20);
            this.fieldLoad2.TabIndex = 12;
            // 
            // fieldLoad3
            // 
            this.fieldLoad3.Enabled = false;
            this.fieldLoad3.Location = new System.Drawing.Point(86, 95);
            this.fieldLoad3.Name = "fieldLoad3";
            this.fieldLoad3.ReadOnly = true;
            this.fieldLoad3.Size = new System.Drawing.Size(100, 20);
            this.fieldLoad3.TabIndex = 13;
            // 
            // fieldLoad4
            // 
            this.fieldLoad4.Enabled = false;
            this.fieldLoad4.Location = new System.Drawing.Point(86, 125);
            this.fieldLoad4.Name = "fieldLoad4";
            this.fieldLoad4.ReadOnly = true;
            this.fieldLoad4.Size = new System.Drawing.Size(100, 20);
            this.fieldLoad4.TabIndex = 14;
            // 
            // fieldLoad5
            // 
            this.fieldLoad5.Enabled = false;
            this.fieldLoad5.Location = new System.Drawing.Point(86, 155);
            this.fieldLoad5.Name = "fieldLoad5";
            this.fieldLoad5.ReadOnly = true;
            this.fieldLoad5.Size = new System.Drawing.Size(100, 20);
            this.fieldLoad5.TabIndex = 15;
            // 
            // fieldLoad6
            // 
            this.fieldLoad6.Enabled = false;
            this.fieldLoad6.Location = new System.Drawing.Point(86, 185);
            this.fieldLoad6.Name = "fieldLoad6";
            this.fieldLoad6.ReadOnly = true;
            this.fieldLoad6.Size = new System.Drawing.Size(100, 20);
            this.fieldLoad6.TabIndex = 16;
            // 
            // fieldCurrentTemp
            // 
            this.fieldCurrentTemp.Enabled = false;
            this.fieldCurrentTemp.Location = new System.Drawing.Point(86, 327);
            this.fieldCurrentTemp.Name = "fieldCurrentTemp";
            this.fieldCurrentTemp.ReadOnly = true;
            this.fieldCurrentTemp.Size = new System.Drawing.Size(144, 20);
            this.fieldCurrentTemp.TabIndex = 17;
            // 
            // fieldMinTemp
            // 
            this.fieldMinTemp.Enabled = false;
            this.fieldMinTemp.Location = new System.Drawing.Point(236, 327);
            this.fieldMinTemp.Name = "fieldMinTemp";
            this.fieldMinTemp.ReadOnly = true;
            this.fieldMinTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldMinTemp.TabIndex = 18;
            // 
            // fieldMaxTemp
            // 
            this.fieldMaxTemp.Enabled = false;
            this.fieldMaxTemp.Location = new System.Drawing.Point(280, 327);
            this.fieldMaxTemp.Name = "fieldMaxTemp";
            this.fieldMaxTemp.ReadOnly = true;
            this.fieldMaxTemp.Size = new System.Drawing.Size(35, 20);
            this.fieldMaxTemp.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Current temp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Min.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Max.";
            // 
            // fieldCpuModel
            // 
            this.fieldCpuModel.Enabled = false;
            this.fieldCpuModel.Location = new System.Drawing.Point(86, 301);
            this.fieldCpuModel.Name = "fieldCpuModel";
            this.fieldCpuModel.ReadOnly = true;
            this.fieldCpuModel.Size = new System.Drawing.Size(144, 20);
            this.fieldCpuModel.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Model:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Max.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Min.";
            // 
            // fieldC1MaxTemp
            // 
            this.fieldC1MaxTemp.Enabled = false;
            this.fieldC1MaxTemp.Location = new System.Drawing.Point(236, 35);
            this.fieldC1MaxTemp.Name = "fieldC1MaxTemp";
            this.fieldC1MaxTemp.ReadOnly = true;
            this.fieldC1MaxTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC1MaxTemp.TabIndex = 26;
            // 
            // fieldC1MinTemp
            // 
            this.fieldC1MinTemp.Enabled = false;
            this.fieldC1MinTemp.Location = new System.Drawing.Point(192, 35);
            this.fieldC1MinTemp.Name = "fieldC1MinTemp";
            this.fieldC1MinTemp.ReadOnly = true;
            this.fieldC1MinTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC1MinTemp.TabIndex = 25;
            // 
            // fieldC2MaxTemp
            // 
            this.fieldC2MaxTemp.Enabled = false;
            this.fieldC2MaxTemp.Location = new System.Drawing.Point(236, 65);
            this.fieldC2MaxTemp.Name = "fieldC2MaxTemp";
            this.fieldC2MaxTemp.ReadOnly = true;
            this.fieldC2MaxTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC2MaxTemp.TabIndex = 30;
            // 
            // fieldC2MinTemp
            // 
            this.fieldC2MinTemp.Enabled = false;
            this.fieldC2MinTemp.Location = new System.Drawing.Point(192, 65);
            this.fieldC2MinTemp.Name = "fieldC2MinTemp";
            this.fieldC2MinTemp.ReadOnly = true;
            this.fieldC2MinTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC2MinTemp.TabIndex = 29;
            // 
            // fieldC3MaxTemp
            // 
            this.fieldC3MaxTemp.Enabled = false;
            this.fieldC3MaxTemp.Location = new System.Drawing.Point(236, 95);
            this.fieldC3MaxTemp.Name = "fieldC3MaxTemp";
            this.fieldC3MaxTemp.ReadOnly = true;
            this.fieldC3MaxTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC3MaxTemp.TabIndex = 32;
            // 
            // fieldC3MinTemp
            // 
            this.fieldC3MinTemp.Enabled = false;
            this.fieldC3MinTemp.Location = new System.Drawing.Point(192, 95);
            this.fieldC3MinTemp.Name = "fieldC3MinTemp";
            this.fieldC3MinTemp.ReadOnly = true;
            this.fieldC3MinTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC3MinTemp.TabIndex = 31;
            // 
            // fieldC4MaxTemp
            // 
            this.fieldC4MaxTemp.Enabled = false;
            this.fieldC4MaxTemp.Location = new System.Drawing.Point(236, 125);
            this.fieldC4MaxTemp.Name = "fieldC4MaxTemp";
            this.fieldC4MaxTemp.ReadOnly = true;
            this.fieldC4MaxTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC4MaxTemp.TabIndex = 34;
            // 
            // fieldC4MinTemp
            // 
            this.fieldC4MinTemp.Enabled = false;
            this.fieldC4MinTemp.Location = new System.Drawing.Point(192, 125);
            this.fieldC4MinTemp.Name = "fieldC4MinTemp";
            this.fieldC4MinTemp.ReadOnly = true;
            this.fieldC4MinTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC4MinTemp.TabIndex = 33;
            // 
            // fieldC5MaxTemp
            // 
            this.fieldC5MaxTemp.Enabled = false;
            this.fieldC5MaxTemp.Location = new System.Drawing.Point(236, 155);
            this.fieldC5MaxTemp.Name = "fieldC5MaxTemp";
            this.fieldC5MaxTemp.ReadOnly = true;
            this.fieldC5MaxTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC5MaxTemp.TabIndex = 36;
            // 
            // fieldC5MinTemp
            // 
            this.fieldC5MinTemp.Enabled = false;
            this.fieldC5MinTemp.Location = new System.Drawing.Point(192, 155);
            this.fieldC5MinTemp.Name = "fieldC5MinTemp";
            this.fieldC5MinTemp.ReadOnly = true;
            this.fieldC5MinTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC5MinTemp.TabIndex = 35;
            // 
            // fieldC6MaxTemp
            // 
            this.fieldC6MaxTemp.Enabled = false;
            this.fieldC6MaxTemp.Location = new System.Drawing.Point(236, 185);
            this.fieldC6MaxTemp.Name = "fieldC6MaxTemp";
            this.fieldC6MaxTemp.ReadOnly = true;
            this.fieldC6MaxTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC6MaxTemp.TabIndex = 38;
            // 
            // fieldC6MinTemp
            // 
            this.fieldC6MinTemp.Enabled = false;
            this.fieldC6MinTemp.Location = new System.Drawing.Point(192, 185);
            this.fieldC6MinTemp.Name = "fieldC6MinTemp";
            this.fieldC6MinTemp.ReadOnly = true;
            this.fieldC6MinTemp.Size = new System.Drawing.Size(38, 20);
            this.fieldC6MinTemp.TabIndex = 37;
            // 
            // TemperatureBar
            // 
            this.TemperatureBar.ForeColor = System.Drawing.Color.DarkRed;
            this.TemperatureBar.Location = new System.Drawing.Point(86, 256);
            this.TemperatureBar.Maximum = 120;
            this.TemperatureBar.Name = "TemperatureBar";
            this.TemperatureBar.Size = new System.Drawing.Size(188, 24);
            this.TemperatureBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.TemperatureBar.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "GPU Temp:";
            // 
            // fieldGpuN
            // 
            this.fieldGpuN.Enabled = false;
            this.fieldGpuN.Location = new System.Drawing.Point(86, 230);
            this.fieldGpuN.Name = "fieldGpuN";
            this.fieldGpuN.ReadOnly = true;
            this.fieldGpuN.Size = new System.Drawing.Size(188, 20);
            this.fieldGpuN.TabIndex = 41;
            // 
            // fieldGPUName
            // 
            this.fieldGPUName.AutoSize = true;
            this.fieldGPUName.Location = new System.Drawing.Point(16, 233);
            this.fieldGPUName.Name = "fieldGPUName";
            this.fieldGPUName.Size = new System.Drawing.Size(62, 13);
            this.fieldGPUName.TabIndex = 42;
            this.fieldGPUName.Text = "GPU name:";
            // 
            // lGpuTemp
            // 
            this.lGpuTemp.AutoSize = true;
            this.lGpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGpuTemp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lGpuTemp.Location = new System.Drawing.Point(280, 256);
            this.lGpuTemp.Name = "lGpuTemp";
            this.lGpuTemp.Size = new System.Drawing.Size(39, 24);
            this.lGpuTemp.TabIndex = 43;
            this.lGpuTemp.Text = "0°C";
            // 
            // fMBN
            // 
            this.fMBN.Enabled = false;
            this.fMBN.Location = new System.Drawing.Point(316, 185);
            this.fMBN.Name = "fMBN";
            this.fMBN.ReadOnly = true;
            this.fMBN.Size = new System.Drawing.Size(204, 20);
            this.fMBN.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(313, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 15);
            this.label14.TabIndex = 45;
            this.label14.Text = "Motherboard:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Avg.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 388);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fMBN);
            this.Controls.Add(this.lGpuTemp);
            this.Controls.Add(this.fieldGPUName);
            this.Controls.Add(this.fieldGpuN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TemperatureBar);
            this.Controls.Add(this.fieldC6MaxTemp);
            this.Controls.Add(this.fieldC6MinTemp);
            this.Controls.Add(this.fieldC5MaxTemp);
            this.Controls.Add(this.fieldC5MinTemp);
            this.Controls.Add(this.fieldC4MaxTemp);
            this.Controls.Add(this.fieldC4MinTemp);
            this.Controls.Add(this.fieldC3MaxTemp);
            this.Controls.Add(this.fieldC3MinTemp);
            this.Controls.Add(this.fieldC2MaxTemp);
            this.Controls.Add(this.fieldC2MinTemp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fieldC1MaxTemp);
            this.Controls.Add(this.fieldC1MinTemp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fieldCpuModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fieldMaxTemp);
            this.Controls.Add(this.fieldMinTemp);
            this.Controls.Add(this.fieldCurrentTemp);
            this.Controls.Add(this.fieldLoad6);
            this.Controls.Add(this.fieldLoad5);
            this.Controls.Add(this.fieldLoad4);
            this.Controls.Add(this.fieldLoad3);
            this.Controls.Add(this.fieldLoad2);
            this.Controls.Add(this.fieldLoad1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PerformanceMeasure);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "CPU Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        public LiveCharts.WinForms.SolidGauge PerformanceMeasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox fieldLoad1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox fieldLoad2;
        public System.Windows.Forms.TextBox fieldLoad3;
        public System.Windows.Forms.TextBox fieldLoad4;
        public System.Windows.Forms.TextBox fieldLoad5;
        public System.Windows.Forms.TextBox fieldLoad6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox fieldCpuModel;
        public System.Windows.Forms.TextBox fieldCurrentTemp;
        public System.Windows.Forms.TextBox fieldMinTemp;
        public System.Windows.Forms.TextBox fieldMaxTemp;
        public System.Windows.Forms.TextBox fieldC1MaxTemp;
        public System.Windows.Forms.TextBox fieldC1MinTemp;
        public System.Windows.Forms.TextBox fieldC2MaxTemp;
        public System.Windows.Forms.TextBox fieldC2MinTemp;
        public System.Windows.Forms.TextBox fieldC3MaxTemp;
        public System.Windows.Forms.TextBox fieldC3MinTemp;
        public System.Windows.Forms.TextBox fieldC4MaxTemp;
        public System.Windows.Forms.TextBox fieldC4MinTemp;
        public System.Windows.Forms.TextBox fieldC5MaxTemp;
        public System.Windows.Forms.TextBox fieldC5MinTemp;
        public System.Windows.Forms.TextBox fieldC6MaxTemp;
        public System.Windows.Forms.TextBox fieldC6MinTemp;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox fieldGpuN;
        public System.Windows.Forms.Label fieldGPUName;
        public System.Windows.Forms.ProgressBar TemperatureBar;
        public System.Windows.Forms.Label lGpuTemp;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox fMBN;
        private System.Windows.Forms.Label label15;
    }
}

