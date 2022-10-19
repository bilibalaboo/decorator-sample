public class SampleService : ISampleService
{
    private readonly IRepository _repository;

    public SampleService(IRepository repository)
    {
        _repository = repository;
    }

    public void SaveData()
    {
        _repository.Save();
    }
}