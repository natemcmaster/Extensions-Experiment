// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;

[assembly: TypeForwardedTo(typeof(ILoggerProviderConfiguration<>))]
[assembly: TypeForwardedTo(typeof(ILoggerProviderConfigurationFactory))]
[assembly: TypeForwardedTo(typeof(LoggerProviderOptionsChangeTokenSource<,>))]
[assembly: TypeForwardedTo(typeof(LoggingBuilderConfigurationExtensions))]
[assembly: TypeForwardedTo(typeof(LoggingBuilderExtensions))]

