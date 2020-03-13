using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CareerSettingManager : ICareerSettingService
    {
        private ICareerSettingDal _CareerConfigDal;

        public CareerSettingManager()
        {

        }
        public CareerSettingManager(ICareerSettingDal CareerConfigDal)
        {
            _CareerConfigDal = CareerConfigDal;
        }
        public IResult Add(CareerSetting CareerConfig)
        {
            _CareerConfigDal.Add(CareerConfig);
            return new SuccessResult(Messages.CareerConfigAdded);
        }
        public IResult Delete(CareerSetting CareerConfig)
        {
            _CareerConfigDal.Delete(CareerConfig);
            return new SuccessResult(Messages.CareerConfigDeleted);
        }
        public IDataResult<CareerSetting> GetById(int CareerConfigId)
        {
            return new SuccessDataResult<CareerSetting>(_CareerConfigDal.Get(p => p.Id == CareerConfigId));
        }
        public IDataResult<List<CareerSetting>> GetList()
        {
            return new SuccessDataResult<List<CareerSetting>>(_CareerConfigDal.GetList(c => !c.IsDeleted && c.IsActive).ToList());
        }
        public IDataResult<List<CareerSetting>> GetListByApplicationName(string applicationName, string connectionString, int refreshTimerIntervalInMs)
        {
            return new SuccessDataResult<List<CareerSetting>>(_CareerConfigDal.GetList(c => !c.IsDeleted && c.IsActive && c.ApplicationName.Equals(applicationName)).ToList());
        }
        public IResult Update(CareerSetting CareerConfig)
        {
            _CareerConfigDal.Update(CareerConfig);
            return new SuccessResult(Messages.CareerConfigUpdated);
        }
        public T GetValue<T>(string name, string appName)
        {
            var config = _CareerConfigDal.Get(c => c.Name.Equals(name) && c.IsActive && c.IsDeleted && c.ApplicationName.Equals(appName));


            return !string.IsNullOrEmpty(config.Value) ? (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(config.Value) : default(T);
        }
    }
}
