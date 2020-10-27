using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBook.Model
{
    public class Ability : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// The ability's description for readers wanting 
        /// to know about the ability.
        /// </summary>
        private string description;

        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        /// <summary>
        /// The different category types it can be classified under:
        //!? Other or self
        // Movement - (can be other types than travel movement like precise movement or vibration)
        // Longevity - healing, self-healing, cloning, immortality, rejuvenation vs death, aging, decay, sacrifice
        // Other Enhancement - buff (attack, defense, intelligence, vision, energy or mana consumption
        // Stealth - sound mutability, smell mutability, vision mutability
        // Bodytransformation - camouflage, phasing, size manipulation, transformation  
        // Creation - create objects out of energy/magic/matter
        // Emission - light beam, elemental breath, elemental discharge, organic compound (bone, fang, claw, pike),
        // - liquids, vapors, life/mana/energy
        // psionic - telepathic, telekinetic, precognition,intuition, willpower, emotions, beliefs
        // Passive ability - intelligence, perception, other, aura        
        /// </summary>
        private string type; 

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// What kind of element or power type
        // air, fog, water, ice
        // fire, magma, earth, clay, sand, rock, minerals, metal  
        // plant, wood, harpiks, pollen, nutshell
        // electricity, lightning, energy, life, mana
        // light, darkness, shadows
        // space, time, gravity, telekinetic
        // poison, venom
        /// </summary>
        private string attribute;

        public string Attribute
        {
            get { return attribute; }
            set { attribute = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
