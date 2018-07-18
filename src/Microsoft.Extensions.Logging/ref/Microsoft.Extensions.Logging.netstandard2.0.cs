namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class LoggingServiceCollectionExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLogging(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLogging(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.Extensions.Logging.ILoggingBuilder> configure) { throw null; }
    }
}
namespace Microsoft.Extensions.Logging
{
    public static partial class ConsoleLoggerExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory, Microsoft.Extensions.Configuration.IConfiguration configuration) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory, Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings settings) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory, Microsoft.Extensions.Logging.LogLevel minLevel) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory, Microsoft.Extensions.Logging.LogLevel minLevel, bool includeScopes) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory, bool includeScopes) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddConsole(this Microsoft.Extensions.Logging.ILoggerFactory factory, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter, bool includeScopes) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddConsole(this Microsoft.Extensions.Logging.ILoggingBuilder builder) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddConsole(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Action<Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions> configure) { throw null; }
    }
    public static partial class DebugLoggerFactoryExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggerFactory AddDebug(this Microsoft.Extensions.Logging.ILoggerFactory factory) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddDebug(this Microsoft.Extensions.Logging.ILoggerFactory factory, Microsoft.Extensions.Logging.LogLevel minLevel) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddDebug(this Microsoft.Extensions.Logging.ILoggerFactory factory, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddDebug(this Microsoft.Extensions.Logging.ILoggingBuilder builder) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EventId
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EventId(int id, string name = null) { throw null; }
        public int Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Equals(Microsoft.Extensions.Logging.EventId other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.Extensions.Logging.EventId left, Microsoft.Extensions.Logging.EventId right) { throw null; }
        public static implicit operator Microsoft.Extensions.Logging.EventId (int i) { throw null; }
        public static bool operator !=(Microsoft.Extensions.Logging.EventId left, Microsoft.Extensions.Logging.EventId right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class EventLoggerFactoryExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggerFactory AddEventLog(this Microsoft.Extensions.Logging.ILoggerFactory factory) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddEventLog(this Microsoft.Extensions.Logging.ILoggerFactory factory, Microsoft.Extensions.Logging.EventLog.EventLogSettings settings) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddEventLog(this Microsoft.Extensions.Logging.ILoggerFactory factory, Microsoft.Extensions.Logging.LogLevel minLevel) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddEventLog(this Microsoft.Extensions.Logging.ILoggingBuilder builder) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddEventLog(this Microsoft.Extensions.Logging.ILoggingBuilder builder, Microsoft.Extensions.Logging.EventLog.EventLogSettings settings) { throw null; }
    }
    public static partial class EventSourceLoggerFactoryExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggerFactory AddEventSourceLogger(this Microsoft.Extensions.Logging.ILoggerFactory factory) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddEventSourceLogger(this Microsoft.Extensions.Logging.ILoggingBuilder builder) { throw null; }
    }
    public static partial class FilterLoggingBuilderExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> categoryLevelFilter) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Func<string, string, Microsoft.Extensions.Logging.LogLevel, bool> filter) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter(this Microsoft.Extensions.Logging.ILoggingBuilder builder, string category, Microsoft.Extensions.Logging.LogLevel level) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter(this Microsoft.Extensions.Logging.ILoggingBuilder builder, string category, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> categoryLevelFilter) { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, System.Func<string, string, Microsoft.Extensions.Logging.LogLevel, bool> filter) { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, string category, Microsoft.Extensions.Logging.LogLevel level) { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, string category, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter<T>(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter<T>(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> categoryLevelFilter) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter<T>(this Microsoft.Extensions.Logging.ILoggingBuilder builder, string category, Microsoft.Extensions.Logging.LogLevel level) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddFilter<T>(this Microsoft.Extensions.Logging.ILoggingBuilder builder, string category, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter<T>(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter<T>(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> categoryLevelFilter) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter<T>(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, string category, Microsoft.Extensions.Logging.LogLevel level) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
        public static Microsoft.Extensions.Logging.LoggerFilterOptions AddFilter<T>(this Microsoft.Extensions.Logging.LoggerFilterOptions builder, string category, System.Func<Microsoft.Extensions.Logging.LogLevel, bool> levelFilter) where T : Microsoft.Extensions.Logging.ILoggerProvider { throw null; }
    }
    public partial interface IExternalScopeProvider
    {
        void ForEachScope<TState>(System.Action<object, TState> callback, TState state);
        System.IDisposable Push(object state);
    }
    public partial interface ILogger
    {
        System.IDisposable BeginScope<TState>(TState state);
        bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel);
        void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter);
    }
    public partial interface ILoggerFactory : System.IDisposable
    {
        void AddProvider(Microsoft.Extensions.Logging.ILoggerProvider provider);
        Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName);
    }
    public partial interface ILoggerProvider : System.IDisposable
    {
        Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName);
    }
    public partial interface ILogger<out TCategoryName> : Microsoft.Extensions.Logging.ILogger
    {
    }
    public partial interface ILoggingBuilder
    {
        Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
    }
    public partial interface ISupportExternalScope
    {
        void SetScopeProvider(Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider);
    }
    public static partial class LoggerExtensions
    {
        public static System.IDisposable BeginScope(this Microsoft.Extensions.Logging.ILogger logger, string messageFormat, params object[] args) { throw null; }
        public static void Log(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message, params object[] args) { }
        public static void Log(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args) { }
        public static void Log(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.LogLevel logLevel, System.Exception exception, string message, params object[] args) { }
        public static void Log(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.LogLevel logLevel, string message, params object[] args) { }
        public static void LogCritical(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message, params object[] args) { }
        public static void LogCritical(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args) { }
        public static void LogCritical(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception, string message, params object[] args) { }
        public static void LogCritical(this Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args) { }
        public static void LogDebug(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message, params object[] args) { }
        public static void LogDebug(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args) { }
        public static void LogDebug(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception, string message, params object[] args) { }
        public static void LogDebug(this Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args) { }
        public static void LogError(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message, params object[] args) { }
        public static void LogError(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args) { }
        public static void LogError(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception, string message, params object[] args) { }
        public static void LogError(this Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args) { }
        public static void LogInformation(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message, params object[] args) { }
        public static void LogInformation(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args) { }
        public static void LogInformation(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception, string message, params object[] args) { }
        public static void LogInformation(this Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args) { }
        public static void LogTrace(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message, params object[] args) { }
        public static void LogTrace(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args) { }
        public static void LogTrace(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception, string message, params object[] args) { }
        public static void LogTrace(this Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args) { }
        public static void LogWarning(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message, params object[] args) { }
        public static void LogWarning(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args) { }
        public static void LogWarning(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception, string message, params object[] args) { }
        public static void LogWarning(this Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args) { }
    }
    public partial class LoggerExternalScopeProvider : Microsoft.Extensions.Logging.IExternalScopeProvider
    {
        public LoggerExternalScopeProvider() { }
        public void ForEachScope<TState>(System.Action<object, TState> callback, TState state) { }
        public System.IDisposable Push(object state) { throw null; }
    }
    public partial class LoggerFactory : Microsoft.Extensions.Logging.ILoggerFactory, System.IDisposable
    {
        public LoggerFactory() { }
        public LoggerFactory(System.Collections.Generic.IEnumerable<Microsoft.Extensions.Logging.ILoggerProvider> providers) { }
        public LoggerFactory(System.Collections.Generic.IEnumerable<Microsoft.Extensions.Logging.ILoggerProvider> providers, Microsoft.Extensions.Logging.LoggerFilterOptions filterOptions) { }
        public LoggerFactory(System.Collections.Generic.IEnumerable<Microsoft.Extensions.Logging.ILoggerProvider> providers, Microsoft.Extensions.Options.IOptionsMonitor<Microsoft.Extensions.Logging.LoggerFilterOptions> filterOption) { }
        public void AddProvider(Microsoft.Extensions.Logging.ILoggerProvider provider) { }
        protected virtual bool CheckDisposed() { throw null; }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName) { throw null; }
        public void Dispose() { }
    }
    public static partial class LoggerFactoryExtensions
    {
        public static Microsoft.Extensions.Logging.ILogger CreateLogger(this Microsoft.Extensions.Logging.ILoggerFactory factory, System.Type type) { throw null; }
        public static Microsoft.Extensions.Logging.ILogger<T> CreateLogger<T>(this Microsoft.Extensions.Logging.ILoggerFactory factory) { throw null; }
    }
    public partial class LoggerFilterOptions
    {
        public LoggerFilterOptions() { }
        public Microsoft.Extensions.Logging.LogLevel MinLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IList<Microsoft.Extensions.Logging.LoggerFilterRule> Rules { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class LoggerFilterRule
    {
        public LoggerFilterRule(string providerName, string categoryName, System.Nullable<Microsoft.Extensions.Logging.LogLevel> logLevel, System.Func<string, string, Microsoft.Extensions.Logging.LogLevel, bool> filter) { }
        public string CategoryName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Func<string, string, Microsoft.Extensions.Logging.LogLevel, bool> Filter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Nullable<Microsoft.Extensions.Logging.LogLevel> LogLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ProviderName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string ToString() { throw null; }
    }
    public static partial class LoggerMessage
    {
        public static System.Action<Microsoft.Extensions.Logging.ILogger, System.Exception> Define(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string formatString) { throw null; }
        public static System.Func<Microsoft.Extensions.Logging.ILogger, System.IDisposable> DefineScope(string formatString) { throw null; }
        public static System.Func<Microsoft.Extensions.Logging.ILogger, T1, System.IDisposable> DefineScope<T1>(string formatString) { throw null; }
        public static System.Func<Microsoft.Extensions.Logging.ILogger, T1, T2, System.IDisposable> DefineScope<T1, T2>(string formatString) { throw null; }
        public static System.Func<Microsoft.Extensions.Logging.ILogger, T1, T2, T3, System.IDisposable> DefineScope<T1, T2, T3>(string formatString) { throw null; }
        public static System.Action<Microsoft.Extensions.Logging.ILogger, T1, System.Exception> Define<T1>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string formatString) { throw null; }
        public static System.Action<Microsoft.Extensions.Logging.ILogger, T1, T2, System.Exception> Define<T1, T2>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string formatString) { throw null; }
        public static System.Action<Microsoft.Extensions.Logging.ILogger, T1, T2, T3, System.Exception> Define<T1, T2, T3>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string formatString) { throw null; }
        public static System.Action<Microsoft.Extensions.Logging.ILogger, T1, T2, T3, T4, System.Exception> Define<T1, T2, T3, T4>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string formatString) { throw null; }
        public static System.Action<Microsoft.Extensions.Logging.ILogger, T1, T2, T3, T4, T5, System.Exception> Define<T1, T2, T3, T4, T5>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string formatString) { throw null; }
        public static System.Action<Microsoft.Extensions.Logging.ILogger, T1, T2, T3, T4, T5, T6, System.Exception> Define<T1, T2, T3, T4, T5, T6>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, string formatString) { throw null; }
    }
    public partial class Logger<T> : Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.ILogger<T>
    {
        public Logger(Microsoft.Extensions.Logging.ILoggerFactory factory) { }
        System.IDisposable Microsoft.Extensions.Logging.ILogger.BeginScope<TState>(TState state) { throw null; }
        bool Microsoft.Extensions.Logging.ILogger.IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        void Microsoft.Extensions.Logging.ILogger.Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
    }
    public static partial class LoggingBuilderExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddConfiguration(this Microsoft.Extensions.Logging.ILoggingBuilder builder, Microsoft.Extensions.Configuration.IConfiguration configuration) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddProvider(this Microsoft.Extensions.Logging.ILoggingBuilder builder, Microsoft.Extensions.Logging.ILoggerProvider provider) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder ClearProviders(this Microsoft.Extensions.Logging.ILoggingBuilder builder) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder SetMinimumLevel(this Microsoft.Extensions.Logging.ILoggingBuilder builder, Microsoft.Extensions.Logging.LogLevel level) { throw null; }
    }
    public enum LogLevel
    {
        Critical = 5,
        Debug = 1,
        Error = 4,
        Information = 2,
        None = 6,
        Trace = 0,
        Warning = 3,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
    public partial class ProviderAliasAttribute : System.Attribute
    {
        public ProviderAliasAttribute(string alias) { }
        public string Alias { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public static partial class TraceSourceFactoryExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggerFactory AddTraceSource(this Microsoft.Extensions.Logging.ILoggerFactory factory, System.Diagnostics.SourceSwitch sourceSwitch) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddTraceSource(this Microsoft.Extensions.Logging.ILoggerFactory factory, System.Diagnostics.SourceSwitch sourceSwitch, System.Diagnostics.TraceListener listener) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddTraceSource(this Microsoft.Extensions.Logging.ILoggerFactory factory, string switchName) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggerFactory AddTraceSource(this Microsoft.Extensions.Logging.ILoggerFactory factory, string switchName, System.Diagnostics.TraceListener listener) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddTraceSource(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Diagnostics.SourceSwitch sourceSwitch) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddTraceSource(this Microsoft.Extensions.Logging.ILoggingBuilder builder, System.Diagnostics.SourceSwitch sourceSwitch, System.Diagnostics.TraceListener listener) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddTraceSource(this Microsoft.Extensions.Logging.ILoggingBuilder builder, string switchName) { throw null; }
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddTraceSource(this Microsoft.Extensions.Logging.ILoggingBuilder builder, string switchName, System.Diagnostics.TraceListener listener) { throw null; }
    }
}
namespace Microsoft.Extensions.Logging.Abstractions
{
    public partial class NullLogger : Microsoft.Extensions.Logging.ILogger
    {
        internal NullLogger() { }
        public static Microsoft.Extensions.Logging.Abstractions.NullLogger Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.IDisposable BeginScope<TState>(TState state) { throw null; }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
    }
    public partial class NullLoggerFactory : Microsoft.Extensions.Logging.ILoggerFactory, System.IDisposable
    {
        public static readonly Microsoft.Extensions.Logging.Abstractions.NullLoggerFactory Instance;
        public NullLoggerFactory() { }
        public void AddProvider(Microsoft.Extensions.Logging.ILoggerProvider provider) { }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string name) { throw null; }
        public void Dispose() { }
    }
    public partial class NullLoggerProvider : Microsoft.Extensions.Logging.ILoggerProvider, System.IDisposable
    {
        internal NullLoggerProvider() { }
        public static Microsoft.Extensions.Logging.Abstractions.NullLoggerProvider Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName) { throw null; }
        public void Dispose() { }
    }
    public partial class NullLogger<T> : Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.ILogger<T>
    {
        public static readonly Microsoft.Extensions.Logging.Abstractions.NullLogger<T> Instance;
        public NullLogger() { }
        public System.IDisposable BeginScope<TState>(TState state) { throw null; }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
    }
}
namespace Microsoft.Extensions.Logging.Abstractions.Internal
{
    public partial class NullScope : System.IDisposable
    {
        internal NullScope() { }
        public static Microsoft.Extensions.Logging.Abstractions.Internal.NullScope Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void Dispose() { }
    }
    public partial class TypeNameHelper
    {
        public TypeNameHelper() { }
        public static string GetTypeDisplayName(System.Type type) { throw null; }
    }
}
namespace Microsoft.Extensions.Logging.Configuration
{
    public partial interface ILoggerProviderConfigurationFactory
    {
        Microsoft.Extensions.Configuration.IConfiguration GetConfiguration(System.Type providerType);
    }
    public partial interface ILoggerProviderConfiguration<T>
    {
        Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }
    }
    public partial class LoggerProviderOptionsChangeTokenSource<TOptions, TProvider> : Microsoft.Extensions.Options.ConfigurationChangeTokenSource<TOptions>
    {
        public LoggerProviderOptionsChangeTokenSource(Microsoft.Extensions.Logging.Configuration.ILoggerProviderConfiguration<TProvider> providerConfiguration) : base (default(Microsoft.Extensions.Configuration.IConfiguration)) { }
    }
    public static partial class LoggingBuilderConfigurationExtensions
    {
        public static void AddConfiguration(this Microsoft.Extensions.Logging.ILoggingBuilder builder) { }
    }
}
namespace Microsoft.Extensions.Logging.Console
{
    public partial class ConfigurationConsoleLoggerSettings : Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings
    {
        public ConfigurationConsoleLoggerSettings(Microsoft.Extensions.Configuration.IConfiguration configuration) { }
        public Microsoft.Extensions.Primitives.IChangeToken ChangeToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IncludeScopes { get { throw null; } }
        public Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings Reload() { throw null; }
        public bool TryGetSwitch(string name, out Microsoft.Extensions.Logging.LogLevel level) { throw null; }
    }
    public partial class ConsoleLogger : Microsoft.Extensions.Logging.ILogger
    {
        public ConsoleLogger(string name, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter, Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider) { }
        public ConsoleLogger(string name, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter, bool includeScopes) { }
        public Microsoft.Extensions.Logging.Console.Internal.IConsole Console { get { throw null; } set { } }
        public bool DisableColors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> Filter { get { throw null; } set { } }
        [System.ObsoleteAttribute("Changing this property has no effect. Use ConsoleLoggerOptions.IncludeScopes instead")]
        public bool IncludeScopes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.IDisposable BeginScope<TState>(TState state) { throw null; }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
        public virtual void WriteMessage(Microsoft.Extensions.Logging.LogLevel logLevel, string logName, int eventId, string message, System.Exception exception) { }
    }
    public partial class ConsoleLoggerOptions
    {
        public ConsoleLoggerOptions() { }
        public bool DisableColors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IncludeScopes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [Microsoft.Extensions.Logging.ProviderAliasAttribute("Console")]
    public partial class ConsoleLoggerProvider : Microsoft.Extensions.Logging.ILoggerProvider, Microsoft.Extensions.Logging.ISupportExternalScope, System.IDisposable
    {
        public ConsoleLoggerProvider(Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings settings) { }
        public ConsoleLoggerProvider(Microsoft.Extensions.Options.IOptionsMonitor<Microsoft.Extensions.Logging.Console.ConsoleLoggerOptions> options) { }
        public ConsoleLoggerProvider(System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter, bool includeScopes) { }
        public ConsoleLoggerProvider(System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter, bool includeScopes, bool disableColors) { }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string name) { throw null; }
        public void Dispose() { }
        public void SetScopeProvider(Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider) { }
    }
    public partial class ConsoleLoggerSettings : Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings
    {
        public ConsoleLoggerSettings() { }
        public Microsoft.Extensions.Primitives.IChangeToken ChangeToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool DisableColors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IncludeScopes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IDictionary<string, Microsoft.Extensions.Logging.LogLevel> Switches { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings Reload() { throw null; }
        public bool TryGetSwitch(string name, out Microsoft.Extensions.Logging.LogLevel level) { throw null; }
    }
    [System.ObsoleteAttribute("Use LoggerExternalScopeProviderinstead")]
    public partial class ConsoleLogScope
    {
        internal ConsoleLogScope() { }
        public static Microsoft.Extensions.Logging.Console.ConsoleLogScope Current { get { throw null; } set { } }
        public Microsoft.Extensions.Logging.Console.ConsoleLogScope Parent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.IDisposable Push(string name, object state) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial interface IConsoleLoggerSettings
    {
        Microsoft.Extensions.Primitives.IChangeToken ChangeToken { get; }
        bool IncludeScopes { get; }
        Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings Reload();
        bool TryGetSwitch(string name, out Microsoft.Extensions.Logging.LogLevel level);
    }
}
namespace Microsoft.Extensions.Logging.Console.Internal
{
    public partial class AnsiLogConsole : Microsoft.Extensions.Logging.Console.Internal.IConsole
    {
        public AnsiLogConsole(Microsoft.Extensions.Logging.Console.Internal.IAnsiSystemConsole systemConsole) { }
        public void Flush() { }
        public void Write(string message, System.Nullable<System.ConsoleColor> background, System.Nullable<System.ConsoleColor> foreground) { }
        public void WriteLine(string message, System.Nullable<System.ConsoleColor> background, System.Nullable<System.ConsoleColor> foreground) { }
    }
    public partial class ConsoleLoggerProcessor : System.IDisposable
    {
        public Microsoft.Extensions.Logging.Console.Internal.IConsole Console;
        public ConsoleLoggerProcessor() { }
        public void Dispose() { }
        public virtual void EnqueueMessage(Microsoft.Extensions.Logging.Console.Internal.LogMessageEntry message) { }
    }
    public partial interface IAnsiSystemConsole
    {
        void Write(string message);
        void WriteLine(string message);
    }
    public partial interface IConsole
    {
        void Flush();
        void Write(string message, System.Nullable<System.ConsoleColor> background, System.Nullable<System.ConsoleColor> foreground);
        void WriteLine(string message, System.Nullable<System.ConsoleColor> background, System.Nullable<System.ConsoleColor> foreground);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct LogMessageEntry
    {
        public System.Nullable<System.ConsoleColor> LevelBackground;
        public System.Nullable<System.ConsoleColor> LevelForeground;
        public string LevelString;
        public string Message;
        public System.Nullable<System.ConsoleColor> MessageColor;
    }
    public partial class WindowsLogConsole : Microsoft.Extensions.Logging.Console.Internal.IConsole
    {
        public WindowsLogConsole() { }
        public void Flush() { }
        public void Write(string message, System.Nullable<System.ConsoleColor> background, System.Nullable<System.ConsoleColor> foreground) { }
        public void WriteLine(string message, System.Nullable<System.ConsoleColor> background, System.Nullable<System.ConsoleColor> foreground) { }
    }
}
namespace Microsoft.Extensions.Logging.Debug
{
    public partial class DebugLogger : Microsoft.Extensions.Logging.ILogger
    {
        public DebugLogger(string name) { }
        public DebugLogger(string name, System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter) { }
        public System.IDisposable BeginScope<TState>(TState state) { throw null; }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
    }
    [Microsoft.Extensions.Logging.ProviderAliasAttribute("Debug")]
    public partial class DebugLoggerProvider : Microsoft.Extensions.Logging.ILoggerProvider, System.IDisposable
    {
        public DebugLoggerProvider() { }
        public DebugLoggerProvider(System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> filter) { }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string name) { throw null; }
        public void Dispose() { }
    }
}
namespace Microsoft.Extensions.Logging.EventLog
{
    public partial class EventLogLogger : Microsoft.Extensions.Logging.ILogger
    {
        public EventLogLogger(string name) { }
        public EventLogLogger(string name, Microsoft.Extensions.Logging.EventLog.EventLogSettings settings) { }
        public EventLogLogger(string name, Microsoft.Extensions.Logging.EventLog.EventLogSettings settings, Microsoft.Extensions.Logging.IExternalScopeProvider externalScopeProvider) { }
        public Microsoft.Extensions.Logging.EventLog.Internal.IEventLog EventLog { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.IDisposable BeginScope<TState>(TState state) { throw null; }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
    }
    [Microsoft.Extensions.Logging.ProviderAliasAttribute("EventLog")]
    public partial class EventLogLoggerProvider : Microsoft.Extensions.Logging.ILoggerProvider, Microsoft.Extensions.Logging.ISupportExternalScope, System.IDisposable
    {
        public EventLogLoggerProvider() { }
        public EventLogLoggerProvider(Microsoft.Extensions.Logging.EventLog.EventLogSettings settings) { }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string name) { throw null; }
        public void Dispose() { }
        public void SetScopeProvider(Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider) { }
    }
    public partial class EventLogSettings
    {
        public EventLogSettings() { }
        public Microsoft.Extensions.Logging.EventLog.Internal.IEventLog EventLog { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Func<string, Microsoft.Extensions.Logging.LogLevel, bool> Filter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LogName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string MachineName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string SourceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class WindowsEventLog : Microsoft.Extensions.Logging.EventLog.Internal.IEventLog
    {
        public WindowsEventLog(string logName, string machineName, string sourceName) { }
        public System.Diagnostics.EventLog DiagnosticsEventLog { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int MaxMessageSize { get { throw null; } }
        public void WriteEntry(string message, System.Diagnostics.EventLogEntryType type, int eventID, short category) { }
    }
}
namespace Microsoft.Extensions.Logging.EventLog.Internal
{
    public partial interface IEventLog
    {
        int MaxMessageSize { get; }
        void WriteEntry(string message, System.Diagnostics.EventLogEntryType type, int eventID, short category);
    }
}
namespace Microsoft.Extensions.Logging.Internal
{
    public partial class FormattedLogValues : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public FormattedLogValues(string format, params object[] values) { }
        public int Count { get { throw null; } }
        public System.Collections.Generic.KeyValuePair<string, object> this[int index] { get { throw null; } }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LogValuesFormatter
    {
        public LogValuesFormatter(string format) { }
        public string OriginalFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.List<string> ValueNames { get { throw null; } }
        public string Format(object[] values) { throw null; }
        public System.Collections.Generic.KeyValuePair<string, object> GetValue(object[] values, int index) { throw null; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> GetValues(object[] values) { throw null; }
    }
}
namespace Microsoft.Extensions.Logging.TraceSource
{
    public partial class TraceSourceLogger : Microsoft.Extensions.Logging.ILogger
    {
        public TraceSourceLogger(System.Diagnostics.TraceSource traceSource) { }
        public System.IDisposable BeginScope<TState>(TState state) { throw null; }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) { throw null; }
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState, System.Exception, string> formatter) { }
    }
    [Microsoft.Extensions.Logging.ProviderAliasAttribute("TraceSource")]
    public partial class TraceSourceLoggerProvider : Microsoft.Extensions.Logging.ILoggerProvider, System.IDisposable
    {
        public TraceSourceLoggerProvider(System.Diagnostics.SourceSwitch rootSourceSwitch) { }
        public TraceSourceLoggerProvider(System.Diagnostics.SourceSwitch rootSourceSwitch, System.Diagnostics.TraceListener rootTraceListener) { }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string name) { throw null; }
        public void Dispose() { }
    }
    public partial class TraceSourceScope : System.IDisposable
    {
        public TraceSourceScope(object state) { }
        public void Dispose() { }
    }
}
