
namespace WeatherViewer.WebApi.Extensions
{
    public static class SqlMiniProfilerExtensions
    {
        public static void AddSqlMiniProfilerServices(this IServiceCollection services)
        {
            //services.AddMiniProfiler(
            //  options =>
            //  {
            //      // (Optional) Path to use for profiler URLs, default is /mini-profiler-resources
            //      options.RouteBasePath = "/profiler";
            //      (options.Storage as MemoryCacheStorage).CacheDuration = TimeSpan.FromMinutes(60);
            //      // (Optional) Control which SQL formatter to use, InlineFormatter is the default
            //      options.SqlFormatter = new StackExchange.Profiling.SqlFormatters.InlineFormatter();
            //  }).AddEntityFramework();
        }

    }
}
