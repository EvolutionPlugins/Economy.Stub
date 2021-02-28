using OpenMod.API.Ioc;
using OpenMod.API.Prioritization;
using OpenMod.Extensions.Economy.Abstractions;
using System;
using System.Threading.Tasks;

namespace EvolutionPlugins.Economy.Stub.Services
{
    [PluginServiceImplementation(Priority = Priority.Lowest)]
    public class EconomyProviderStub : IEconomyProvider
    {
        private readonly NotImplementedException m_Exception = new NotImplementedException("Install \"OpenMod.Economy\" plugin to enable Economy manipulation");

        public string CurrencyName => throw m_Exception;

        public string CurrencySymbol => throw m_Exception;

        public Task<decimal> GetBalanceAsync(string ownerId, string ownerType)
        {
            throw m_Exception;
        }

        public Task SetBalanceAsync(string ownerId, string ownerType, decimal balance)
        {
            throw m_Exception;
        }

        public Task<decimal> UpdateBalanceAsync(string ownerId, string ownerType, decimal changeAmount, string reason)
        {
            throw m_Exception;
        }
    }
}
