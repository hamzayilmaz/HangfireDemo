
namespace Hangfire.Shared
{
    public class FireAndForgetJob : IJob
    {
        public TimeSpan Delay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset EnqueueAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CronExpression { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Queue { get; set; } = "fire-and-forget-job";

        public FireAndForgetJob()
        {
            BackgroundJob.Enqueue(Queue, () => Console.WriteLine("Fire and Forget"));
        }
        Task IJob.Execute()
        {
            throw new NotImplementedException();
        }
    }
}