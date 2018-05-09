﻿using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BenchmarkDotNet.InProcess
{
	sealed class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<Array>();
		}
	}

	class Config : ManualConfig
	{
		public Config()
		{
			Add(Job.ShortRun.With(InProcessToolchain.Instance));
		}
	}

	[Config(typeof(Config))]
	public class Array
	{
		readonly Func<string, int> _select;
		readonly string[]          _data;

		public Array() : this(x => default, new Fixture().CreateMany<string>(10_000).ToArray()) {}

		public Array(Expression<Func<string, int>> select, string[] data)
		{
			_select = select.Compile();
			_data   = data;
		}

		[Benchmark]
		public int[] ToArray() => _data.Select(_select).ToArray();
	}
}