using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AuroraFramework.Configuration
{
    public abstract class BaseConfiguration
    {
        private readonly string filePath;
        private JObject jsonSettings;

        protected BaseConfiguration(string filePath)
        {
            this.filePath = filePath;
            ReadFile();
        }

        private void ReadFile()
        {
            StreamReader reader = new StreamReader(filePath);

            jsonSettings = JsonConvert.DeserializeObject<JObject>(reader.ReadToEnd());
        }

        protected T Get<T>(string key)
        {
            return jsonSettings[key].Value<T>();
        }
    }
}
