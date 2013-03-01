using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start("http://www.google.com");
           


           // System.Diagnostics.Process.Start("http://movies.netflix.com/Queue?lnkctr=mhbqueInstant&qtype=ED");
        }

   
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox10.Visible = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://movies.netflix.com/Queue?lnkctr=mhbqueInstant&qtype=ED");
            pictureBox10.Visible = false;
        }

     
        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox12.Visible = true;
        }
        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox12.Visible = false;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox11.Visible = true;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com/");
            pictureBox11.Visible = false;
        }

        private void pictureBox6_MouseDown_1(object sender, MouseEventArgs e)
        {
            pictureBox12.Visible = true;
        }

        private void pictureBox6_MouseUp_1(object sender, MouseEventArgs e)
        {
         System.Diagnostics.Process.Start("C:\\Users\\shwa\\AppData\\Roaming\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar\\Spotify.lnk");
            //System.Diagnostics.Process.Start("http://movies.netflix.com/Queue?lnkctr=mhbqueInstant&qtype=ED");
            pictureBox12.Visible = false;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox13.Visible = true;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/");
            pictureBox13.Visible = false;
        }

        private void pictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox14_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;
            System.Diagnostics.Process.Start("http://www.youtube.com/");
            
        }

        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox15_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\shwa\\Desktop\\BOA_01.exe.lnk");
            pictureBox2.Visible = false;
        }

        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible = true;
        }

        private void pictureBox16_MouseUp(object sender, MouseEventArgs e)
        {
           System.Diagnostics.Process.Start("C:\\Program Files (x86)\\KeePass Password Safe 2\\KeePass.exe");
            //System.Diagnostics.Process.Start("http://www.youtube.com/");
            pictureBox8.Visible = false;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox17.Visible = true;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.amazon.com/");
            pictureBox17.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox14.Visible = true;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/");
            pictureBox14.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //   label2.Text = textBox1.Text;
        }

       
        

        private void pictureBox18_Click(object sender, EventArgs e)
        {
           
        }
        private void pictureBox18_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox18.Visible = false;
            pictureBox19.Visible = true;
        }

        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox19.Visible = false;
            pictureBox20.Visible = true;
        }

        private void pictureBox20_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox20.Visible = false;
            pictureBox21.Visible = true;
        }

        private void pictureBox21_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox21.Visible = false;
            pictureBox18.Visible = true;
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pictureBox18.Visible == true)
                {
                    System.Diagnostics.Process.Start("https://www.google.com/search?q=" + textBox1.Text);
                }
                else if
                    (pictureBox19.Visible == true)
                {
                    System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/" + textBox1.Text);
                }
               else if
                    (pictureBox20.Visible == true)
                {
                    System.Diagnostics.Process.Start("http://www.amazon.com/s/180-5895646-6230920?ie=UTF8&field-keywords=" + textBox1.Text);
                }
                else if
                    (pictureBox21.Visible == true)
                {
                    System.Diagnostics.Process.Start("http://www.imdb.com/find?q=" + textBox1.Text);
                }
       

              



                    // Enter (return) was pressed.
           
            }
        }

        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
         pictureBox23.Visible = true;
        }

        private void pictureBox22_MouseUp(object sender, MouseEventArgs e)
        {
           
            Application.Exit();
        }

        private void pictureBox25_MouseUp(object sender, MouseEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }



    }
}
