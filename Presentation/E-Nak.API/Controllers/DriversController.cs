using E_Nak.Application.Abstract.Service.PeopleInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Nak.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        #region Field
        readonly private IDriveService _driveService;

        #endregion

        #region Ctor
        public DriversController(IDriveService driveService)
        {
            _driveService = driveService;
        }
        #endregion

        [HttpGet]
        public IActionResult Get()
        {
            var drive = _driveService.GetDrives();
            return Ok(drive);
        }
    }
}
