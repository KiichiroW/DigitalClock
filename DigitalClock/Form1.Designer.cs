namespace DigitalClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHourOne = new System.Windows.Forms.Label();
            this.labelHourTwo = new System.Windows.Forms.Label();
            this.labelMinuteTwo = new System.Windows.Forms.Label();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundGif = new System.Windows.Forms.PictureBox();
            this.labelMinuteOne = new System.Windows.Forms.Label();
            this.btnChangeBg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGif)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHourOne
            // 
            this.labelHourOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHourOne.BackColor = System.Drawing.Color.Transparent;
            this.labelHourOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHourOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHourOne.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourOne.ForeColor = System.Drawing.Color.White;
            this.labelHourOne.Location = new System.Drawing.Point(40, 80);
            this.labelHourOne.Name = "labelHourOne";
            this.labelHourOne.Size = new System.Drawing.Size(100, 150);
            this.labelHourOne.TabIndex = 1;
            this.labelHourOne.Text = "0";
            this.labelHourOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHourOne.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelHourTwo
            // 
            this.labelHourTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHourTwo.BackColor = System.Drawing.Color.Transparent;
            this.labelHourTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHourTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHourTwo.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourTwo.ForeColor = System.Drawing.Color.White;
            this.labelHourTwo.Location = new System.Drawing.Point(140, 80);
            this.labelHourTwo.Name = "labelHourTwo";
            this.labelHourTwo.Size = new System.Drawing.Size(100, 150);
            this.labelHourTwo.TabIndex = 2;
            this.labelHourTwo.Text = "8";
            this.labelHourTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinuteTwo
            // 
            this.labelMinuteTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinuteTwo.BackColor = System.Drawing.Color.Transparent;
            this.labelMinuteTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMinuteTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMinuteTwo.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinuteTwo.ForeColor = System.Drawing.Color.White;
            this.labelMinuteTwo.Location = new System.Drawing.Point(350, 80);
            this.labelMinuteTwo.Name = "labelMinuteTwo";
            this.labelMinuteTwo.Size = new System.Drawing.Size(100, 150);
            this.labelMinuteTwo.TabIndex = 4;
            this.labelMinuteTwo.Text = "2";
            this.labelMinuteTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 1000;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.CausesValidation = false;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(450, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // backgroundGif
            // 
            this.backgroundGif.BackColor = System.Drawing.Color.White;
            this.backgroundGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backgroundGif.Image = ((System.Drawing.Image)(resources.GetObject("backgroundGif.Image")));
            this.backgroundGif.Location = new System.Drawing.Point(0, 0);
            this.backgroundGif.Name = "backgroundGif";
            this.backgroundGif.Size = new System.Drawing.Size(480, 300);
            this.backgroundGif.TabIndex = 7;
            this.backgroundGif.TabStop = false;
            this.backgroundGif.Click += new System.EventHandler(this.pictureBox1_Click);
            this.backgroundGif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            this.backgroundGif.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseMove);
            this.backgroundGif.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseUp);
            // 
            // labelMinuteOne
            // 
            this.labelMinuteOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinuteOne.BackColor = System.Drawing.Color.Transparent;
            this.labelMinuteOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMinuteOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMinuteOne.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinuteOne.ForeColor = System.Drawing.Color.White;
            this.labelMinuteOne.Location = new System.Drawing.Point(250, 80);
            this.labelMinuteOne.Name = "labelMinuteOne";
            this.labelMinuteOne.Size = new System.Drawing.Size(100, 150);
            this.labelMinuteOne.TabIndex = 3;
            this.labelMinuteOne.Text = "4";
            this.labelMinuteOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangeBg
            // 
            this.btnChangeBg.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeBg.BackgroundImage")));
            this.btnChangeBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeBg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeBg.Location = new System.Drawing.Point(420, 0);
            this.btnChangeBg.Name = "btnChangeBg";
            this.btnChangeBg.Size = new System.Drawing.Size(30, 30);
            this.btnChangeBg.TabIndex = 8;
            this.btnChangeBg.UseVisualStyleBackColor = false;
            this.btnChangeBg.Click += new System.EventHandler(this.btnChangeBg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.btnChangeBg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelMinuteTwo);
            this.Controls.Add(this.labelMinuteOne);
            this.Controls.Add(this.labelHourTwo);
            this.Controls.Add(this.labelHourOne);
            this.Controls.Add(this.backgroundGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Clock";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelHourOne;
        private System.Windows.Forms.Label labelHourTwo;
        private System.Windows.Forms.Label labelMinuteTwo;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox backgroundGif;
        private System.Windows.Forms.Label labelMinuteOne;
        private System.Windows.Forms.Button btnChangeBg;
    }
}

