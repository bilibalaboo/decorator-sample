
public class PreRepoDecoratorRepository : IRepository
{
    private readonly IRepository _innerRepository;

    public PreRepoDecoratorRepository(IRepository innerRepository)
    {
        _innerRepository = innerRepository;
    }

    public void Save()
    {
       Console.WriteLine("Before save");
       _innerRepository .Save();
    }
}