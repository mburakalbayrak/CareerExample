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

        ////TO:DO must be refactoring
        public T GetValue<T>(string key)
        {
            try
            {
                CareerSettingManager manager = new CareerSettingManager();
                var value = manager.GetValue<T>(key, _applicationName);
                if (value != null)
                {
                    SetDataFile(key, value.ToString());
                }
                return value != null ? value : default(T);
            }
            catch (Exception ex)
            {
                //// Logger excepton
                var data = GetDataFile(key);
                return (T)Convert.ChangeType(data, typeof(T)); 
            }

            // MemoryCache   ICacheProvider   refreshTime = _refreshTimerIntervalInMs
            // write Json file / read Json file
        }

        void SetDataFile(string key, string value)
        {
            //// if exist or equal data
            ////operation
        }

         T GetDataFile<T>(T name)
        {
            T value = name;
            return (T)Convert.ChangeType(value, typeof(T));
        }

    }
}
