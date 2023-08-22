using BenchmarkDotNet.Running;
using TemplateApp.Benchmarks.Tests;

namespace TemplateApp.Benchmarks;

public static class Program
{
	// https://benchmarkdotnet.org/
	public static void Main(string[] args)
	{
		BenchmarkRunner.Run<TemplateAppTests>();
	}
}