using System.Reflection;
using Avalonia.UnitTests;
using Xunit;

[assembly: AssemblyTitle("Avalonia.UnitTests")]

[assembly: AvaloniaTestFramework(typeof(HeadlessApplication))]
[assembly: CollectionBehavior(CollectionBehavior.CollectionPerAssembly, DisableTestParallelization = false, MaxParallelThreads = 1)]
