﻿using Glimpse.Common.Initialization;
using Glimpse.Initialization;
using Glimpse.Server.Resources;
using Glimpse.Platform;
using Microsoft.Extensions.DependencyInjection;

namespace Glimpse
{
    public class ServerDnxServices : IRegisterServices
    {
        public void RegisterServices(IServiceCollection services)
        {
            //
            // Common
            //
            services.AddSingleton<IResourceStartupRuntimeManager, ResourceStartupRuntimeManager>();

            //
            // Options
            //
            services.AddTransient<IExtensionProvider<IResourceStartup>, DefaultExtensionProvider<IResourceStartup>>();
        }
    }
}
