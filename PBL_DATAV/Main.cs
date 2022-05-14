using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_DATAV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void CloseApp()
        {
            for (int i = Application.OpenForms.Count - 1; i != 1; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelTab1.Visible = true;
            chartwhole1.Series.Clear();
            guna2HtmlLabel1.Text = "Education Gap in Support";
            string[] countryName = new string[] { "Argentina", "Mexico", "Philippines", "Greece", "Italy", "Japan", "Israel", "Brazil", "Poland", "Spain", "France", "Germany", "South Africa", "India", "Kenya", "Hungary", "Canada", "Netherlands", "Sweden", "UK", "US" };
            int[] lessEdu = new int[] { 58, 52, 31, 51, 60, 49, 58, 57, 54, 71, 69, 64, 48, 74, 67, 26, 68, 67, 80, 71, 68 };
            int[] moreEdu = new int[] { 81, 74, 49, 67, 74, 63, 71, 70, 67, 82, 80, 75, 59, 84, 77, 45, 76, 75, 86, 77, 74 };
            
            for (int i = 0; i < 21; i++)
            {
                chartwhole1.Series.Add(countryName[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("More Education", moreEdu[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("Less Education", lessEdu[i]);

            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
