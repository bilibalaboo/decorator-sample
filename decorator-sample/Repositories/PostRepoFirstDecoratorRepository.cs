
public class PostRepoFirstDecoratorRepository : IRepository
{
    private readonly IRepository _innerRepository;

    public PostRepoFirstDecoratorRepository(IRepository innerRepository)
    {
        _innerRepository = innerRepository;
    }

    public void Save()
    {
        _innerRepository.Save();
        Console.WriteLine("After save 1");
    }
}