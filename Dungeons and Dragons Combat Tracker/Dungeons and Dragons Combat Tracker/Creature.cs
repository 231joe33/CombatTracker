using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_Combat_Tracker
{
    class Creature
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        string race;
        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                race = value;
            }
        }

        string profession;
        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                profession = value;
            }
        }

        int health;
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        int initiative;
        public int Initiative
        {
            get
            {
                return initiative;
            }
            set
            {
                initiative = value;
            }
        }

        int passivePerception;
        public int PassivePerception
        {
            get
            {
                return passivePerception;
            }
            set
            {
                passivePerception = value;
            }
        }

        bool advantageOrDisAdvantage;
        public bool AdvantageOrDisadvantage
        {
            get
            {
                return advantageOrDisAdvantage;
            }
            set
            {
                advantageOrDisAdvantage = value;
            }
        }

        Action action;
        public Action Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }

        bool reactionUsed;
        public bool ReactionUsed
        {
            get
            {
                return reactionUsed;
            }
            set
            {
                reactionUsed = value;
            }
        }

        /*Do Buffs and Debuffs (Search for all possible buffs and debuffs that can be given to a creature 
         * (this will mostly be through spells and/or abilities from races and/or classes*/

        int movementSpeed;
        public int MovementSpeed
        {
            get
            {
                return movementSpeed;
            }
            set
            {
                movementSpeed = value;
            }
        }
    }
}
