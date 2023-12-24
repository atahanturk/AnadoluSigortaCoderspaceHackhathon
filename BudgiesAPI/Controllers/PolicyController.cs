using BudgiesAPI.DTO;
using BudgiesAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BudgiesAPI.Controllers;

[ApiController]
[Route("api/policies")]
public class PolicyController : ControllerBase
{
    private readonly IPolicyRequestService _policyRequestService;

    public PolicyController(IPolicyRequestService policyRequestService)
    {
        _policyRequestService = policyRequestService;
    }

    [HttpPost("health/request"),Authorize]
    public async Task<IActionResult> RequestHealthPolicy([FromBody] HealthRequestDto dto)
    {
        var request = await _policyRequestService.CreateHealthRequestAsync(dto);
        return Ok(request);
    }
    
    [HttpPost("pet/request"), Authorize]
    public async Task<IActionResult> RequestPetPolicy([FromBody] PetRequestDto dto)
    {
        var request = await _policyRequestService.CreatePetRequestAsync(dto);
        return Ok(request);
    }

    [HttpPost("home/request"), Authorize]
    public async Task<IActionResult> RequestHomePolicy([FromBody] HomeRequestDto dto)
    {
        var request = await _policyRequestService.CreateHomeRequestAsync(dto);
        return Ok(request);
    }


    
}
