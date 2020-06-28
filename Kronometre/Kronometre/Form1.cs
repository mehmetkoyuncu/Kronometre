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

   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


  
    

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int timerr = 0;

                timerr = Convert.ToInt32(txtTime.Text);

                Kronometre krn = new Kronometre();
                krn.time = timerr;
                this.Hide();
                krn.ShowDialog();
            }
            catch
            {
                MessageBox.Show("HATA !!");
            }
           
        }
    }
}
