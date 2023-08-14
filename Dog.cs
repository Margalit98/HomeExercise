using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    public class Dog : Animal
    {

        protected override bool carnivorous => true;

        protected override bool mammals => true;

        public override void animalSound()
        {
            Console.WriteLine("The sound of dog is aowaow");
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
            Console.WriteLine("When the dog afrad, he is make a \"whooping\" sound");
        }

        public override void moodHappy()
        {
            Console.WriteLine("When the dog feel comfortable being touched, he is bark loudly");
        }
    }
}
