// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using Microsoft.Extensions.Logging.EventLog.Internal;

[assembly: TypeForwardedTo(typeof(EventLoggerFactoryExtensions))]
[assembly: TypeForwardedTo(typeof(EventLogLogger))]
[assembly: TypeForwardedTo(typeof(EventLogLoggerProvider))]
[assembly: TypeForwardedTo(typeof(EventLogSettings))]
[assembly: TypeForwardedTo(typeof(WindowsEventLog))]

// pubternal
[assembly: TypeForwardedTo(typeof(IEventLog))]
