using System.Reflection;
using AuditImportService.Configuration;
using Quartz;
using Quartz.Impl;
using Newtonsoft.Json;

namespace AuditImportService.Scheduler;

public class ImportServiceScheduler
{
    public async Task Start()
    {
        IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
        
        await scheduler.Start();

        await ConfigureJobs(scheduler);
    }

    private async Task ConfigureJobs(IScheduler scheduler)
    {
        var configPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!,
            "SchedulerConfig.json");
        
        var json = await File.ReadAllTextAsync(configPath);

        IList<SchedulerJobConfigEntry>? jobEntries = JsonConvert.DeserializeObject<IList<SchedulerJobConfigEntry>>(json);

        if (jobEntries != null)
        {
            foreach (var jobEntry in jobEntries)
            {
                if (jobEntry.Enabled)
                {
                    Type? jobType = Type.GetType($"{jobEntry.JobNamespace}.{jobEntry.JobClass}");

                    IJobDetail jobDetail = JobBuilder.Create(jobType!)
                        .UsingJobData("cfg.namespace", jobEntry.JobNamespace)
                        .UsingJobData("cfg.class", jobEntry.JobClass)
                        .UsingJobData("cfg.description", jobEntry.Description)
                        .UsingJobData("cfg.cronexpression", jobEntry.CronExpression)
                        .Build();

                    ITrigger trigger = TriggerBuilder.Create()
                        .WithCronSchedule(jobEntry.CronExpression!)
                        .Build();

                    await scheduler.ScheduleJob(jobDetail, trigger);
                }
            }
        }
    }
}