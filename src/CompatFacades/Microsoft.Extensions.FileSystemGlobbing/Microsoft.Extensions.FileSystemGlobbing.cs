// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

[assembly: TypeForwardedTo(typeof(DirectoryInfoBase))]
[assembly: TypeForwardedTo(typeof(DirectoryInfoWrapper))]
[assembly: TypeForwardedTo(typeof(FileInfoBase))]
[assembly: TypeForwardedTo(typeof(FileInfoWrapper))]
[assembly: TypeForwardedTo(typeof(FilePatternMatch))]
[assembly: TypeForwardedTo(typeof(FileSystemInfoBase))]
[assembly: TypeForwardedTo(typeof(InMemoryDirectoryInfo))]
[assembly: TypeForwardedTo(typeof(Matcher))]
[assembly: TypeForwardedTo(typeof(MatcherExtensions))]
[assembly: TypeForwardedTo(typeof(PatternMatchingResult))]

// pubternal
[assembly: TypeForwardedTo(typeof(CurrentPathSegment))]
[assembly: TypeForwardedTo(typeof(ILinearPattern))]
[assembly: TypeForwardedTo(typeof(IPathSegment))]
[assembly: TypeForwardedTo(typeof(IPattern))]
[assembly: TypeForwardedTo(typeof(IPatternContext))]
[assembly: TypeForwardedTo(typeof(IRaggedPattern))]
[assembly: TypeForwardedTo(typeof(LiteralPathSegment))]
[assembly: TypeForwardedTo(typeof(MatcherContext))]
[assembly: TypeForwardedTo(typeof(ParentPathSegment))]
[assembly: TypeForwardedTo(typeof(PatternBuilder))]
[assembly: TypeForwardedTo(typeof(PatternContext<>))]
[assembly: TypeForwardedTo(typeof(PatternContextLinear))]
[assembly: TypeForwardedTo(typeof(PatternContextLinearExclude))]
[assembly: TypeForwardedTo(typeof(PatternContextLinearInclude))]
[assembly: TypeForwardedTo(typeof(PatternContextRagged))]
[assembly: TypeForwardedTo(typeof(PatternContextRaggedExclude))]
[assembly: TypeForwardedTo(typeof(PatternContextRaggedInclude))]
[assembly: TypeForwardedTo(typeof(PatternTestResult))]
[assembly: TypeForwardedTo(typeof(RecursiveWildcardSegment))]
[assembly: TypeForwardedTo(typeof(WildcardPathSegment))]
