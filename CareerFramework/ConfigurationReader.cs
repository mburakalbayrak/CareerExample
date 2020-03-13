using Business.Abstract;
using Business.Concrete;
using Core.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Configuration;
using System.Text;

namespace CareerFramework
{
    public class ConfigurationReader : IConfigurationReader
    {
        private string _applicationName;
        private int _refreshTimerIntervalInMs;
        public ConfigurationReader(string applicationName, string connectionString, int refreshTimerIntervalInMs)
        {
            _applicationName = applicationName;
            ContextRunSettings.ConnectionString = connectionString;
            _refreshTimerIntervalInMs = refreshTimerIntervalInMs;
        }

        ////TO:DO refactor edilmeli
        public T GetValue<T>(string key)
        {
            CareerSettingManager manager = new CareerSettingManager();
            var value = manager.GetValue<T>(key, _applicationName);
            return value != null ? value : default(T);

            // MemoryCache   ICacheProvider
            // write Json file / read Json file
        }

        ////private static string GetAppSetting(string key)
        ////{
        ////    try
        ////    {
        ////        var asmPath = Assembly.GetExecutingAssembly().Location;
        ////        var config = ConfigurationManager.OpenExeConfiguration(asmPath);
        ////        var setting = config.AppSettings.Settings[key];
        ////        return setting.Value;
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        throw new InvalidOperationException("Error reading configuration setting", e);
        ////    }
        ////}

    }
}
