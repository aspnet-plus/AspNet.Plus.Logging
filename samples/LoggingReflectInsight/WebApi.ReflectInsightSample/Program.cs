﻿// ReflectInsight
// Copyright (c) 2017 ReflectSoftware.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace WebApi.ReflectInsightSample
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
