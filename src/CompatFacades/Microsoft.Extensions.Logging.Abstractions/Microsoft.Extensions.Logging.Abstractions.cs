// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Abstractions.Internal;
using Microsoft.Extensions.Logging.Internal;

[assembly: TypeForwardedTo(typeof(EventId))]
[assembly: TypeForwardedTo(typeof(IExternalScopeProvider))]
[assembly: TypeForwardedTo(typeof(ILogger))]
[assembly: TypeForwardedTo(typeof(ILogger<>))]
[assembly: TypeForwardedTo(typeof(ILoggerFactory))]
[assembly: TypeForwardedTo(typeof(ILoggerProvider))]
[assembly: TypeForwardedTo(typeof(ISupportExternalScope))]
[assembly: TypeForwardedTo(typeof(LoggerExtensions))]
[assembly: TypeForwardedTo(typeof(LoggerExternalScopeProvider))]
[assembly: TypeForwardedTo(typeof(LoggerFactoryExtensions))]
[assembly: TypeForwardedTo(typeof(LoggerMessage))]
[assembly: TypeForwardedTo(typeof(Logger<>))]
[assembly: TypeForwardedTo(typeof(LogLevel))]
[assembly: TypeForwardedTo(typeof(NullLogger))]
[assembly: TypeForwardedTo(typeof(NullLogger<>))]
[assembly: TypeForwardedTo(typeof(NullLoggerFactory))]
[assembly: TypeForwardedTo(typeof(NullLoggerProvider))]


// pubternal
[assembly: TypeForwardedTo(typeof(FormattedLogValues))]
[assembly: TypeForwardedTo(typeof(LogValuesFormatter))]
[assembly: TypeForwardedTo(typeof(NullScope))]
[assembly: TypeForwardedTo(typeof(TypeNameHelper))]
