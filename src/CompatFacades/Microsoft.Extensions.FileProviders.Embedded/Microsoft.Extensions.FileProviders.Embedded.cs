// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.FileProviders.Embedded;

[assembly: TypeForwardedTo(typeof(EmbeddedFileProvider))]
[assembly: TypeForwardedTo(typeof(EmbeddedResourceFileInfo))]
[assembly: TypeForwardedTo(typeof(ManifestEmbeddedFileProvider))]
