using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Kronometre : Form
    {
        public Kronometre()
        {
            InitializeComponent();
        }
        public int time;
        Form1 fm = new Form1();

        private void Kronometre_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = time.ToString();
        }

      
     
   
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if(time==0)
            {
                timer1.Enabled = false;
                this.Hide();
                fm.txtTime.Text = "Süreniz Doldu";
                fm.Show();
            }
        }
    }
}
