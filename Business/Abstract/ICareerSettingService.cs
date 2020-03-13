using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICareerSettingService
    {
        IDataResult<CareerSetting> GetById(int careerConfigId);

        IDataResult<List<CareerSetting>> GetList();

        IResult Add(CareerSetting careerSetting);
        IResult Delete(CareerSetting careerSetting);

        IResult Update(CareerSetting careerSetting);
    }
}
