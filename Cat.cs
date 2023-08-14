using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    public class Cat : Animal
    {
        protected override bool carnivorous => true;

        protected override bool mammals => true;

        public override void animalSound()
        {
            Console.WriteLine("The sound of cat is meow");
        }

        public override bool isCarnivorous()
        {
            return carnivorous;
        }

        public override bool isMammals()
        {
            return mammals;
        }

        public override void moodAfrad()
        {
            Console.WriteLine("When the cat afrad, he make a \"purr, purr\" sound");
        }

        public override void moodHappy()
        {
            Console.WriteLine("When the cat happy he make a \"hiss\" sound");
        }
    }
}
