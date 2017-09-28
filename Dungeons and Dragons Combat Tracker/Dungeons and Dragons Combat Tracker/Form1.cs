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
    public partial class Form1 : Form
    {
        AddingCreature form;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            form = new AddingCreature();
            form.ShowDialog();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Combat_Tracker gameForm = new Combat_Tracker(form.Character);
            gameForm.ShowDialog();

        }
    }
}
