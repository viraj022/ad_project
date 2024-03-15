using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class FrmFrirstForm : Form
    {

        int i = 0;
        public FrmFrirstForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //confirm if the user wants to exit the application
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }


        private void pictureBoxUser_MouseEnter(object sender, EventArgs e)
        {
            //set the image to the pictureBoxUser
        

            pictureBoxUser.Image = Properties.Resources.icons8_user_male;
         
        
        }

        private void pictureBoxUser_MouseLeave(object sender, EventArgs e)
        {
            //set null to the pictureBoxUser
            pictureBoxUser.Image = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBar1.Value = i;

            if (i < 10)
            {
              timer1.Interval = 500;
            }
            if (i < 50)
            {
                timer1.Interval = 200;
            }
            if (i < 90)
            {
                timer1.Interval = 800;
            }
            if (i < 100)
            {
                timer1.Interval = 500;
            }
            if (i == 100)
            {
                timer1.Stop();
                new FrmCars().Show();
                this.Hide();
            }

            lblStatus.Text = "Loading " + i + "%";
        }
    }
}
