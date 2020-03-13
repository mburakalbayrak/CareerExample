using System;
using System.Collections.Generic;
using System.Text;

namespace CareerFramework
{
    public interface IConfigurationReader
    {
        T GetValue<T>(string key);
    }
}
