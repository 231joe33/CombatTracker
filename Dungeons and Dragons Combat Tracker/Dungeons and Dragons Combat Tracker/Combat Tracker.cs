using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons_and_Dragons_Combat_Tracker
{
    public partial class Combat_Tracker : Form
    {
        List<Creature> characters;
        public Combat_Tracker(List<Creature> Characters)
        {
            InitializeComponent();
            characters = Characters;
            initiativeTimer.Enabled = true;
            initiativeTextBox.Text = "0";
            bonusInitTextBox.Text = "0";
            totalInitTextBox.Text = "0";
        }

        private void Combat_Tracker_Load(object sender, EventArgs e)
        {

        }

        private void initiativeTimer_Tick(object sender, EventArgs e)
        {
            if (initiativeTextBox.Text == "")
            {
                initiativeTextBox.Text = "0";
            }
            else if (bonusInitTextBox.Text == "")
            {
                bonusInitTextBox.Text = "0";
            }
            else if (totalInitTextBox.Text == "")
            {
                totalInitTextBox.Text = "0";
            }
            else
            {
                totalInitTextBox.Text = (int.Parse(initiativeTextBox.Text) + int.Parse(bonusInitTextBox.Text)).ToString();
            }
        }


        //WIP
        int count = 0;
        private void nextButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (count < characters.Count)
            {
                nameLabel.Text = characters[count].Name;
                characters[count].Initiative = int.Parse(initiativeTextBox.Text);
                characters[count].BonusInitiative = int.Parse(bonusInitTextBox.Text);
                characters[count].TotalInitiative = int.Parse(totalInitTextBox.Text);
                initiativeTextBox.Clear();
                bonusInitTextBox.Clear();
                totalInitTextBox.Clear();
                count++;
            }
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            count--;
            if (count < 0)
            {
                count = 0;
            }
            nameLabel.Text = characters[count].Name;
            initiativeTextBox.Text = characters[count].Initiative.ToString();
            bonusInitTextBox.Text = characters[count].BonusInitiative.ToString();
            totalInitTextBox.Text = characters[count].TotalInitiative.ToString();
        }
    }
}
