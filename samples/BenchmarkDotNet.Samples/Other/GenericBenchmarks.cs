﻿using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace BenchmarkDotNet.Samples.Other
{
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(char))]
    public class GenericBenchmarks<T>
    {
        [Benchmark] public T Create() => Activator.CreateInstance<T>();
    }
}