using Quartz;
using DomainEntities;

namespace Jobs
{
public class SendEmailJob : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        // Code that sends a periodic email to the user (for example)
        // Note: This method must always return a value 
        // This is especially important for trigger listers watching job execution 
        return Task.FromResult(true);
    }
} 

}