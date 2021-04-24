using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoAPI.Core;

namespace ProjetoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargosController : ControllerBase
    {
        private readonly ICargoService _cargoService;
        public CargosController(ICargoService cargoService)
        {
            _cargoService = cargoService;
        }

        [HttpGet]
        public IActionResult GetCargos() {
            return Ok(_cargoService.GetCargos());
        }

        [HttpPost]
        public IActionResult AddCargo(Cargo cargo) {
            _cargoService.AddCargo(cargo);
            return Ok(cargo);
        }

    }
}
