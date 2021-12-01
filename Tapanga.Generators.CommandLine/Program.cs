using Tapanga.CommandLine;
using Tapanga.Core.Generators;

return await new Runner("Tapanga Demonstration Generators", new GeneratorProvider())
    .InvokeAsync(args);
