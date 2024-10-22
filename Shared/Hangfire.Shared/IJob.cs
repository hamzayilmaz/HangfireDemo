namespace Hangfire.Shared
{
    public interface IJob
    {
        /// <summary>
        /// İşi calıştır metodu
        /// </summary>
        /// <returns></returns>
        Task Execute();
        /// <summary>
        /// ScheduledJoblar için işin ne kadar zaman sonra kuyruğa ekleneceği
        /// </summary>
        TimeSpan Delay { get; set; }
        /// <summary>
        /// ScheduledJoblar için işin kuyruğa eklenme zamanı
        /// </summary>
        DateTimeOffset EnqueueAt { get; set; }
        /// <summary>
        /// RecurringJoblar için işin ne kadar sürede tekrarlanacağını ifade eder
        /// </summary>
        public string CronExpression { get; set; }
        public string Queue { get; set; }
    }
}
