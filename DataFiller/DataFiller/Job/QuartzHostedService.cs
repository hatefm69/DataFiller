﻿using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataFiller.Job
{
    class QuartzHostedService : IHostedService
    {
        ISchedulerFactory _schedulerFactory;
        IJobFactory _jobFactory;
        IEnumerable<JobSchedule> _jobSchedules;
        public QuartzHostedService(ISchedulerFactory schedulerFactory, IJobFactory jobFactory, IEnumerable<JobSchedule> jobSchedules)
        {
            _schedulerFactory = schedulerFactory;
            _jobFactory = jobFactory;
            _jobSchedules = jobSchedules;
        }
        public IScheduler Scheduler { get; set; }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Scheduler = await _schedulerFactory.GetScheduler(cancellationToken);
            Scheduler.JobFactory = _jobFactory;

            foreach (var jobSchedule in _jobSchedules)
            {
                var job = CreateJob(jobSchedule);
                var trigger = CreateTrigger(jobSchedule);

                await Scheduler.ScheduleJob(job, trigger, cancellationToken);
            }
            await Scheduler.Start(cancellationToken);
        }

        private ITrigger CreateTrigger(JobSchedule schedule)
        {
            return TriggerBuilder
            .Create()
            .WithIdentity($"{schedule.JobType.FullName}.trigger")
            .WithCronSchedule(schedule.CronExpression)
            .WithDescription(schedule.CronExpression)
            .Build();
        
        }

        private IJobDetail CreateJob(JobSchedule schedule)
        {
            var jobType = schedule.JobType;
            return JobBuilder
                .Create(jobType)
                .WithIdentity(jobType.FullName)
                .WithDescription(jobType.Name)
                .Build();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Scheduler?.Shutdown(cancellationToken);
        }
    }
}
