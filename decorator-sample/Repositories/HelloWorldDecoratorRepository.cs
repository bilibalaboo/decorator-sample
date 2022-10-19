
public class HelloWorldDecoratorRepository : IRepository
{
    private readonly IRepository _innerRepository;

    public HelloWorldDecoratorRepository(IRepository innerRepository)
    {
        _innerRepository = innerRepository;
    }

    public void Save()
    {
        _innerRepository.Save();
        Console.WriteLine("Hello World Decorator");
    }
}