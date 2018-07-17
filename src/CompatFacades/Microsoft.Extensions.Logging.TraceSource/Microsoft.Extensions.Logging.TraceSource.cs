// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.TraceSource;

[assembly: TypeForwardedTo(typeof(TraceSourceFactoryExtensions))]
[assembly: TypeForwardedTo(typeof(TraceSourceLogger))]
[assembly: TypeForwardedTo(typeof(TraceSourceLoggerProvider))]
[assembly: TypeForwardedTo(typeof(TraceSourceScope))]
