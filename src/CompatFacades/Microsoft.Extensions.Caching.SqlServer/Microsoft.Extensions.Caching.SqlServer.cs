// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Caching.SqlServer;
using Microsoft.Extensions.DependencyInjection;

[assembly: TypeForwardedTo(typeof(SqlServerCache))]
[assembly: TypeForwardedTo(typeof(SqlServerCacheOptions))]
[assembly: TypeForwardedTo(typeof(SqlServerCachingServicesExtensions))]

