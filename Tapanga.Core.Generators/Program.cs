using Tapanga.CommandLine;
using Tapanga.Core;
using Tapanga.Core.Generators;
using Tapanga.Plugin;

await new Runner("Tapanga Demonstration Generators", new[]
{
    new GeneratorFactoryAsync(() => Task.FromResult<IProfileGenerator>(new SecureShellGenerator()))
}).InvokeAsync(args);
