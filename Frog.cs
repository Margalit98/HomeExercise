using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    public class Frog : Animal
    {
        protected override bool carnivorous => false;

        protected override bool mammals => false;

        public override void animalSound()
        {
            Console.WriteLine("The sound of frog is quack");
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
            Console.WriteLine("When the frog afrad, she it will \"plop into the water\"");
        }

        public override void moodHappy()
        {
            Console.WriteLine("When the frog happy, she it will \"quack quack quack\" on the shore");
        }
    }
}
