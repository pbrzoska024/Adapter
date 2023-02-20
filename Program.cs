class Program
{
    static void Main(string[] args)
    {
        // Create a Cat and wrap it in a CatAdapter
        Cat cat = new Cat();
        CatAdapter catAdapter = new CatAdapter(cat);

        // Create a Dog and wrap it in a DogAdapter
        Dog dog = new Dog();
        DogAdapter dogAdapter = new DogAdapter(dog);

        // Use the AnimalInteractionManager to interact with the animals
        AnimalInteractionManager animalInteractionManager = new AnimalInteractionManager();
        animalInteractionManager.InteractWithAnimal(catAdapter);
        animalInteractionManager.InteractWithAnimal(dogAdapter);
    }
}