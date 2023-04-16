using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Maker
{
    class SuperHeroList
    {
        public List<SuperHero> listOfHeroes { get; set; }

        public SuperHeroList() 
        {
            listOfHeroes = new List<SuperHero>();
            heroList.listOfHeroes.Add(superman);
        }

        SuperHeroList heroList = new SuperHeroList();

        // Create a new SuperHero instance
        SuperHero superman = new SuperHero("Superman", new DateTime(1938, 4, 18), new ArrayList(), 100, 100, 100, 10, new ArrayList());
    }
}
