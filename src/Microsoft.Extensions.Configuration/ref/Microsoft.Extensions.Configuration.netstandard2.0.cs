namespace Microsoft.Extensions.Configuration
{
    public partial class BinderOptions
    {
        public BinderOptions() { }
        public bool BindNonPublicProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public static partial class ChainedBuilderExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddConfiguration(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, Microsoft.Extensions.Configuration.IConfiguration config) { throw null; }
    }
    public partial class ChainedConfigurationProvider : Microsoft.Extensions.Configuration.IConfigurationProvider
    {
        public ChainedConfigurationProvider(Microsoft.Extensions.Configuration.ChainedConfigurationSource source) { }
        public System.Collections.Generic.IEnumerable<string> GetChildKeys(System.Collections.Generic.IEnumerable<string> earlierKeys, string parentPath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken GetReloadToken() { throw null; }
        public void Load() { }
        public void Set(string key, string value) { }
        public bool TryGet(string key, out string value) { throw null; }
    }
    public partial class ChainedConfigurationSource : Microsoft.Extensions.Configuration.IConfigurationSource
    {
        public ChainedConfigurationSource() { }
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
    public static partial class CommandLineConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddCommandLine(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.CommandLine.CommandLineConfigurationSource> configureSource) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddCommandLine(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, string[] args) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddCommandLine(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, string[] args, System.Collections.Generic.IDictionary<string, string> switchMappings) { throw null; }
    }
    public static partial class ConfigurationBinder
    {
        public static void Bind(this Microsoft.Extensions.Configuration.IConfiguration configuration, object instance) { }
        public static void Bind(this Microsoft.Extensions.Configuration.IConfiguration configuration, object instance, System.Action<Microsoft.Extensions.Configuration.BinderOptions> configureOptions) { }
        public static void Bind(this Microsoft.Extensions.Configuration.IConfiguration configuration, string key, object instance) { }
        public static object Get(this Microsoft.Extensions.Configuration.IConfiguration configuration, System.Type type) { throw null; }
        public static object Get(this Microsoft.Extensions.Configuration.IConfiguration configuration, System.Type type, System.Action<Microsoft.Extensions.Configuration.BinderOptions> configureOptions) { throw null; }
        public static object GetValue(this Microsoft.Extensions.Configuration.IConfiguration configuration, System.Type type, string key) { throw null; }
        public static object GetValue(this Microsoft.Extensions.Configuration.IConfiguration configuration, System.Type type, string key, object defaultValue) { throw null; }
        public static T GetValue<T>(this Microsoft.Extensions.Configuration.IConfiguration configuration, string key) { throw null; }
        public static T GetValue<T>(this Microsoft.Extensions.Configuration.IConfiguration configuration, string key, T defaultValue) { throw null; }
        public static T Get<T>(this Microsoft.Extensions.Configuration.IConfiguration configuration) { throw null; }
        public static T Get<T>(this Microsoft.Extensions.Configuration.IConfiguration configuration, System.Action<Microsoft.Extensions.Configuration.BinderOptions> configureOptions) { throw null; }
    }
    public partial class ConfigurationBuilder : Microsoft.Extensions.Configuration.IConfigurationBuilder
    {
        public ConfigurationBuilder() { }
        public System.Collections.Generic.IDictionary<string, object> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.Extensions.Configuration.IConfigurationSource> Sources { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Extensions.Configuration.IConfigurationBuilder Add(Microsoft.Extensions.Configuration.IConfigurationSource source) { throw null; }
        public Microsoft.Extensions.Configuration.IConfigurationRoot Build() { throw null; }
    }
    public static partial class ConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder Add<TSource>(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<TSource> configureSource) where TSource : Microsoft.Extensions.Configuration.IConfigurationSource, new() { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> AsEnumerable(this Microsoft.Extensions.Configuration.IConfiguration configuration) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> AsEnumerable(this Microsoft.Extensions.Configuration.IConfiguration configuration, bool makePathsRelative) { throw null; }
        public static bool Exists(this Microsoft.Extensions.Configuration.IConfigurationSection section) { throw null; }
        public static string GetConnectionString(this Microsoft.Extensions.Configuration.IConfiguration configuration, string name) { throw null; }
    }
    public partial class ConfigurationKeyComparer : System.Collections.Generic.IComparer<string>
    {
        public ConfigurationKeyComparer() { }
        public static Microsoft.Extensions.Configuration.ConfigurationKeyComparer Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int Compare(string x, string y) { throw null; }
    }
    public static partial class ConfigurationPath
    {
        public static readonly string KeyDelimiter;
        public static string Combine(System.Collections.Generic.IEnumerable<string> pathSegments) { throw null; }
        public static string Combine(params string[] pathSegments) { throw null; }
        public static string GetParentPath(string path) { throw null; }
        public static string GetSectionKey(string path) { throw null; }
    }
    public abstract partial class ConfigurationProvider : Microsoft.Extensions.Configuration.IConfigurationProvider
    {
        protected ConfigurationProvider() { }
        protected System.Collections.Generic.IDictionary<string, string> Data { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Collections.Generic.IEnumerable<string> GetChildKeys(System.Collections.Generic.IEnumerable<string> earlierKeys, string parentPath) { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken GetReloadToken() { throw null; }
        public virtual void Load() { }
        protected void OnReload() { }
        public virtual void Set(string key, string value) { }
        public virtual bool TryGet(string key, out string value) { throw null; }
    }
    public partial class ConfigurationReloadToken : Microsoft.Extensions.Primitives.IChangeToken
    {
        public ConfigurationReloadToken() { }
        public bool ActiveChangeCallbacks { get { throw null; } }
        public bool HasChanged { get { throw null; } }
        public void OnReload() { }
        public System.IDisposable RegisterChangeCallback(System.Action<object> callback, object state) { throw null; }
    }
    public partial class ConfigurationRoot : Microsoft.Extensions.Configuration.IConfiguration, Microsoft.Extensions.Configuration.IConfigurationRoot
    {
        public ConfigurationRoot(System.Collections.Generic.IList<Microsoft.Extensions.Configuration.IConfigurationProvider> providers) { }
        public string this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.Configuration.IConfigurationProvider> Providers { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.Configuration.IConfigurationSection> GetChildren() { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken GetReloadToken() { throw null; }
        public Microsoft.Extensions.Configuration.IConfigurationSection GetSection(string key) { throw null; }
        public void Reload() { }
    }
    public partial class ConfigurationSection : Microsoft.Extensions.Configuration.IConfiguration, Microsoft.Extensions.Configuration.IConfigurationSection
    {
        public ConfigurationSection(Microsoft.Extensions.Configuration.ConfigurationRoot root, string path) { }
        public string this[string key] { get { throw null; } set { } }
        public string Key { get { throw null; } }
        public string Path { get { throw null; } }
        public string Value { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.Configuration.IConfigurationSection> GetChildren() { throw null; }
        public Microsoft.Extensions.Primitives.IChangeToken GetReloadToken() { throw null; }
        public Microsoft.Extensions.Configuration.IConfigurationSection GetSection(string key) { throw null; }
    }
    public static partial class EnvironmentVariablesExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddEnvironmentVariables(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddEnvironmentVariables(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.EnvironmentVariables.EnvironmentVariablesConfigurationSource> configureSource) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddEnvironmentVariables(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, string prefix) { throw null; }
    }
    public static partial class FileConfigurationExtensions
    {
        public static System.Action<Microsoft.Extensions.Configuration.FileLoadExceptionContext> GetFileLoadExceptionHandler(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
        public static Microsoft.Extensions.FileProviders.IFileProvider GetFileProvider(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder SetBasePath(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string basePath) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder SetFileLoadExceptionHandler(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.FileLoadExceptionContext> handler) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder SetFileProvider(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, Microsoft.Extensions.FileProviders.IFileProvider fileProvider) { throw null; }
    }
    public abstract partial class FileConfigurationProvider : Microsoft.Extensions.Configuration.ConfigurationProvider
    {
        public FileConfigurationProvider(Microsoft.Extensions.Configuration.FileConfigurationSource source) { }
        public Microsoft.Extensions.Configuration.FileConfigurationSource Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void Load() { }
        public abstract void Load(System.IO.Stream stream);
    }
    public abstract partial class FileConfigurationSource : Microsoft.Extensions.Configuration.IConfigurationSource
    {
        protected FileConfigurationSource() { }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Action<Microsoft.Extensions.Configuration.FileLoadExceptionContext> OnLoadException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Optional { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int ReloadDelay { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ReloadOnChange { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public abstract Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder);
        public void EnsureDefaults(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { }
        public void ResolveFileProvider() { }
    }
    public partial class FileLoadExceptionContext
    {
        public FileLoadExceptionContext() { }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Ignore { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Configuration.FileConfigurationProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial interface IConfiguration
    {
        string this[string key] { get; set; }
        System.Collections.Generic.IEnumerable<Microsoft.Extensions.Configuration.IConfigurationSection> GetChildren();
        Microsoft.Extensions.Primitives.IChangeToken GetReloadToken();
        Microsoft.Extensions.Configuration.IConfigurationSection GetSection(string key);
    }
    public partial interface IConfigurationBuilder
    {
        System.Collections.Generic.IDictionary<string, object> Properties { get; }
        System.Collections.Generic.IList<Microsoft.Extensions.Configuration.IConfigurationSource> Sources { get; }
        Microsoft.Extensions.Configuration.IConfigurationBuilder Add(Microsoft.Extensions.Configuration.IConfigurationSource source);
        Microsoft.Extensions.Configuration.IConfigurationRoot Build();
    }
    public partial interface IConfigurationProvider
    {
        System.Collections.Generic.IEnumerable<string> GetChildKeys(System.Collections.Generic.IEnumerable<string> earlierKeys, string parentPath);
        Microsoft.Extensions.Primitives.IChangeToken GetReloadToken();
        void Load();
        void Set(string key, string value);
        bool TryGet(string key, out string value);
    }
    public partial interface IConfigurationRoot : Microsoft.Extensions.Configuration.IConfiguration
    {
        System.Collections.Generic.IEnumerable<Microsoft.Extensions.Configuration.IConfigurationProvider> Providers { get; }
        void Reload();
    }
    public partial interface IConfigurationSection : Microsoft.Extensions.Configuration.IConfiguration
    {
        string Key { get; }
        string Path { get; }
        string Value { get; set; }
    }
    public partial interface IConfigurationSource
    {
        Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder);
    }
    public static partial class IniConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddIniFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, Microsoft.Extensions.FileProviders.IFileProvider provider, string path, bool optional, bool reloadOnChange) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddIniFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.Ini.IniConfigurationSource> configureSource) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddIniFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddIniFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path, bool optional) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddIniFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path, bool optional, bool reloadOnChange) { throw null; }
    }
    public static partial class JsonConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddJsonFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, Microsoft.Extensions.FileProviders.IFileProvider provider, string path, bool optional, bool reloadOnChange) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddJsonFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.Json.JsonConfigurationSource> configureSource) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddJsonFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddJsonFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path, bool optional) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddJsonFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path, bool optional, bool reloadOnChange) { throw null; }
    }
    public static partial class KeyPerFileConfigurationBuilderExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddKeyPerFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.KeyPerFile.KeyPerFileConfigurationSource> configureSource) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddKeyPerFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string directoryPath, bool optional) { throw null; }
    }
    public static partial class MemoryConfigurationBuilderExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddInMemoryCollection(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddInMemoryCollection(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> initialData) { throw null; }
    }
    public static partial class UserSecretsConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddUserSecrets(this Microsoft.Extensions.Configuration.IConfigurationBuilder configuration, System.Reflection.Assembly assembly) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddUserSecrets(this Microsoft.Extensions.Configuration.IConfigurationBuilder configuration, System.Reflection.Assembly assembly, bool optional) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddUserSecrets(this Microsoft.Extensions.Configuration.IConfigurationBuilder configuration, string userSecretsId) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddUserSecrets<T>(this Microsoft.Extensions.Configuration.IConfigurationBuilder configuration) where T : class { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddUserSecrets<T>(this Microsoft.Extensions.Configuration.IConfigurationBuilder configuration, bool optional) where T : class { throw null; }
    }
    public static partial class XmlConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddXmlFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, Microsoft.Extensions.FileProviders.IFileProvider provider, string path, bool optional, bool reloadOnChange) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddXmlFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.Xml.XmlConfigurationSource> configureSource) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddXmlFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddXmlFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path, bool optional) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddXmlFile(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, string path, bool optional, bool reloadOnChange) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.CommandLine
{
    public partial class CommandLineConfigurationProvider : Microsoft.Extensions.Configuration.ConfigurationProvider
    {
        public CommandLineConfigurationProvider(System.Collections.Generic.IEnumerable<string> args, System.Collections.Generic.IDictionary<string, string> switchMappings = null) { }
        protected System.Collections.Generic.IEnumerable<string> Args { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void Load() { }
    }
    public partial class CommandLineConfigurationSource : Microsoft.Extensions.Configuration.IConfigurationSource
    {
        public CommandLineConfigurationSource() { }
        public System.Collections.Generic.IEnumerable<string> Args { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IDictionary<string, string> SwitchMappings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.EnvironmentVariables
{
    public partial class EnvironmentVariablesConfigurationProvider : Microsoft.Extensions.Configuration.ConfigurationProvider
    {
        public EnvironmentVariablesConfigurationProvider() { }
        public EnvironmentVariablesConfigurationProvider(string prefix) { }
        public override void Load() { }
    }
    public partial class EnvironmentVariablesConfigurationSource : Microsoft.Extensions.Configuration.IConfigurationSource
    {
        public EnvironmentVariablesConfigurationSource() { }
        public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.Ini
{
    public partial class IniConfigurationProvider : Microsoft.Extensions.Configuration.FileConfigurationProvider
    {
        public IniConfigurationProvider(Microsoft.Extensions.Configuration.Ini.IniConfigurationSource source) : base (default(Microsoft.Extensions.Configuration.FileConfigurationSource)) { }
        public override void Load(System.IO.Stream stream) { }
    }
    public partial class IniConfigurationSource : Microsoft.Extensions.Configuration.FileConfigurationSource
    {
        public IniConfigurationSource() { }
        public override Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.Json
{
    public partial class JsonConfigurationProvider : Microsoft.Extensions.Configuration.FileConfigurationProvider
    {
        public JsonConfigurationProvider(Microsoft.Extensions.Configuration.Json.JsonConfigurationSource source) : base (default(Microsoft.Extensions.Configuration.FileConfigurationSource)) { }
        public override void Load(System.IO.Stream stream) { }
    }
    public partial class JsonConfigurationSource : Microsoft.Extensions.Configuration.FileConfigurationSource
    {
        public JsonConfigurationSource() { }
        public override Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.KeyPerFile
{
    public partial class KeyPerFileConfigurationProvider : Microsoft.Extensions.Configuration.ConfigurationProvider
    {
        public KeyPerFileConfigurationProvider(Microsoft.Extensions.Configuration.KeyPerFile.KeyPerFileConfigurationSource source) { }
        public override void Load() { }
    }
    public partial class KeyPerFileConfigurationSource : Microsoft.Extensions.Configuration.IConfigurationSource
    {
        public KeyPerFileConfigurationSource() { }
        public Microsoft.Extensions.FileProviders.IFileProvider FileProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Func<string, bool> IgnoreCondition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string IgnorePrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Optional { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.Memory
{
    public partial class MemoryConfigurationProvider : Microsoft.Extensions.Configuration.ConfigurationProvider, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
    {
        public MemoryConfigurationProvider(Microsoft.Extensions.Configuration.Memory.MemoryConfigurationSource source) { }
        public void Add(string key, string value) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class MemoryConfigurationSource : Microsoft.Extensions.Configuration.IConfigurationSource
    {
        public MemoryConfigurationSource() { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> InitialData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.UserSecrets
{
    public partial class PathHelper
    {
        public PathHelper() { }
        public static string GetSecretsPathFromSecretsId(string userSecretsId) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false, AllowMultiple=false)]
    public partial class UserSecretsIdAttribute : System.Attribute
    {
        public UserSecretsIdAttribute(string userSecretId) { }
        public string UserSecretsId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
namespace Microsoft.Extensions.Configuration.Xml
{
    public partial class XmlConfigurationProvider : Microsoft.Extensions.Configuration.FileConfigurationProvider
    {
        public XmlConfigurationProvider(Microsoft.Extensions.Configuration.Xml.XmlConfigurationSource source) : base (default(Microsoft.Extensions.Configuration.FileConfigurationSource)) { }
        public override void Load(System.IO.Stream stream) { }
    }
    public partial class XmlConfigurationSource : Microsoft.Extensions.Configuration.FileConfigurationSource
    {
        public XmlConfigurationSource() { }
        public override Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
    public partial class XmlDocumentDecryptor
    {
        public static readonly Microsoft.Extensions.Configuration.Xml.XmlDocumentDecryptor Instance;
        protected XmlDocumentDecryptor() { }
        public System.Xml.XmlReader CreateDecryptingXmlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings) { throw null; }
        protected virtual System.Xml.XmlReader DecryptDocumentAndCreateXmlReader(System.Xml.XmlDocument document) { throw null; }
    }
}
