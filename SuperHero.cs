using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hero_Maker
{
    class SuperHero
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public ArrayList Locations { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int YearsExperience { get; set; }
        public ArrayList Skills { get; set; }

        public SuperHero(string name, DateTime birthday, ArrayList locations, int speed, int stamina, int strength, int yearsExperience, ArrayList skills)
        {
            Name = name;
            Birthday = birthday;
            Locations = locations;
            Speed = speed;
            Stamina = stamina;
            Strength = strength;
            Skills = skills;
        }   
    }
}
