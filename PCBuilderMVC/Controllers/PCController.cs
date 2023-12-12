using Microsoft.AspNetCore.Mvc;
using PCBuilder.Service.Interfaces;
using PCBuilderMVC.Domain.ViewModels;
using PCBuilderMVC.Models;

namespace PCBuilderMVC.Controllers
{
    public class PCController : Controller
    {
        private readonly IPCService _service;

        public PCController(IPCService service)
        {
            _service = service;
        }

        public async Task<IActionResult> ShowAll()
        {
            var response = await _service.GetAll();

            if (response.StatusCode == Domain.Enums.StatusCode.Ok)
            {
                return View(response.Data.ToList());
            }

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PCViewModel pcView)
        {
            if (ModelState.IsValid)
            {
                _service.CreatePC(pcView);
            }
            else
            {
                throw new Exception();
            }

            return View(pcView);
        }

        [HttpGet]
        public async Task<IActionResult> FullPCPage()
        {
            var response = await _service.GetById(5);

            return View(response.Data);
        }

        [HttpGet]
        public IActionResult Input()
        {
            return View();
        }

        /*[HttpGet]
        public async Task<IActionResult> FullPCPage(int id)
        {
            var response = await _service.GetById(id);

            if (response.StatusCode == Domain.Enums.StatusCode.Ok)
                return View(response.Data);
            else
                return StatusCode((int)response.StatusCode);
        }*/
    }
}
