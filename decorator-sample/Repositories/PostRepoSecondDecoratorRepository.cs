
public class PostRepoSecondDecoratorRepository : IRepository
{
    private readonly IRepository _innerRepository;

    public PostRepoSecondDecoratorRepository(IRepository innerRepository)
    {
        _innerRepository = innerRepository;
    }

    public void Save()
    {
        _innerRepository.Save();
        Console.WriteLine("After save 2");
    }
}