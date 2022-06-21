using FinanceiroAPI._2._0.Services.CargoServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceiroAPI._2._0.Controllers
{

    [Route("[controller]/[action]")]
    public class CargoController : Controller
    {
        private readonly ICargoServices _cargoServices;

        public CargoController(ICargoServices cargoServices)
        {
            _cargoServices = cargoServices;
        }

        [HttpGet,Authorize]
        public IActionResult GetAll()
        {
            var list =  _cargoServices.GetAll();

            return new ObjectResult(list);
        }

        [Authorize]
        [HttpGet]
        public JsonResult GetById()
        {
            return null;
        }

        [Authorize]
        [HttpGet]
        public JsonResult GetByName()
        {
            return null;
        }

        [Authorize]
        [HttpPost]
        public JsonResult Create()
        {
            return null;
        }

        [Authorize]
        [HttpPost]
        public JsonResult Update()
        {
            return null;
        }

        [Authorize]
        [HttpDelete]
        public JsonResult Delete()
        {
            return null;
        }
    }
}
