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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 12);
            label2.Font = new Font("Arial", 9);
            label3.Font = new Font("Arial", 12);
            label4.Font = new Font("Arial", 9);
            label5.Font = new Font("Arial", 12);
            label6.Font = new Font("Arial", 9);
            label4.Text = "Gender Equality is important because Equality" + "\n" + "by itself is already important. Apart from people" + "\n" + "with disabilities, the aged and the early youth," + "\n" + "we should all be treated equally, with good things" + "\n" + "like job position offerings, salary and rights, as" + "\n" + "well as with bad things like punishments," + "\n" + "expectations and limitations.";
            label6.Text = "Gender equality improves the safety and health of our" + "\n" + "communities. Societies that are unequal are less" + "\n" + "cohesive. They are more likely to engage in antisocial" + "\n" + "behavior and violence. More connected countries have" + "\n" + "more gender equality. Their citizens are healthier" + "\n" + "and more content.";
            //Gender Equality is important because Equality by itself is already important. Apart from people with disabilities, the aged and the early youth, we should all be treated equally, with good things like job position offerings, salary and rights, as well as with bad things like punishments, expectations and limitations.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
