using E_Nak.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace E_Nak.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        #region Fields

        private readonly IVehicleService _vehicleService;

        #endregion


        #region Ctor

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult GetVehicle()
        {
            var vehicles  = _vehicleService.GetVehicles();

            return Ok(vehicles);
        }

        #endregion

    }
}
