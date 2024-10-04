Animal[] animals = new Animal[5];

animals[0] = new Animal();
animals[1] = new Dog();
animals[2] = new Cat();
animals[3] = new Cow();
animals[4] = new Dog();


foreach (Animal animal in animals)
{
    animal.Speak();
}