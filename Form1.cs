using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hero_Maker
{
    public partial class Form1 : Form
    {
        private List<SuperHero> superHeroes = new List<SuperHero>();
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // taking speed value from the hScrollBall
            int speed = hScrollBarSpeed.Value;

            // taking stamina value from the hScrollBar
            int stamina = hScrollBarStamina.Value;

            // taking strength value from the hScrollBar
            int strength = hScrollBarStrength.Value;

            //adding speed, stamina, and strength values
            int total = speed + stamina + strength;
            if (total > 100) 
            {
                hScrollBarStamina.Value = (total - hScrollBarSpeed.Value) / 3;
                hScrollBarStrength.Value = (total - hScrollBarSpeed.Value) / 3;

                // display value of Stamina on the label
                numStamina.Text = ((total - hScrollBarSpeed.Value) / 3).ToString();

                // display value of Stamina on the label
                numStrength.Text = ((total - hScrollBarSpeed.Value) / 3).ToString();
            }
            else
            {
                // display value of Speed on the label
                numSpeed.Text = hScrollBarSpeed.Value.ToString();
            }
        }

        private void hScrollBarStamina_Scroll(object sender, ScrollEventArgs e)
        {
            // taking speed value from the hScrollBar
            int speed = hScrollBarSpeed.Value;

            // taking stamina value from the hScrollBar
            int stamina = hScrollBarStamina.Value;

            // taking strength value from the hScrollBar
            int strength = hScrollBarStrength.Value;

            //adding speed, stamina, and strength values
            int total = speed + stamina + strength;
            if (total > 100) 
            {
                hScrollBarSpeed.Value = (total - hScrollBarStamina.Value) / 3;
                hScrollBarStrength.Value = (total - hScrollBarStamina.Value) / 3;

                //display value of speed on the label 
                numSpeed.Text = ((total - hScrollBarStamina.Value) / 3).ToString();

                //display value of Strength on the label 
                numStrength.Text = ((total - hScrollBarStamina.Value) / 3).ToString();
            }
            else
            {
                // display value of Stamina on the label
                numStamina.Text = hScrollBarStamina.Value.ToString();
            }
        }

        private void hScrollBarStrength_Scroll(object sender, ScrollEventArgs e)
        {
            // taking speed value from the hScrollBar
            int speed = hScrollBarSpeed.Value;

            // taking stamina value from the hScrollBar
            int stamina = hScrollBarStamina.Value;

            // taking strength value from the hScrollBar
            int strength = hScrollBarStrength.Value;

            //adding speed, stamina, and strength values
            int total = speed + stamina + strength;
            if(total > 100)
            {
                hScrollBarSpeed.Value = (total - hScrollBarStrength.Value) / 3;
                hScrollBarStamina.Value = (total - hScrollBarStrength.Value) / 3;

                // display value of speed on the label 
                numSpeed.Text = ((total - hScrollBarStrength.Value) / 3).ToString();

                // display value of Strength on the label
                numStamina.Text = ((total - hScrollBarStrength.Value) /3).ToString();
            }
            else
            {
                // display value of Strength on the label
                numStrength.Text = hScrollBarStrength.Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the input values from the form
            string name = txtName.Text;
            DateTime birthday = dtBirthday.Value;
            ArrayList locations = new ArrayList(lstLocations.SelectedItems);
            int speed = hScrollBarSpeed.Value;
            int stamina = hScrollBarStamina.Value;
            int strength = hScrollBarStrength.Value;
            int yearsExperience = (int)numericUpDown1.Value;
            ArrayList skills = new ArrayList();

            // Create a new SuperHero instance and add it to the list
            SuperHero superHero = new SuperHero(name, birthday, locations, speed, stamina, strength, yearsExperience, skills);
            superHeroes.Add(superHero);

            // Hide Form1 and show form2
            Form2 f2 = new Hero_Maker.Form2();
            this.Hide();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Object of ColorDialog
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog(); // this will show the dialog
            pictureBox1.BackColor = cd.Color; // display color in picturebox
            string colorName = cd.Color.ToString();
            labelColorName.Text = colorName; // display color name
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // display trackbar value on the label
            labelTrackBar.Text = trackBar1.Value.ToString();
        }
    }
}
