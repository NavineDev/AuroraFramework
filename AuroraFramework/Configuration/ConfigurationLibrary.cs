using AuroraFramework.Configuration.Types;

namespace AuroraFramework.Configuration
{
    public class ConfigurationLibrary
    {
        public DatabaseConfiguration DatabaseConfiguration { get; private set; }

        public ConfigurationLibrary()
        {
            DatabaseConfiguration = new DatabaseConfiguration();
        }
    }
}
