using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBook.Model
{
    public class Strength : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string type; //Lift, carry, push, pull exertion-type/work-type

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int value;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
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
