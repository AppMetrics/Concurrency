﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Reflection;
using App.Metrics.Concurrency.Benchmarks.Support;
using BenchmarkDotNet.Running;

namespace App.Metrics.Concurrency.Benchmarks.Runner
{
    // ReSharper disable UnusedMember.Global
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                BenchmarkSwitcher.FromAssembly(typeof(BenchmarksAssemblyMarker).GetTypeInfo().Assembly).Run(args);

                Console.WriteLine("Press ESC to quit, otherwise any key to continue...");

                keyInfo = Console.ReadKey(true);

            } while (keyInfo.Key != ConsoleKey.Escape);            
        }
    }

    // ReSharper restore UnusedMember.Global
}