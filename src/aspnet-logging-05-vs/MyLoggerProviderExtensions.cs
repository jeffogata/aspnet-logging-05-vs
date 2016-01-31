namespace aspnet_logging_05_vs
{
    using Microsoft.Extensions.Logging;

    public static class MyLoggerProviderExtensions
    {
        public static ILoggerFactory AddMyLogger(this ILoggerFactory loggerFactory, string basePath)
        {
            loggerFactory.AddProvider(new MyLoggerProvider(basePath));

            return loggerFactory;
        }
    }
}