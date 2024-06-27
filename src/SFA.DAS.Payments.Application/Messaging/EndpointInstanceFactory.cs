using System;
using System.Threading;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using NServiceBus;
using SFA.DAS.Payments.Application.Infrastructure.Ioc;
using SFA.DAS.Payments.Core.Configuration;

namespace SFA.DAS.Payments.Application.Messaging
{


    public interface IEndpointInstanceFactory
    {
        Task<IEndpointInstance> GetEndpointInstance();
    }

    public class EndpointInstanceFactory : IEndpointInstanceFactory
    {

        private static IEndpointInstance _endpointInstance;

        private static readonly ReaderWriterLockSlim Locker = new ReaderWriterLockSlim();
        private static IStartableEndpointWithExternallyManagedContainer _startableEndpoint;

        //TODO: Hack to cope with the new NSB config API.  Will refactor. 
        public static void Initialise(IApplicationConfiguration config)
        {

            var endpointConfig = EndpointConfigurationFactory.Create(config);
            _startableEndpoint = EndpointWithExternallyManagedContainer.Create(endpointConfig, ContainerFactory.ServiceCollection);
        }

        //FundingSources sets up a full EndpointConfiguration that needs passing in.
        public static void Initialise(EndpointConfiguration config)
        {
            _startableEndpoint = EndpointWithExternallyManagedContainer.Create(config, ContainerFactory.ServiceCollection);
        }
        public async Task<IEndpointInstance> GetEndpointInstance()
        {

            if (_endpointInstance != null)
                return _endpointInstance;

            if (_startableEndpoint == null)
                throw new InvalidOperationException("EndpointInstanceFactory has not been initialised!!");

            _endpointInstance =
                await _startableEndpoint.Start(new AutofacServiceProvider(ContainerFactory.Container));
            

            return _endpointInstance;
        }
    }
}

