// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

[assembly: TypeForwardedTo(typeof(MemoryCache))]
[assembly: TypeForwardedTo(typeof(MemoryCacheOptions))]
[assembly: TypeForwardedTo(typeof(MemoryCacheServiceCollectionExtensions))]
[assembly: TypeForwardedTo(typeof(MemoryDistributedCache))]
[assembly: TypeForwardedTo(typeof(MemoryDistributedCacheOptions))]
