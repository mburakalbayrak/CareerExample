using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCareerSettingDal : EfEntitiyRepositoryBase<CareerSetting, CareerContext>, ICareerSettingDal
    {
    }
}
