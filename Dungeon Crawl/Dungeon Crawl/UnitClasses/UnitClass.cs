using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.UnitClasses
{
    public class UnitClass
    {
        //armor booleans
        private bool canEquipHeavy = false;
        private bool canEquipMedium = false;
        private bool canEquipLight = true;
        //weapon booleans
        private bool canEquipGreatSwords = false;
        private bool canEquipGuns = false;
        private bool canEquipStaves = false;
        private bool canEquipKnives = true;
        private bool canEquipSwords = false;
        //add boolean to determine if Special is beneficial
        private bool friendlySpecial = false;
        public bool FriendlySpecial
        {
            get { return friendlySpecial; }
            set { friendlySpecial = value; }
        }
        public bool HeavyArmor
        {
            get { return canEquipHeavy; }
            set { canEquipHeavy = value; }
        }
        public bool MediumArmor
        {
            get { return canEquipMedium; }
            set { canEquipMedium = value; }
        }
        public bool LightArmor
        {
            get { return canEquipLight; }
            set { canEquipLight = value; }
        }
        public bool CanEquipSwords
        {
            get
            {
                return canEquipSwords;
            }

            set
            {
                canEquipSwords = value;
            }
        }
        public bool CanEquipGreatSwords
        {
            get
            {
                return canEquipGreatSwords;
            }

            set
            {
                canEquipGreatSwords = value;
            }
        }
        public bool CanEquipGuns
        {
            get
            {
                return canEquipGuns;
            }

            set
            {
                canEquipGuns = value;
            }
        }
        public bool CanEquipStaves
        {
            get
            {
                return canEquipStaves;
            }

            set
            {
                canEquipStaves = value;
            }
        }
        public bool CanEquipKnives
        {
            get
            {
                return canEquipKnives;
            }

            set
            {
                canEquipKnives = value;
            }
        }
        public virtual void Special(MobileObject caster, MobileObject target)
        {
           
        }
    }
}
