using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //needed for messagebox

namespace Tutorial10_2
{
    class Dog : Animal
    {
        //field
        private string _name;
            //constructor
            public Dog(string name)
            :base("Dog")
            {
            _name = name;
        }

        //name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //makesound method
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }

    }
}
