// See https://aka.ms/new-console-template for more information
using HomeExercise;

Dog dog = new Dog();
Cat cat = new Cat();
Frog frog = new Frog();

Console.WriteLine("-------Dog-------");
dog.animalSound();
dog.moodAfrad();
dog.moodHappy();
Console.WriteLine("Is the dog a carnivore or a mammal? \n" +
                  "Carnivore: " + dog.isCarnivorous() +
                  "\nMammal: " + dog.isMammals());

Console.WriteLine("-------Cat-------");
cat.animalSound();
cat.moodAfrad();
cat.moodHappy();
Console.WriteLine("Is the cat a carnivore or a mammal? \n" +
                  "Carnivore: " + cat.isCarnivorous() +
                  "\nMammal: " + cat.isMammals());

Console.WriteLine("-------Frog-------");
frog.animalSound();
frog.moodAfrad();
frog.moodHappy();
Console.WriteLine("Is the frog a carnivore or a mammal? \n" +
                  "Carnivore: " + frog.isCarnivorous() +
                  "\nMammal: " + frog.isMammals());