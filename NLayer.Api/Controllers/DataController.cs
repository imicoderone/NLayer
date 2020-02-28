using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Api.Models;
using NLayer.BLL.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataService _service;
        private readonly IMapper _mapper;

        public DataController(IDataService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<DataViewModel>>(await _service.GetAllAsync()));
        }
    }
}