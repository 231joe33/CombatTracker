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
    public partial class AddingCreature : Form
    {
        List<Creature> character;
        public AddingCreature()
        {
            InitializeComponent();
            character = new List<Creature>();
        }

        private void diceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void AddingCreature_Load(object sender, EventArgs e)
        {

        }

        private void healthOption1_CheckedChanged(object sender, EventArgs e)
        {
            fixedHealthLabel.Visible = true;
            fixedHealthTextBox.Visible = true;
            diceAmountLabel.Visible = false;
            diceAmountTextBox.Visible = false;
            diceTypeComboBox.Visible = false;
            diceTypeLabel.Visible = false;
            bonusHealthLabel.Visible = false;
            bonusHPTextBox.Visible = false;
            warningforBonusHPLabel.Visible = false;
        }

        private void healthOption2_CheckedChanged(object sender, EventArgs e)
        {
            fixedHealthLabel.Visible = false;
            fixedHealthTextBox.Visible = false;
            diceAmountLabel.Visible = true;
            diceAmountTextBox.Visible = true;
            diceTypeComboBox.Visible = true;
            diceTypeLabel.Visible = true;
            bonusHealthLabel.Visible = true;
            bonusHPTextBox.Visible = true;
            warningforBonusHPLabel.Visible = true;
        }

        int healthGenerator(int diceAmount, string diceType, int bonusHealth)
        {
            Random rand = new Random();
            int health = 0;
            if(diceType == "D4")
            {
                for(int i = 0; i < diceAmount; i++)
                {
                    health += rand.Next(1, 5);
                }
            }
            else if(diceType == "D6")
            {
                for(int i = 0; i < diceAmount; i++)
                {
                    health += rand.Next(1, 7);
                }
            }
            else if(diceType == "D8")
            {
                for(int i = 0; i < diceAmount; i++)
                {
                    health += rand.Next(1, 9);
                }
            }
            else if(diceType == "D10")
            {
                for(int i = 0; i < diceAmount; i++)
                {
                    health += rand.Next(1, 11);
                }
            }
            else if(diceType == "D12")
            {
                for(int i = 0; i < diceAmount; i++)
                {
                    health += rand.Next(1, 13);
                }
            }
            else if(diceType == "D20")
            {
                for(int i = 0; i < diceAmount; i++)
                {
                    health += rand.Next(1, 21);
                }
            }
            health += bonusHealth;
            return health;
        }



        //Create switches for Race benefits and Class benefits.
        private void addButton_Click(object sender, EventArgs e)
        {
            if(noClassCheckBox.Checked == true)
            {
                classTextBox.Text = "None";
            }

            if(healthOption1.Checked == true)
            {
                character.Add(new Creature(int.Parse(fixedHealthTextBox.Text), nameTextBox.Text, raceTextBox.Text, classTextBox.Text, int.Parse(levelTextBox.Text)));
            }
            else if(healthOption2.Checked == true)
            {
                character.Add(new Creature(healthGenerator(int.Parse(diceAmountTextBox.Text), diceTypeComboBox.SelectedItem.ToString(), int.Parse(bonusHPTextBox.Text)), nameTextBox.Text, raceTextBox.Text, classTextBox.Text, int.Parse(levelTextBox.Text)));
            }

            nameTextBox.Clear();
            raceTextBox.Clear();
            classTextBox.Clear();
            levelTextBox.Clear();
            fixedHealthTextBox.Clear();
            diceAmountTextBox.Clear();
            bonusHPTextBox.Clear();
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
