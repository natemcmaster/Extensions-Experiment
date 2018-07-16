// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

[assembly: TypeForwardedTo(typeof(IServiceCollection))]
[assembly: TypeForwardedTo(typeof(IServiceProviderFactory<>))]
[assembly: TypeForwardedTo(typeof(IServiceScope))]
[assembly: TypeForwardedTo(typeof(IServiceScopeFactory))]
[assembly: TypeForwardedTo(typeof(ISupportRequiredService))]
[assembly: TypeForwardedTo(typeof(ServiceCollectionDescriptorExtensions))]
[assembly: TypeForwardedTo(typeof(ServiceCollectionServiceExtensions))]
[assembly: TypeForwardedTo(typeof(ServiceDescriptor))]
[assembly: TypeForwardedTo(typeof(ServiceLifetime))]
[assembly: TypeForwardedTo(typeof(ServiceProviderServiceExtensions))]
