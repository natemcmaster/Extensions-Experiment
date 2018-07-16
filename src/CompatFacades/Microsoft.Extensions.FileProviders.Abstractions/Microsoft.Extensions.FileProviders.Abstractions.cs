// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.FileProviders;

[assembly: TypeForwardedTo(typeof(IDirectoryContents))]
[assembly: TypeForwardedTo(typeof(IFileInfo))]
[assembly: TypeForwardedTo(typeof(IFileProvider))]
[assembly: TypeForwardedTo(typeof(NotFoundDirectoryContents))]
[assembly: TypeForwardedTo(typeof(NotFoundFileInfo))]
[assembly: TypeForwardedTo(typeof(NullChangeToken))]
[assembly: TypeForwardedTo(typeof(NullFileProvider))]
