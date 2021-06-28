using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetTime();
            labelHourOne.Parent = backgroundGif;
            labelHourTwo.Parent = backgroundGif;
            labelMinuteOne.Parent = backgroundGif;
            labelMinuteTwo.Parent = backgroundGif;
            btnChangeBg.Parent = backgroundGif;
            btnExit.Parent = backgroundGif;

            if (Properties.Settings.Default.BackgroundImage != "")
            {
                backgroundGif.Image = new Bitmap(Properties.Settings.Default.BackgroundImage);
            }
            this.BackgroundImage = backgroundGif.Image;
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            labelHourOne.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void SetTime()
        {
            string currentTime = DateTime.Now.ToString("HH:mm");

            labelHourOne.Text = currentTime[0].ToString();
            labelHourTwo.Text = currentTime[1].ToString();
            labelMinuteOne.Text = currentTime[3].ToString();
            labelMinuteTwo.Text = currentTime[4].ToString();
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            SetTime();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Clock_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Clock_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Clock_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeBg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                backgroundGif.Image = new Bitmap(open.FileName);
                Properties.Settings.Default.BackgroundImage = open.FileName;
                this.BackgroundImage = backgroundGif.Image;
            }

        }
    }
}
