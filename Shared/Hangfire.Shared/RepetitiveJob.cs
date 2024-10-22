namespace Hangfire.Shared
{
    public class RepetitiveJob : IJob
    {
        public TimeSpan Delay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset EnqueueAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CronExpression { get; set; } = Cron.Daily();
        public string Queue { get; set; } = "repetitive-job";

        public RepetitiveJob()
        {
            RecurringJob.AddOrUpdate("RecurringJobId", queue : Queue,
                    () => Execute(),
                    CronExpression);
        }
        public async Task Execute()
        {
            await Task.Run(() => {
                Console.WriteLine($"Recurring job executed. Cron = {CronExpression}!");
            });
        }
    }
}
