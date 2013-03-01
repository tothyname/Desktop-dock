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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
           
        {
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }




    }
}
