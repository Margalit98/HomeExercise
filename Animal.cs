using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeExercise
{
    public abstract class Animal
    {
        protected abstract bool carnivorous { get; }
        protected abstract bool mammals { get; }        
        public abstract void animalSound();
        public abstract bool isCarnivorous();
        public abstract bool isMammals();
        public abstract void moodHappy();
        public abstract void moodAfrad();

    }
}
