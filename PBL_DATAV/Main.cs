﻿using System;
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
            userControl11.Show();
            userControl11.BringToFront();
            chartwhole1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.White;
            chartwhole1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.White;
            chartwhole1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.White;
            chartwhole1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.White;
            chartwhole1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.White;
            chartwhole1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.White;
            chartwhole1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            BringToFront();
            guna2HtmlLabel2.Location = new Point(3, 34);
            panelTab1.Visible = true;
            HomePanel.Visible = false;
            chartwhole1.Series.Clear();
            guna2HtmlLabel1.Text = "Education Gap in Support";
            guna2HtmlLabel2.Location = new Point(guna2HtmlLabel2.Location.X, 39);
            guna2HtmlLabel2.Text = "Who favor to increase Gender Equality in Education";
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

        private void Button2_Click(object sender, EventArgs e)
        {
            panelTab1.Visible = true;
            HomePanel.Visible = false;
            chartwhole1.Series.Clear();
            guna2HtmlLabel1.Text = "Increased Healthcare Leadership";
            guna2HtmlLabel2.Location = new Point(guna2HtmlLabel2.Location.X, 39);
            guna2HtmlLabel2.Text = "Healthcare Leadership increased from Gender Equality";
            string[] countryName = new string[] { "Canada", "US", "Sweden", "France", "Spain", "UK", "Netherlands", "Germany", "Greece", "Italy", "Poland", "Hungary", "Russia", "Indonesia", "India", "Australia", "South Korea", "Japan", "Phillipines", "Tunisia", "Israel","Kenya","Nigeria", "South Africa", "Brazil","Argentina", "Mexico"};
            int[] increased = new int[] { 72, 68, 80, 74, 73, 73, 71, 70, 68, 29, 49, 77, 76, 75, 74, 59, 46, 66, 66, 68, 55, 51, 68, 66, 63};
            int[] no_change = new int[] { 22, 22, 15, 22, 20, 19, 20, 23, 25, 22, 36, 16, 7, 17, 17, 36, 46, 23, 12, 13, 18, 28, 21, 23, 26 };
            int[] decreased = new int[] { 5, 4, 4, 4, 5, 7, 5, 5, 3, 12, 11, 5, 10, 5, 6, 4, 7, 10, 20, 17, 24,19, 8, 8, 11 };
            
            for (int i = 0; i < 25; i++)
            {
                chartwhole1.Series.Add(countryName[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("increased", increased[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("no_change", no_change[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("decreased", decreased[i]);
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panelTab1.Visible = true;
            HomePanel.Visible = false;
            chartwhole1.Series.Clear();
            guna2HtmlLabel1.Text = "Women in Healthcare <br> Leadership";
            guna2HtmlLabel2.Location = new Point(guna2HtmlLabel2.Location.X, 65);
            guna2HtmlLabel2.Text = "Shows a percentage of Women in Healthcare leadership by year <br> 2015, 2017 and 2018";
            string[] companies = new string[] { "Board Members at Fortune 500 healthcare", "Executives at Fortune 500", "Hospital Executives", "Digital health VC Partners", "Digital health startup CEO's" };
            double[] year_2015 = new double[] { 21,20, 20.00, 36.40, 11.40,8.80 };
            double[] year_2017 = new double[] { 22.10, 22.60, 32.40,10.90,9.70};
            double[] year_2018 = new double[] {22.60, 21.90, 34.50, 12.20, 10.20};

            for (int i = 0; i < 5; i++)
            {
                chartwhole1.Series.Add(companies[i]);
                chartwhole1.Series[companies[i]].Points.AddXY("2015", year_2015[i]);
                chartwhole1.Series[companies[i]].Points.AddXY("2017", year_2017[i]);
                chartwhole1.Series[companies[i]].Points.AddXY("2018", year_2018[i]);
            }
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartwhole1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            BringToFront();
            guna2HtmlLabel1.Text = "Most Favor Increasing in <br>Gender Equality";
            guna2HtmlLabel2.Location = new Point(0, 68);
            guna2HtmlLabel2.Text = "(Explanations)";
            panelTab1.Visible = true;
            chartwhole1.Series.Clear();
            string[] countryName = new string[] { "Canada", "U.S", "Sweden", "France", "Spain", "UK", "Netherlands", "Germany", "Italy",
                "Poland", "Greece", "Hungary", "MEDIAN", "Russia", "India", "Australia", "South Korea", "Indonesia", "Japan", "Philippines",
                "Israel", "Tunisia", "Kenya", "Nigeria", "South Africa", "Brazil", "Argentina", "Mexicao" };
            int[] oppose = new int[] { 4, 4, 1, 3, 5, 4, 5, 4, 7, 10, 12, 19, 5, 11, 7, 3, 5, 7, 5, 7, 15, 29, 14, 17, 14, 12, 9, 9 };
            int[] favor = new int[] { 72, 72, 82, 74, 74, 72, 70, 67, 62, 57, 56, 29, 69, 40, 77, 76, 75, 72, 55, 42, 64, 44, 71, 61, 53, 63, 61, 61 };
            int[] noChange = new int[] { 22, 22, 15, 22, 19, 20, 23, 25, 21, 22, 24, 46, 22, 36, 7, 17, 17, 16, 34, 46, 12, 23, 13, 18, 28, 21, 23, 26};

            for (int i = 0; i < 28; i++)
            {
                chartwhole1.Series.Add(countryName[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("Oppose", oppose[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("Favor", favor[i]);
                chartwhole1.Series[countryName[i]].Points.AddXY("No Change", noChange[i]);

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panelTab1.Visible = false;
            userControl11.Visible = true;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
