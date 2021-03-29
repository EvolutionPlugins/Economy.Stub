using JetBrains.Annotations;
using OpenMod.API.Plugins;
using OpenMod.Core.Plugins;
using System;

[assembly: PluginMetadata("EvolutionPlugins.Economy.Stub", Author = "EvolutionPlugins", DisplayName = "Economy Stub",
    Website = "https://discord.gg/5MT2yke")]

namespace EvolutionPlugins.Economy.Stub
{
    [UsedImplicitly]
    public class EconomyStub : OpenModUniversalPlugin
    {
        public EconomyStub(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}