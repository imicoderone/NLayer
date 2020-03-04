using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Api.Models;
using NLayer.BLL.Services;
using NLayer.BLL.DTOs;
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
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(_mapper.Map<IEnumerable<DataViewModel>>(await _service.GetAllAsync()));
        }

        [HttpGet, Route("Archived")]
        public async Task<IActionResult> GetArchivedAsync()
        {
            return Ok(_mapper.Map<IEnumerable<DataViewModel>>(await _service.GetArchivedAsync()));
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] string id)
        {
            return Ok(_mapper.Map<DataViewModel>(await _service.GetByIdAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateDataModel model)
        {
            var dto = await _service.CreateAsync(_mapper.Map<DataDTO>(model));
            return Ok(_mapper.Map<DataViewModel>(dto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateDataModel model)
        {
            var dto = await _service.UpdateAsync(_mapper.Map<DataDTO>(model));
            return Ok(_mapper.Map<DataViewModel>(dto));
        }

        [HttpDelete, Route("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] string id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}