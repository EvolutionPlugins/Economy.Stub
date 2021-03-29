using EvolutionPlugins.Economy.Stub.Services;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using OpenMod.API.Ioc;
using OpenMod.API.Prioritization;
using OpenMod.Extensions.Economy.Abstractions;

namespace EvolutionPlugins.Economy.Stub
{
    [Priority(Priority = Priority.Lowest)]
    [UsedImplicitly]
    public class ServiceConfigurator : IServiceConfigurator
    {
        public void ConfigureServices(IOpenModServiceConfigurationContext openModStartupContext,
            IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddSingleton<IEconomyProvider, EconomyProviderStub>();
        }
    }
}