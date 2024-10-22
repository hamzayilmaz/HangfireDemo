namespace Hangfire.Shared
{
    [Queue("server-112")]
    public class ScheduledJob : IJob
    {
        public TimeSpan Delay { get; set; }
        public DateTimeOffset EnqueueAt { get; set; } = new DateTimeOffset(new DateTime(2025, 1, 1, 0, 0, 0));
        public string CronExpression { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Queue { get; set; } = "scheduled-job";

        public ScheduledJob()
        {
            var jobId = BackgroundJob.Schedule(Queue,
                () => Console.WriteLine("Scheduled job executed!"), enqueueAt: EnqueueAt);
        }
        public async Task Execute()
        {
            await Task.Run(() => {
                Console.WriteLine("Scheduled job executed!");
            });
        }
    }
}
