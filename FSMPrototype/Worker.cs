namespace FSMPrototype;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    private List<Entity> entities;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
        entities = new List<Entity>();
        entities.Add(new Entity(new EntityStateA()));
        entities.Add(new Entity(new EntityStateB()));
        entities.Add(new Entity(new EntityStateB()));
        entities.Add(new Entity(new EntityStateA()));
        entities.Add(new Entity(new EntityStateB()));
        entities.Add(new Entity(new EntityStateA()));
        entities.Add(new Entity(new EntityStateA()));
        entities.Add(new Entity(new EntityStateA()));
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {


            if(DateTime.Now.Second%2 == 0){
                entities.AsParallel().ForAll(e => e.DoSomething1());
            }
            Console.WriteLine("Next step");
            entities.AsParallel().ForAll(e => e.DoSomething2());

            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}
