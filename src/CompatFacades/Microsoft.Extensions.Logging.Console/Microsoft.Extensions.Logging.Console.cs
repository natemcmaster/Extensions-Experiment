// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Console.Internal;

[assembly: TypeForwardedTo(typeof(ConfigurationConsoleLoggerSettings))]
[assembly: TypeForwardedTo(typeof(ConsoleLogger))]
[assembly: TypeForwardedTo(typeof(ConsoleLoggerExtensions))]
[assembly: TypeForwardedTo(typeof(ConsoleLoggerOptions))]
[assembly: TypeForwardedTo(typeof(ConsoleLoggerProvider))]
[assembly: TypeForwardedTo(typeof(ConsoleLoggerSettings))]
#pragma warning disable CS0618 // Type or member is obsolete
[assembly: TypeForwardedTo(typeof(ConsoleLogScope))]
#pragma warning restore CS0618 // Type or member is obsolete
[assembly: TypeForwardedTo(typeof(IConsoleLoggerSettings))]

// pubternal
[assembly: TypeForwardedTo(typeof(AnsiLogConsole))]
[assembly: TypeForwardedTo(typeof(ConsoleLoggerProcessor))]
[assembly: TypeForwardedTo(typeof(IAnsiSystemConsole))]
[assembly: TypeForwardedTo(typeof(IConsole))]
[assembly: TypeForwardedTo(typeof(LogMessageEntry))]
[assembly: TypeForwardedTo(typeof(WindowsLogConsole))]
