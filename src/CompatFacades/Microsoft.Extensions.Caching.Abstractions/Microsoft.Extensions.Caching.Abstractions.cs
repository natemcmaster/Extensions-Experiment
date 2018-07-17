// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Internal;

[assembly: TypeForwardedTo(typeof(CacheEntryExtensions))]
[assembly: TypeForwardedTo(typeof(CacheItemPriority))]
[assembly: TypeForwardedTo(typeof(DistributedCacheEntryExtensions))]
[assembly: TypeForwardedTo(typeof(DistributedCacheEntryOptions))]
[assembly: TypeForwardedTo(typeof(DistributedCacheExtensions))]
[assembly: TypeForwardedTo(typeof(EvictionReason))]
[assembly: TypeForwardedTo(typeof(ICacheEntry))]
[assembly: TypeForwardedTo(typeof(MemoryCacheEntryExtensions))]
[assembly: TypeForwardedTo(typeof(MemoryCacheEntryOptions))]
[assembly: TypeForwardedTo(typeof(CacheExtensions))]
[assembly: TypeForwardedTo(typeof(PostEvictionCallbackRegistration))]
[assembly: TypeForwardedTo(typeof(PostEvictionDelegate))]

// pubternal
[assembly: TypeForwardedTo(typeof(ISystemClock))]
[assembly: TypeForwardedTo(typeof(SystemClock))]

