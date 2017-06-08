using App.Metrics.Concurrency.Benchmarks.Configs;
using BenchmarkDotNet.Attributes;

namespace App.Metrics.Concurrency.Benchmarks
{
    [Config(typeof(DefaultConfig))]
    public abstract class DefaultBenchmarkBase
    {
        [Setup]
        public virtual void Setup()
        {
        }
    }
}