using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Maker
{
    public partial class Form2 : Form
    {
        string[,] Heroes = 
        {
             {"Batman", "Batman has these powers: Extreme Lucky, Super Strength. He has offices in: Tokyo. Preferred method of transport: Batmobile. Propensity to Dark Side: 5. Strength: 25%, Speed 25%, Stamina 50%."},
             {"Superman", "Superman has these powers: Fly, Super Strength, xRay Vision, Absorb Energy. He has offices in: New York. Preferred method of transport: Landspeeder. Propensity to Dark Side: 3. Strength: 100%, Speed 100%, Stamina 100%."},
             {"Wonder Woman", "Wonder Woman has these powers: Fly, Super Strength. She has offices in: Rome. Propensity to Dark Side: 4. Strength: 70%, Speed 65%, Stamina 80%."},
             {"The Black Widow", "The Black Widow has these powers: Super Lucky, Force Field. She has offices in: Moscow. Preferred method of transport: Jetpack. Propensity to Dark Side: 5. Strength: 20%, Speed 15%, Stamina 40%."},
             {"Green Lantern", "Green Lantern has these powers: Super Strength, Fly, Absorb Energy. He has offices in: London. Preferred method of transport: Teleport. Propensity to Dark Side: 5. Strength: 60%, Speed 50%, Stamina 65%."},
             {"Mr. Incredible", "Mr. Incredible has these powers: Super Strength, Force Field. He has offices in: Paris and Sydney. Preferred method of transport: Jetpack. Propensity to Dark Side: 7. Strength: 100%, Speed 30%, Stamina 100%."},
        };

        public Form2()
        {
            InitializeComponent();

            // Populate the ListBox control with superhero names
            for (int i = 0; i < Heroes.GetLength(0); i++)
            {
                listBox1.Items.Add(Heroes[i, 0]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            // Display the summary of the selected superhero in the TextBox control
            textBox1.Text = Heroes[index, 1];
        }
    }
}
