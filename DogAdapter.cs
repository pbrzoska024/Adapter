public class DogAdapter : IAnimal
{
    private Dog _dog;

    public DogAdapter(Dog dog)
    {
        _dog = dog;
    }

    public void MakeSound()
    {
        _dog.Bark();
    }
}