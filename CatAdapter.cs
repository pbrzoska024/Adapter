public class CatAdapter : IAnimal
{
    private Cat _cat;

    public CatAdapter(Cat cat)
    {
        _cat = cat;
    }

    public void MakeSound()
    {
        _cat.Meow();
    }
}