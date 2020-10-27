using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBook.Model
{
    public class MovementType : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //Land - Stationary, crawl, slither, walk, run
        //Water - swim, dive/thrust 
        //Air - hover/levitate, fly, 
        //Space - teleport, displace/replace (should maybe be considered an ability rather than basic movement or maybe be placed at both places)
        private string type;

        public string Type 
        {
            get { return type; }
            set { type = value; }
        }

        private int travelSpeed;

        public int TravelSpeed
        {
            get { return travelSpeed; }
            set { travelSpeed = value; }
        }

        private int travelStamina;

        public int TravelStamina
        {
            get { return travelStamina; }
            set { travelStamina = value; }
        }

        private int sprintSpeed;

        public int SprintSpeed
        {
            get { return sprintSpeed; }
            set { sprintSpeed = value; }
        }

        private int sprintStamina;

        public int SprintStamina
        {
            get { return sprintStamina; }
            set { sprintStamina = value; }
        }

        private string attribute;

        public string Attribute //elemental, telekinetic, ability, physical, 
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
