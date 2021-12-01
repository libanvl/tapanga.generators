using Tapanga.Plugin;

namespace Tapanga.Core.Generators;

public class GeneratorProvider : IGeneratorProvider
{
    public IEnumerable<GeneratorFactoryAsync> GetGeneratorFactories()
    {
        yield return (_) => Task.FromResult<IProfileGenerator>(new SecureShellGenerator());
        yield return (_) => Task.FromResult<IProfileGenerator>(new TestGenerator());
    }
}