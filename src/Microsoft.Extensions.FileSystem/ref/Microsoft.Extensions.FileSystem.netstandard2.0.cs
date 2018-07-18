namespace Microsoft.Extensions.FileProviders
{
    public partial class CompositeFileProvider : Microsoft.Extensions.FileProviders.IFileProvider
    {
        public CompositeFileProvider(params Microsoft.Extensions.FileProviders.IFileProvider[] fileProviders) { }
        public CompositeFileProvider(System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileProvider> fileProviders) { }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileProvider> FileProviders { get { throw null; } }
        public Microsoft.Extensions.FileProviders.IDirectoryContents GetDirectoryContents(string subpath) { throw null; }
        public Microsoft.Extensions.FileProviders.IFileInfo GetFileInfo(string subpath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken Watch(string pattern) { throw null; }
    }
    public partial class EmbeddedFileProvider : Microsoft.Extensions.FileProviders.IFileProvider
    {
        public EmbeddedFileProvider(System.Reflection.Assembly assembly) { }
        public EmbeddedFileProvider(System.Reflection.Assembly assembly, string baseNamespace) { }
        public Microsoft.Extensions.FileProviders.IDirectoryContents GetDirectoryContents(string subpath) { throw null; }
        public Microsoft.Extensions.FileProviders.IFileInfo GetFileInfo(string subpath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken Watch(string pattern) { throw null; }
    }
    public partial interface IDirectoryContents : System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileInfo>, System.Collections.IEnumerable
    {
        bool Exists { get; }
    }
    public partial interface IFileInfo
    {
        bool Exists { get; }
        bool IsDirectory { get; }
        System.DateTimeOffset LastModified { get; }
        long Length { get; }
        string Name { get; }
        string PhysicalPath { get; }
        System.IO.Stream CreateReadStream();
    }
    public partial interface IFileProvider
    {
        Microsoft.Extensions.FileProviders.IDirectoryContents GetDirectoryContents(string subpath);
        Microsoft.Extensions.FileProviders.IFileInfo GetFileInfo(string subpath);
        Microsoft.Extensions.Primitives.IChangeToken Watch(string filter);
    }
    public partial class ManifestEmbeddedFileProvider : Microsoft.Extensions.FileProviders.IFileProvider
    {
        public ManifestEmbeddedFileProvider(System.Reflection.Assembly assembly) { }
        public ManifestEmbeddedFileProvider(System.Reflection.Assembly assembly, string root) { }
        public ManifestEmbeddedFileProvider(System.Reflection.Assembly assembly, string root, System.DateTimeOffset lastModified) { }
        public ManifestEmbeddedFileProvider(System.Reflection.Assembly assembly, string root, string manifestName, System.DateTimeOffset lastModified) { }
        public System.Reflection.Assembly Assembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Extensions.FileProviders.IDirectoryContents GetDirectoryContents(string subpath) { throw null; }
        public Microsoft.Extensions.FileProviders.IFileInfo GetFileInfo(string subpath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken Watch(string filter) { throw null; }
    }
    public partial class NotFoundDirectoryContents : Microsoft.Extensions.FileProviders.IDirectoryContents, System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileInfo>, System.Collections.IEnumerable
    {
        public NotFoundDirectoryContents() { }
        public bool Exists { get { throw null; } }
        public static Microsoft.Extensions.FileProviders.NotFoundDirectoryContents Singleton { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IEnumerator<Microsoft.Extensions.FileProviders.IFileInfo> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class NotFoundFileInfo : Microsoft.Extensions.FileProviders.IFileInfo
    {
        public NotFoundFileInfo(string name) { }
        public bool Exists { get { throw null; } }
        public bool IsDirectory { get { throw null; } }
        public System.DateTimeOffset LastModified { get { throw null; } }
        public long Length { get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PhysicalPath { get { throw null; } }
        public System.IO.Stream CreateReadStream() { throw null; }
    }
    public partial class NullChangeToken : Microsoft.Extensions.Primitives.IChangeToken
    {
        internal NullChangeToken() { }
        public bool ActiveChangeCallbacks { get { throw null; } }
        public bool HasChanged { get { throw null; } }
        public static Microsoft.Extensions.FileProviders.NullChangeToken Singleton { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.IDisposable RegisterChangeCallback(System.Action<object> callback, object state) { throw null; }
    }
    public partial class NullFileProvider : Microsoft.Extensions.FileProviders.IFileProvider
    {
        public NullFileProvider() { }
        public Microsoft.Extensions.FileProviders.IDirectoryContents GetDirectoryContents(string subpath) { throw null; }
        public Microsoft.Extensions.FileProviders.IFileInfo GetFileInfo(string subpath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken Watch(string filter) { throw null; }
    }
    public partial class PhysicalFileProvider : Microsoft.Extensions.FileProviders.IFileProvider, System.IDisposable
    {
        public PhysicalFileProvider(string root) { }
        public PhysicalFileProvider(string root, Microsoft.Extensions.FileProviders.Physical.ExclusionFilters filters) { }
        public string Root { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void Dispose() { }
        public Microsoft.Extensions.FileProviders.IDirectoryContents GetDirectoryContents(string subpath) { throw null; }
        public Microsoft.Extensions.FileProviders.IFileInfo GetFileInfo(string subpath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken Watch(string filter) { throw null; }
    }
}
namespace Microsoft.Extensions.FileProviders.Composite
{
    public partial class CompositeDirectoryContents : Microsoft.Extensions.FileProviders.IDirectoryContents, System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileInfo>, System.Collections.IEnumerable
    {
        public CompositeDirectoryContents(System.Collections.Generic.IList<Microsoft.Extensions.FileProviders.IFileProvider> fileProviders, string subpath) { }
        public bool Exists { get { throw null; } }
        public System.Collections.Generic.IEnumerator<Microsoft.Extensions.FileProviders.IFileInfo> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
}
namespace Microsoft.Extensions.FileProviders.Embedded
{
    public partial class EmbeddedResourceFileInfo : Microsoft.Extensions.FileProviders.IFileInfo
    {
        public EmbeddedResourceFileInfo(System.Reflection.Assembly assembly, string resourcePath, string name, System.DateTimeOffset lastModified) { }
        public bool Exists { get { throw null; } }
        public bool IsDirectory { get { throw null; } }
        public System.DateTimeOffset LastModified { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public long Length { get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PhysicalPath { get { throw null; } }
        public System.IO.Stream CreateReadStream() { throw null; }
    }
}
namespace Microsoft.Extensions.FileProviders.Internal
{
    public partial class PhysicalDirectoryContents : Microsoft.Extensions.FileProviders.IDirectoryContents, System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileProviders.IFileInfo>, System.Collections.IEnumerable
    {
        public PhysicalDirectoryContents(string directory) { }
        public PhysicalDirectoryContents(string directory, Microsoft.Extensions.FileProviders.Physical.ExclusionFilters filters) { }
        public bool Exists { get { throw null; } }
        public System.Collections.Generic.IEnumerator<Microsoft.Extensions.FileProviders.IFileInfo> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
}
namespace Microsoft.Extensions.FileProviders.Physical
{
    [System.FlagsAttribute]
    public enum ExclusionFilters
    {
        DotPrefixed = 1,
        Hidden = 2,
        None = 0,
        Sensitive = 7,
        System = 4,
    }
    public partial class PhysicalDirectoryInfo : Microsoft.Extensions.FileProviders.IFileInfo
    {
        public PhysicalDirectoryInfo(System.IO.DirectoryInfo info) { }
        public bool Exists { get { throw null; } }
        public bool IsDirectory { get { throw null; } }
        public System.DateTimeOffset LastModified { get { throw null; } }
        public long Length { get { throw null; } }
        public string Name { get { throw null; } }
        public string PhysicalPath { get { throw null; } }
        public System.IO.Stream CreateReadStream() { throw null; }
    }
    public partial class PhysicalFileInfo : Microsoft.Extensions.FileProviders.IFileInfo
    {
        public PhysicalFileInfo(System.IO.FileInfo info) { }
        public bool Exists { get { throw null; } }
        public bool IsDirectory { get { throw null; } }
        public System.DateTimeOffset LastModified { get { throw null; } }
        public long Length { get { throw null; } }
        public string Name { get { throw null; } }
        public string PhysicalPath { get { throw null; } }
        public System.IO.Stream CreateReadStream() { throw null; }
    }
    public partial class PhysicalFilesWatcher : System.IDisposable
    {
        public PhysicalFilesWatcher(string root, System.IO.FileSystemWatcher fileSystemWatcher, bool pollForChanges) { }
        public PhysicalFilesWatcher(string root, System.IO.FileSystemWatcher fileSystemWatcher, bool pollForChanges, Microsoft.Extensions.FileProviders.Physical.ExclusionFilters filters) { }
        public Microsoft.Extensions.Primitives.IChangeToken CreateFileChangeToken(string filter) { throw null; }
        public void Dispose() { }
    }
    public partial class PollingFileChangeToken : Microsoft.Extensions.Primitives.IChangeToken
    {
        public PollingFileChangeToken(System.IO.FileInfo fileInfo) { }
        public bool ActiveChangeCallbacks { get { throw null; } }
        public bool HasChanged { get { throw null; } }
        public System.IDisposable RegisterChangeCallback(System.Action<object> callback, object state) { throw null; }
    }
    public partial class PollingWildCardChangeToken : Microsoft.Extensions.Primitives.IChangeToken
    {
        public PollingWildCardChangeToken(string root, string pattern) { }
        public bool ActiveChangeCallbacks { get { throw null; } }
        public bool HasChanged { get { throw null; } }
        protected virtual System.DateTime GetLastWriteUtc(string path) { throw null; }
        System.IDisposable Microsoft.Extensions.Primitives.IChangeToken.RegisterChangeCallback(System.Action<object> callback, object state) { throw null; }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FilePatternMatch : System.IEquatable<Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch>
    {
        private object _dummy;
        public FilePatternMatch(string path, string stem) { throw null; }
        public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Stem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Equals(Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class InMemoryDirectoryInfo : Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase
    {
        public InMemoryDirectoryInfo(string rootDir, System.Collections.Generic.IEnumerable<string> files) { }
        public override string FullName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase> EnumerateFileSystemInfos() { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase GetDirectory(string path) { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase GetFile(string path) { throw null; }
    }
    public partial class Matcher
    {
        public Matcher() { }
        public Matcher(System.StringComparison comparisonType) { }
        public virtual Microsoft.Extensions.FileSystemGlobbing.Matcher AddExclude(string pattern) { throw null; }
        public virtual Microsoft.Extensions.FileSystemGlobbing.Matcher AddInclude(string pattern) { throw null; }
        public virtual Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Execute(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directoryInfo) { throw null; }
    }
    public static partial class MatcherExtensions
    {
        public static void AddExcludePatterns(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, params System.Collections.Generic.IEnumerable<string>[] excludePatternsGroups) { }
        public static void AddIncludePatterns(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, params System.Collections.Generic.IEnumerable<string>[] includePatternsGroups) { }
        public static System.Collections.Generic.IEnumerable<string> GetResultsInFullPath(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, string directoryPath) { throw null; }
        public static Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Match(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, System.Collections.Generic.IEnumerable<string> files) { throw null; }
        public static Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Match(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, string file) { throw null; }
        public static Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Match(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, string rootDir, System.Collections.Generic.IEnumerable<string> files) { throw null; }
        public static Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Match(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, string rootDir, string file) { throw null; }
    }
    public partial class PatternMatchingResult
    {
        public PatternMatchingResult(System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch> files) { }
        public PatternMatchingResult(System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch> files, bool hasMatches) { }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch> Files { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool HasMatches { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Abstractions
{
    public abstract partial class DirectoryInfoBase : Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase
    {
        protected DirectoryInfoBase() { }
        public abstract System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase> EnumerateFileSystemInfos();
        public abstract Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase GetDirectory(string path);
        public abstract Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase GetFile(string path);
    }
    public partial class DirectoryInfoWrapper : Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase
    {
        public DirectoryInfoWrapper(System.IO.DirectoryInfo directoryInfo) { }
        public override string FullName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase> EnumerateFileSystemInfos() { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase GetDirectory(string name) { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase GetFile(string name) { throw null; }
    }
    public abstract partial class FileInfoBase : Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase
    {
        protected FileInfoBase() { }
    }
    public partial class FileInfoWrapper : Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase
    {
        public FileInfoWrapper(System.IO.FileInfo fileInfo) { }
        public override string FullName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get { throw null; } }
    }
    public abstract partial class FileSystemInfoBase
    {
        protected FileSystemInfoBase() { }
        public abstract string FullName { get; }
        public abstract string Name { get; }
        public abstract Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get; }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal
{
    public partial interface ILinearPattern : Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern
    {
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> Segments { get; }
    }
    public partial interface IPathSegment
    {
        bool CanProduceStem { get; }
        bool Match(string value);
    }
    public partial interface IPattern
    {
        Microsoft.Extensions.FileSystemGlobbing.Internal.IPatternContext CreatePatternContextForExclude();
        Microsoft.Extensions.FileSystemGlobbing.Internal.IPatternContext CreatePatternContextForInclude();
    }
    public partial interface IPatternContext
    {
        void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> onDeclare);
        void PopDirectory();
        void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file);
    }
    public partial interface IRaggedPattern : Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern
    {
        System.Collections.Generic.IList<System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment>> Contains { get; }
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> EndsWith { get; }
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> Segments { get; }
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> StartsWith { get; }
    }
    public partial class MatcherContext
    {
        public MatcherContext(System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern> includePatterns, System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern> excludePatterns, Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directoryInfo, System.StringComparison comparison) { }
        public Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Execute() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PatternTestResult
    {
        private object _dummy;
        private int _dummyPrimitive;
        public static readonly Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Failed;
        public bool IsSuccessful { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Stem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Success(string stem) { throw null; }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments
{
    public partial class CurrentPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public CurrentPathSegment() { }
        public bool CanProduceStem { get { throw null; } }
        public bool Match(string value) { throw null; }
    }
    public partial class LiteralPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public LiteralPathSegment(string value, System.StringComparison comparisonType) { }
        public bool CanProduceStem { get { throw null; } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool Match(string value) { throw null; }
    }
    public partial class ParentPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public ParentPathSegment() { }
        public bool CanProduceStem { get { throw null; } }
        public bool Match(string value) { throw null; }
    }
    public partial class RecursiveWildcardSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public RecursiveWildcardSegment() { }
        public bool CanProduceStem { get { throw null; } }
        public bool Match(string value) { throw null; }
    }
    public partial class WildcardPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public static readonly Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments.WildcardPathSegment MatchAll;
        public WildcardPathSegment(string beginsWith, System.Collections.Generic.List<string> contains, string endsWith, System.StringComparison comparisonType) { }
        public string BeginsWith { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool CanProduceStem { get { throw null; } }
        public System.Collections.Generic.List<string> Contains { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string EndsWith { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Match(string value) { throw null; }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts
{
    public abstract partial class PatternContextLinear : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContext<Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextLinear.FrameData>
    {
        public PatternContextLinear(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern pattern) { }
        protected Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern Pattern { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected string CalculateStem(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase matchedFile) { throw null; }
        protected bool IsLastSegment() { throw null; }
        public override void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { }
        public override Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file) { throw null; }
        protected bool TestMatchingSegment(string value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct FrameData
        {
            private object _dummy;
            public bool InStem;
            public bool IsNotApplicable;
            public int SegmentIndex;
            public string Stem { get { throw null; } }
            public System.Collections.Generic.IList<string> StemItems { get { throw null; } }
        }
    }
    public partial class PatternContextLinearExclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextLinear
    {
        public PatternContextLinearExclude(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern)) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public partial class PatternContextLinearInclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextLinear
    {
        public PatternContextLinearInclude(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern)) { }
        public override void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> onDeclare) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public abstract partial class PatternContextRagged : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContext<Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextRagged.FrameData>
    {
        public PatternContextRagged(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern pattern) { }
        protected Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern Pattern { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected string CalculateStem(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase matchedFile) { throw null; }
        protected bool IsEndingGroup() { throw null; }
        protected bool IsStartingGroup() { throw null; }
        public override void PopDirectory() { }
        public sealed override void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { }
        public override Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file) { throw null; }
        protected bool TestMatchingGroup(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase value) { throw null; }
        protected bool TestMatchingSegment(string value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct FrameData
        {
            private object _dummy;
            public int BacktrackAvailable;
            public bool InStem;
            public bool IsNotApplicable;
            public System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> SegmentGroup;
            public int SegmentGroupIndex;
            public int SegmentIndex;
            public string Stem { get { throw null; } }
            public System.Collections.Generic.IList<string> StemItems { get { throw null; } }
        }
    }
    public partial class PatternContextRaggedExclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextRagged
    {
        public PatternContextRaggedExclude(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern)) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public partial class PatternContextRaggedInclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextRagged
    {
        public PatternContextRaggedInclude(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern)) { }
        public override void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> onDeclare) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public abstract partial class PatternContext<TFrame> : Microsoft.Extensions.FileSystemGlobbing.Internal.IPatternContext
    {
        protected TFrame Frame;
        protected PatternContext() { }
        public virtual void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> declare) { }
        protected bool IsStackEmpty() { throw null; }
        public virtual void PopDirectory() { }
        protected void PushDataFrame(TFrame frame) { }
        public abstract void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        public abstract bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        public abstract Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file);
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns
{
    public partial class PatternBuilder
    {
        public PatternBuilder() { }
        public PatternBuilder(System.StringComparison comparisonType) { }
        public System.StringComparison ComparisonType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern Build(string pattern) { throw null; }
    }
}
