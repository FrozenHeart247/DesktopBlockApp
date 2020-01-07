using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotVirus
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            EscapeButton.Visible = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;

        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBox1_MouseEnter(object sender, EventArgs e)
        {/*
            PictureBox pictureBox2 = new PictureBox();
            Point location = picBox1.Location;
            int x = location.X;
            location = picBox1.Location;
            int y = location.Y + picBox1.Height + 10;
            Point point1 = new Point(x, y);
            picBox1.Location = point1;
            this.Controls.Add((Control)picBox1);
            Point point2 = new Point(this.rand.Next(this.Size.Width - 100), this.rand.Next(this.Size.Height - 100));
            picBox1.Location = point2;
            this.Controls.Add((Control)pictureBox2);
            */
            /*
               PictureBox pictureBox1 = (PictureBox)sender;
               PictureBox pictureBox2 = new PictureBox();
               pictureBox2.BackColor = (sender as PictureBox).BackColor;
               pictureBox2.Image = (sender as PictureBox).Image;
               pictureBox2.SizeMode = (sender as PictureBox).SizeMode;
               pictureBox2.Width = pictureBox1.Width;
               pictureBox2.Height = pictureBox1.Height;
               PictureBox pictureBox3 = pictureBox2;
               Point location = pictureBox1.Location;
               int x = location.X;
               location = pictureBox1.Location;
               int y = location.Y + pictureBox1.Height + 10;
               Point point1 = new Point(x, y);
               pictureBox3.Location = point1;
               pictureBox2.MouseEnter += new EventHandler(this.picBox1_MouseEnter);
               this.Controls.Add((Control)pictureBox2);
               Point point2 = new Point(this.rand.Next(this.Size.Width - 100), this.rand.Next(this.Size.Height - 100));
               (sender as PictureBox).Location = point2;
           }*/
            
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.BackColor = (sender as PictureBox).BackColor;
            pictureBox2.Image = (sender as PictureBox).Image;
            pictureBox2.SizeMode = (sender as PictureBox).SizeMode;
            pictureBox2.Width = picBox1.Width;
            pictureBox2.Height = picBox1.Height;
            PictureBox pictureBox3 = pictureBox2;
            Point location = picBox1.Location;
            int x = location.X;
            location = picBox1.Location;
            int y = location.Y + picBox1.Height + 10;
            Point point1 = new Point(x, y);
            pictureBox3.Location = point1;
            pictureBox2.MouseEnter += new EventHandler(picBox1_MouseEnter);
            this.Controls.Add((Control)pictureBox2);
            Point point2 = new Point(rand.Next(Size.Width - 100),rand.Next(Size.Height - 100));
            pictureBox3.Location = point2;
        }

        protected override void OnKeyDown(KeyEventArgs e)
    {
            //e.SuppressKeyPress = e.Alt && e.KeyCode == Keys.Tab; //не работает хз
            //e.SuppressKeyPress = e.Alt && e.KeyCode == Keys.F4; 
            base.OnKeyDown(e);
        }

        /* protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.Tab))
            {
                MessageBox.Show("Alt + Tab catched!");
                return true;  // The key is manually processed
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        
        /*
        if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
        {

            MessageBox.Show("Alt catched!");
            return true;
        }
        else
            return base.ProcessCmdKey(ref msg, keyData);
          }  */
    

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
               if (e.KeyData != Keys.Return)
                return;
            MessageBox.Show("OK?", "ВИРУС");
                        
          

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
                       
        }
    }
}
