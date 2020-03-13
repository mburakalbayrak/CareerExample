using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Career.UI.Controllers
{
    public class ConfigController : Controller
    {
        private readonly ICareerSettingService _careerSettingService;

        public ConfigController(ICareerSettingService careerSettingService)
        {
            _careerSettingService = careerSettingService;
        }
        public IActionResult Index()
        {
            var list = _careerSettingService.GetList();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CareerSetting model)
        {
            var result = _careerSettingService.Add(model);
            return View();
        }

        public IActionResult Update(int id)
        {
            var config = _careerSettingService.GetById(id);
            return View(config);
        }

        [HttpPost]
        public IActionResult Update(CareerSetting model)
        {
            var result = _careerSettingService.Update(model);
            return View();
        }

        public IActionResult Delete(int id)
        {
            var config = _careerSettingService.GetById(id).Data;
            config.IsDeleted = true;
            var result = _careerSettingService.Update(config);
            return View(config);
        }
    }
}