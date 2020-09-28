using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBook.Model
{
    // ctrl + shift + v - clipboard ring
    // ctrl + m + o - collapse blocks into single line
    // shift + alt + arrow/mouseclick - multiple insert lines
    // alt + up/down - move 1 line of code up or down instead of copy paste
    // shift + F12 - find all references
    // end /home - jumps to last or first of current line
    public class Being : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int typeId;

        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Image { get; set; }

        private string looks;

        public string Looks
        {
            get { return looks; }
            set { looks = value; }
        }

        private string sound;

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public List<Attack> Attacks { get; set; }

        public List<Defense> Defenses { get; set; }

        public List<Strength> Strengths { get; set; }

        private int stamina;

        public int Stamina  // Is used when attacking, working, moving, (actions), using ability, casting spells
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public List<Weakness> Weaknesses { get; set; }

        private int hitpoints;

        public int Hitpoints
        {
            get { return hitpoints; }
            set { hitpoints = value; }
        }

        private int regeneration;

        public int Regeneration
        {
            get { return regeneration; }
            set { regeneration = value; }
        }

        private int willPower;

        public int WillPower
        {
            get { return willPower; }
            set { willPower = value; }
        }

        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        private int mana;

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        private int manaRegeneration;

        public int ManaRegeneration
        {
            get { return manaRegeneration; }
            set { manaRegeneration = value; }
        }

        public List<Ability> Abilities { get; set; }

        public List<MovementType> MovementTypes { get; set; }

        private Habitat habitat;

        public Habitat Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        private string organisation;

        public string Organisation
        {
            get { return organisation; }
            set { organisation = value; }
        }

        private string diet;

        public string Diet
        {
            get { return diet; }
            set { diet = value; }
        }

        private string alignment;

        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }

        private string personalityTypes;

        public string PersonalityTypes
        {
            get { return personalityTypes; }
            set { personalityTypes = value; }
        }

        private string interaction;

        public string Interaction
        {
            get { return interaction; }
            set { interaction = value; }
        }

        private string treasure;

        public string Treasure
        {
            get { return treasure; }
            set { treasure = value; }
        }







        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }




        //humanoids
        //charisma
        //dexterity
        //
    }
}
