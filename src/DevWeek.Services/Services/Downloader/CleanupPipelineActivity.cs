﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevWeek.Services.Downloader
{
    public class CleanupPipelineActivity : IPipelineActivity
    {
        public Task ExecuteAsync(DownloadContext context)
        {
            System.IO.File.Delete(context.OutputFileName);

            return Task.CompletedTask;
        }
    }
}
