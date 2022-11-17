using Petshop.Shared.Configurations;

namespace Petshop.Configurations
{
    public static class ExtensionsConfig
    {
        public static ApplicationConfig LoadApplicationConfigurations(this IConfiguration configuration)
        {
            var applicationConfig = configuration.Get<ApplicationConfig>();
            return applicationConfig;
        }
    }
}
