using Quartz;
using DomainEntities;

namespace Jobs
{
public class SubmissionScoreCardJob : IJob
{
    private readonly ILogger<SubmissionScoreCardJob> _logger;
    private readonly GolfDbContext _dbcontext;

    public SubmissionScoreCardJob(GolfDbContext dbcontext)
    {
        _dbcontext = dbcontext;
        _logger = LoggerFactory.Create(builder => builder.AddConsole())
                       .CreateLogger<SubmissionScoreCardJob>();
    }
    public Task Execute(IJobExecutionContext context)
    {
        // Code that sends a periodic email to the user (for example)
        // Note: This method must always return a value 
        // This is especially important for trigger listers watching job execution 
        _logger.LogInformation("Event is triggered");
        return Task.FromResult(true);
    }
}    
}