using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Salama.Helper;
using Salama.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Salama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _IConfiguration;
        public HomeController(ILogger<HomeController> logger, IConfiguration iConfiguration)
        {
            _IConfiguration = iConfiguration;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                Setup setup = new Setup();
                setup = await SqlHelper.GetSetupData(_IConfiguration);
                return View(setup);
            }
            catch (Exception ex)
            {
                // In case of sql connection Issue data filled 
                Setup setup = new Setup();
                setup.CarBodyTypeList.AddRange(SetupData.getCarBodyTypeList());
                setup.CarModelList.AddRange(SetupData.getCarModelList());
                setup.CarMakeList.AddRange(SetupData.getCarMakeList());
                setup.TrimList.AddRange(SetupData.getTrimList());

                return View(setup);
            }
          
        }

        public IActionResult Benefits()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
