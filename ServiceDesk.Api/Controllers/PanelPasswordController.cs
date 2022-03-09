using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceDesk.API.Models;
using ServiceDesk.API.Services;

namespace ServiceDesk.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PanelPasswordController : ControllerBase
    {
        private IPanelPasswordService _panelPasswordService;

        public PanelPasswordController(IPanelPasswordService panelPasswordService)
        {
            _panelPasswordService = panelPasswordService;
        }

        [HttpPost("CreatePassword")]
        public async Task GetAlunos([FromBody] PanelModel panelModelViewModel)
        {
            await _panelPasswordService.InsertPanelPassword(panelModelViewModel);

        }

        [HttpGet("GetLastFivePassword")]
        public async Task<ActionResult<IAsyncEnumerable<PanelModel>>> GetLastFivePassword()
        {
            var alunos = await _panelPasswordService.GetLastThreePassword(3);
            return Ok(alunos);
        }
    }
}
