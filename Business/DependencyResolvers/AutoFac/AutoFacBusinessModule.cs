using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Configuration;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfCareerSettingDal>().As<ICareerSettingDal>();
            builder.RegisterType<CareerSettingManager>().As<ICareerSettingService>();

        }
    }
}
