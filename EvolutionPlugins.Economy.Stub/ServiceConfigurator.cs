using EvolutionPlugins.Economy.Stub.Services;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using OpenMod.Extensions.Economy.Abstractions;

namespace EvolutionPlugins.Economy.Stub
{
    [UsedImplicitly]
    public static class ServiceCollectionExtension
    {
        [UsedImplicitly]
        public static IServiceCollection AddEconomyStub(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddSingleton<IEconomyProvider, EconomyProviderStub>();
            return serviceCollection;
        }
    }
}