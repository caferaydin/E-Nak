using E_Nak.Application.Abstract.Repositories.Read;
using E_Nak.Application.Abstract.Repositories.Write;
using E_Nak.Application.Abstract.Service;
using E_Nak.Application.ViewModel.Request;
using E_Nak.Domain.Entities.Transport;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace E_Nak.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportsController : ControllerBase
    {
        #region Field
        readonly private ITransportService _transportService;
        readonly private ITransportReadRepository _transportReadRepository;
        readonly private ITransportWriteRepository _transportWriteRepository;
        #endregion

        #region Ctor
        public TransportsController(ITransportService transportService, ITransportReadRepository transportReadRepository, ITransportWriteRepository transportWriteRepository)
        {
            _transportService = transportService;
            _transportReadRepository = transportReadRepository;
            _transportWriteRepository = transportWriteRepository;
        }
        #endregion

        #region Method

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_transportReadRepository.GetAll(false));
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_transportReadRepository.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(TransportCreateRequest createTransport)
        {
            await _transportWriteRepository.AddAsync(new()
            {
                VehicleType = createTransport.VehicleType,
                LoadType = createTransport.LoadType,
                LoadProvince = createTransport.LoadProvince,
                LoadDistrict = createTransport.LoadDistrict,
                UnloadProvience = createTransport.UnloadProvience,
                UnloadDistrict = createTransport.UnloadDistrict,
                PolicyNumber = createTransport.PolicyNumber,
                LoadDate = createTransport.LoadDate,
                LoadDeliveryDate = createTransport.LoadDeliveryDate,
            });
            await _transportWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(TransportUpdateRequest updated)
        {
            Transport transport = await _transportReadRepository.GetByIdAsync(updated.id);
            transport.VehicleType = updated.VehicleType;
            transport.LoadType = updated.LoadType;
            transport.LoadProvince = updated.LoadProvince;
            transport.LoadDistrict  = updated.LoadDistrict;
            transport.UnloadProvience = updated.UnloadProvience;
            transport.UnloadDistrict = updated.UnloadDistrict;
            transport.PolicyNumber = updated.PolicyNumber;
            transport.LoadDate = updated.LoadDate;
            transport.LoadDeliveryDate = updated.LoadDeliveryDate;
            await _transportWriteRepository.SaveAsync();

            return Ok(transport);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _transportWriteRepository.RemoveAsync(id);
            await _transportWriteRepository.SaveAsync();

            return Ok();
        }
        #endregion
    }
}
