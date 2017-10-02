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
        }

        private void Combat_Tracker_Load(object sender, EventArgs e)
        {

        }

        private void initiativeTimer_Tick(object sender, EventArgs e)
        {

        }


       
     
       
    }
}
