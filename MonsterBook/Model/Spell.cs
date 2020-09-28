using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBook.Model
{
    public class Spell : INotifyPropertyChanged
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


        private SpellType spellType;

        public SpellType SpellType //spelltype
        {
            get { return spellType; }
            set { spellType = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int manaCost;

        public int ManaCost
        {
            get { return manaCost; }
            set { this.manaCost = value; }
        }

        private int hitpointCost;

        public int HitpointCost
        {
            get { return hitpointCost; }
            set { hitpointCost = value; }
        }

        private int staminaCost;

        public int StaminaCost
        {
            get { return staminaCost; }
            set { staminaCost = value; }
        }

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
