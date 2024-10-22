namespace Hangfire.Client.Controllers
{
    using Hangfire;
    using Hangfire.Common;
    using Hangfire.Shared;
    using Microsoft.AspNetCore.Mvc;
    using System;

    namespace HangfireDemo.Controllers
    {
        [ApiController]
        [Route("[controller]/[action]")]
        public class JobController : ControllerBase
        {
            private readonly IBackgroundJobClient _client;

            public JobController(IBackgroundJobClient client)
            {
                _client = client;
            }

            [HttpGet]
            public ActionResult FireAndForgetJob()
            {
                try
                {
                    new FireAndForgetJob();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return BadRequest(ex.ToString());
                }

                return Ok();
            }

            [HttpGet]
            public async Task<IActionResult> ScheduledJob()
            {
                await new ScheduledJob().Execute();
                
                return Ok();
            }

            [HttpGet]
            public IActionResult AddRecurringJob()
            {
                new RepetitiveJob();

                return Ok();
            }
        }
    }

}
