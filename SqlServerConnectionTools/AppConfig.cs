using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SqlServerConnectionTools
{
    public class AppConfig
    {
        private const string ConfigName = "SqlServerConnectionToolsSettings.config";
        private static AppConfig _instance;
        public static AppConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = AppConfig.LoadConfig();
                }
                return _instance;
            }
        }

        public AppConfig()
        {
            DataSources = new List<string>();
            ConnectionStrings = new List<string>();
        }

        public List<string> DataSources { get; set; }

        public List<string> ConnectionStrings { get; set; }



        private static AppConfig LoadConfig()
        {
            if (File.Exists(ConfigName))
                try
                {
                    var xml = new XmlSerializer(typeof(AppConfig));
                    using (var file = File.OpenRead(ConfigName))
                    {
                        var config = (AppConfig)xml.Deserialize(file);
                        if (config != null)
                            return config;
                    }
                }
                catch { }

            return new AppConfig();
        }

        public void SaveConfig()
        {
            try
            {
                var xml = new XmlSerializer(typeof(AppConfig));
                using (var file = File.OpenWrite(ConfigName))
                {
                    xml.Serialize(file, this);
                }
            }
            catch (Exception)
            {
            }
        }
    }

    public static class ExtentionMethods
    {
        public static void AddIfNotExisted(this List<string> list, string item)
        {
            if (!list.Contains(item))
                list.Add(item);
        }
        public static void AddIfNotExisted(this List<string> list, IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                if (!list.Contains(item))
                    list.Add(item);
            }
        }

    }
}
