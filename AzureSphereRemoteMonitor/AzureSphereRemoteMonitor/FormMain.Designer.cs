namespace AzureSphereRemoteMonitor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.humid = new System.Windows.Forms.Label();
            this.ambiTemp = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.aY = new System.Windows.Forms.Label();
            this.aZ = new System.Windows.Forms.Label();
            this.TempTh = new System.Windows.Forms.Label();
            this.TempThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sysstatus = new System.Windows.Forms.Label();
            this.SetTemp = new System.Windows.Forms.Button();
            this.msgt = new System.Windows.Forms.Label();
            this.msgTime = new System.Windows.Forms.Label();
            this.aX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gZ = new System.Windows.Forms.Label();
            this.gY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.altitude = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.light = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rssi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // humid
            // 
            this.humid.AutoSize = true;
            this.humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humid.ForeColor = System.Drawing.Color.Black;
            this.humid.Location = new System.Drawing.Point(5, 82);
            this.humid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.humid.Name = "humid";
            this.humid.Size = new System.Drawing.Size(27, 24);
            this.humid.TabIndex = 15;
            this.humid.Text = "Z:";
            // 
            // ambiTemp
            // 
            this.ambiTemp.AutoSize = true;
            this.ambiTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiTemp.ForeColor = System.Drawing.Color.Black;
            this.ambiTemp.Location = new System.Drawing.Point(5, 52);
            this.ambiTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ambiTemp.Name = "ambiTemp";
            this.ambiTemp.Size = new System.Drawing.Size(27, 24);
            this.ambiTemp.TabIndex = 14;
            this.ambiTemp.Text = "Y:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(260, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(437, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Azure Sphere Remote Sensing Car";
            // 
            // aY
            // 
            this.aY.AutoSize = true;
            this.aY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aY.ForeColor = System.Drawing.Color.Black;
            this.aY.Location = new System.Drawing.Point(53, 52);
            this.aY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aY.Name = "aY";
            this.aY.Size = new System.Drawing.Size(40, 24);
            this.aY.TabIndex = 29;
            this.aY.Text = "null";
            // 
            // aZ
            // 
            this.aZ.AutoSize = true;
            this.aZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aZ.ForeColor = System.Drawing.Color.Black;
            this.aZ.Location = new System.Drawing.Point(53, 82);
            this.aZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aZ.Name = "aZ";
            this.aZ.Size = new System.Drawing.Size(40, 24);
            this.aZ.TabIndex = 30;
            this.aZ.Text = "null";
            // 
            // TempTh
            // 
            this.TempTh.AutoSize = true;
            this.TempTh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempTh.ForeColor = System.Drawing.Color.Black;
            this.TempTh.Location = new System.Drawing.Point(527, 331);
            this.TempTh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TempTh.Name = "TempTh";
            this.TempTh.Size = new System.Drawing.Size(250, 24);
            this.TempTh.TabIndex = 31;
            this.TempTh.Text = "Temperature Threshold (C) :";
            // 
            // TempThreshold
            // 
            this.TempThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempThreshold.Location = new System.Drawing.Point(797, 329);
            this.TempThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.TempThreshold.Name = "TempThreshold";
            this.TempThreshold.Size = new System.Drawing.Size(76, 28);
            this.TempThreshold.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(527, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Relay Status :";
            // 
            // sysstatus
            // 
            this.sysstatus.AutoSize = true;
            this.sysstatus.BackColor = System.Drawing.Color.Silver;
            this.sysstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysstatus.ForeColor = System.Drawing.Color.Teal;
            this.sysstatus.Location = new System.Drawing.Point(653, 355);
            this.sysstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sysstatus.Name = "sysstatus";
            this.sysstatus.Size = new System.Drawing.Size(52, 24);
            this.sysstatus.TabIndex = 34;
            this.sysstatus.Text = "OFF";
            // 
            // SetTemp
            // 
            this.SetTemp.BackColor = System.Drawing.Color.Yellow;
            this.SetTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SetTemp.Location = new System.Drawing.Point(890, 328);
            this.SetTemp.Margin = new System.Windows.Forms.Padding(2);
            this.SetTemp.Name = "SetTemp";
            this.SetTemp.Size = new System.Drawing.Size(59, 29);
            this.SetTemp.TabIndex = 35;
            this.SetTemp.Text = "Set";
            this.SetTemp.UseVisualStyleBackColor = false;
            this.SetTemp.Click += new System.EventHandler(this.SetTemp_Click);
            // 
            // msgt
            // 
            this.msgt.AutoSize = true;
            this.msgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgt.ForeColor = System.Drawing.Color.Black;
            this.msgt.Location = new System.Drawing.Point(38, 344);
            this.msgt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgt.Name = "msgt";
            this.msgt.Size = new System.Drawing.Size(140, 24);
            this.msgt.TabIndex = 36;
            this.msgt.Text = "Message Time:";
            // 
            // msgTime
            // 
            this.msgTime.AutoSize = true;
            this.msgTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTime.ForeColor = System.Drawing.Color.Black;
            this.msgTime.Location = new System.Drawing.Point(203, 344);
            this.msgTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgTime.Name = "msgTime";
            this.msgTime.Size = new System.Drawing.Size(40, 24);
            this.msgTime.TabIndex = 37;
            this.msgTime.Text = "null";
            // 
            // aX
            // 
            this.aX.AutoSize = true;
            this.aX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aX.ForeColor = System.Drawing.Color.Black;
            this.aX.Location = new System.Drawing.Point(53, 24);
            this.aX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aX.Name = "aX";
            this.aX.Size = new System.Drawing.Size(40, 24);
            this.aX.TabIndex = 39;
            this.aX.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Z:";
            // 
            // gZ
            // 
            this.gZ.AutoSize = true;
            this.gZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gZ.ForeColor = System.Drawing.Color.Black;
            this.gZ.Location = new System.Drawing.Point(55, 102);
            this.gZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gZ.Name = "gZ";
            this.gZ.Size = new System.Drawing.Size(40, 24);
            this.gZ.TabIndex = 41;
            this.gZ.Text = "null";
            // 
            // gY
            // 
            this.gY.AutoSize = true;
            this.gY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gY.ForeColor = System.Drawing.Color.Black;
            this.gY.Location = new System.Drawing.Point(55, 63);
            this.gY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gY.Name = "gY";
            this.gY.Size = new System.Drawing.Size(40, 24);
            this.gY.TabIndex = 43;
            this.gY.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Y:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // gX
            // 
            this.gX.AutoSize = true;
            this.gX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gX.ForeColor = System.Drawing.Color.Black;
            this.gX.Location = new System.Drawing.Point(55, 24);
            this.gX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gX.Name = "gX";
            this.gX.Size = new System.Drawing.Size(40, 24);
            this.gX.TabIndex = 46;
            this.gX.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "X:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gX);
            this.groupBox1.Controls.Add(this.gZ);
            this.groupBox1.Controls.Add(this.gY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(42, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceleration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.aX);
            this.groupBox2.Controls.Add(this.ambiTemp);
            this.groupBox2.Controls.Add(this.aY);
            this.groupBox2.Controls.Add(this.humid);
            this.groupBox2.Controls.Add(this.aZ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox2.Location = new System.Drawing.Point(44, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angular Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rssi);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.light);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.temperature);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.altitude);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.pressure);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox3.Location = new System.Drawing.Point(266, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 150);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enviroment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Pressure:";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Location = new System.Drawing.Point(102, 24);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(40, 24);
            this.pressure.TabIndex = 51;
            this.pressure.Text = "null";
            // 
            // altitude
            // 
            this.altitude.AutoSize = true;
            this.altitude.Location = new System.Drawing.Point(102, 48);
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(40, 24);
            this.altitude.TabIndex = 53;
            this.altitude.Text = "null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 52;
            this.label8.Text = "Altitude:";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(102, 72);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(40, 24);
            this.temperature.TabIndex = 55;
            this.temperature.Text = "null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Temp:";
            // 
            // light
            // 
            this.light.AutoSize = true;
            this.light.Location = new System.Drawing.Point(102, 96);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(40, 24);
            this.light.TabIndex = 57;
            this.light.Text = "null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "Light:";
            // 
            // rssi
            // 
            this.rssi.AutoSize = true;
            this.rssi.Location = new System.Drawing.Point(102, 120);
            this.rssi.Name = "rssi";
            this.rssi.Size = new System.Drawing.Size(40, 24);
            this.rssi.TabIndex = 59;
            this.rssi.Text = "null";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 24);
            this.label12.TabIndex = 58;
            this.label12.Text = "RSSI:";
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.buttonForward.Location = new System.Drawing.Point(266, 209);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(96, 35);
            this.buttonForward.TabIndex = 50;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.buttonBack.Location = new System.Drawing.Point(372, 209);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 35);
            this.buttonBack.TabIndex = 51;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.buttonLeft.Location = new System.Drawing.Point(266, 283);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(96, 35);
            this.buttonLeft.TabIndex = 52;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.buttonRight.Location = new System.Drawing.Point(372, 283);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(96, 35);
            this.buttonRight.TabIndex = 53;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.buttonStop.Location = new System.Drawing.Point(321, 245);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(96, 35);
            this.buttonStop.TabIndex = 54;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 390);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msgTime);
            this.Controls.Add(this.msgt);
            this.Controls.Add(this.SetTemp);
            this.Controls.Add(this.sysstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempThreshold);
            this.Controls.Add(this.TempTh);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Azure Sphere Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ambiTemp;
        private System.Windows.Forms.Label humid;
        private System.Windows.Forms.Label aY;
        private System.Windows.Forms.Label aZ;
        private System.Windows.Forms.Label TempTh;
        private System.Windows.Forms.TextBox TempThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sysstatus;
        private System.Windows.Forms.Button SetTemp;
        private System.Windows.Forms.Label msgt;
        private System.Windows.Forms.Label msgTime;
        private System.Windows.Forms.Label aX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gZ;
        private System.Windows.Forms.Label gY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label rssi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label light;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label altitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonStop;
    }
}

