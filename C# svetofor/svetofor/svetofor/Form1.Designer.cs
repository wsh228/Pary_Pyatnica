namespace svetofor
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stop = new System.Windows.Forms.Button();
            this.startNight = new System.Windows.Forms.Button();
            this.startDay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(111, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 75);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(111, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 75);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(111, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 75);
            this.panel3.TabIndex = 3;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(247, 156);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(115, 23);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // startNight
            // 
            this.startNight.Location = new System.Drawing.Point(247, 104);
            this.startNight.Name = "startNight";
            this.startNight.Size = new System.Drawing.Size(115, 23);
            this.startNight.TabIndex = 5;
            this.startNight.Text = "Night";
            this.startNight.UseVisualStyleBackColor = true;
            this.startNight.Click += new System.EventHandler(this.startNight_Click_1);
            // 
            // startDay
            // 
            this.startDay.Location = new System.Drawing.Point(247, 75);
            this.startDay.Name = "startDay";
            this.startDay.Size = new System.Drawing.Size(115, 23);
            this.startDay.TabIndex = 6;
            this.startDay.Text = "Day";
            this.startDay.UseVisualStyleBackColor = true;
            this.startDay.Click += new System.EventHandler(this.startDay_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(265, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "POZNIAKOV NIKITA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.picture);
            this.panel4.Location = new System.Drawing.Point(192, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 75);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(75, 75);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.picture1);
            this.panel5.Location = new System.Drawing.Point(31, 237);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 75);
            this.panel5.TabIndex = 9;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(0, 0);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(75, 75);
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(135, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDay);
            this.Controls.Add(this.startNight);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button startNight;
        private System.Windows.Forms.Button startDay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label label2;
    }
}

