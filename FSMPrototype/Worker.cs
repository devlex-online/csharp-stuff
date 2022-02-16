namespace FSMPrototype;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var entity = new Entity(new EntityStateA);
        while (!stoppingToken.IsCancellationRequested)
        {
            entity.DoSomething1();
            entity.DoSomething2();
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}
