using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOPFNsDemo1.Forms
{
    public partial class formDashboard : Form
    {
        
        public formDashboard()
        {
       
            InitializeComponent();
            dashboardUC1.BringToFront();
            labelTitle.Text = "Obavijesti";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "Obavijesti";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            donersUC1.BringToFront();
            labelTitle.Text = "Dodavanje goveda";
        }

        private void button3_Click(object sender, EventArgs e)
            
        {
            

        }
        private void button6_Click(object sender, EventArgs e)
        {

            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
