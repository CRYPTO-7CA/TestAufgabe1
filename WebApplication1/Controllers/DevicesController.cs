using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class DevicesController : Controller
    {
        public IEnumerable<Device> Devices { get; set; }
        private readonly AppDbContext _db;
        public DevicesController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            
            var devices = new List<Device>
            {
                new Device {id = "1glmLrTZqf9YZleN", name = "S7-150009", deviceTypeId = "Beweis", failsafe = true},
                new Device {id = "2346dsqf9YZxg4kk", name = "S7-1502-RevA", deviceTypeId = "ABC", failsafe = false},
                new Device {id = "yyyyLr12349Yxxxx", name = "S7-1502-RevB", deviceTypeId = "XYZ", failsafe = true}
            };
            var viewModel = new DevicesViewModel
            {
                Devices = devices
            };

            return View(viewModel);
        }

        public IActionResult Device()
        {
            var device = new Device() {
                id = "1glmLrTZqf9YZleN",
                name = "S7-150009",
                failsafe = true,
                deviceTypeId = "Beweis",
                tempMin = 0,
                tempMax = 60,
                installationPosition = "horizontal"
            };
            return View(device);
        }

        #region APIs
        /*
        public async Task OnGet()
        {
            Devices = await _db.Devices.ToListAsync();
        }
        */

        [HttpGet]
        public async Task<IActionResult> GetAllDevices()
        {
            return Json(new { data = await _db.Devices.ToListAsync() });
        }
        
        #endregion

    }
}
