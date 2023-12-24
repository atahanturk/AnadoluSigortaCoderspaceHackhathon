using BudgiesAPI.Services;
using BudgiesAPI.Services.Impl;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BudgiesAPI.Controllers;

[ApiController]
[Route("api/admin/policies")]
[Authorize(Roles = "Admin")]
public class AdminPolicyController : ControllerBase
{
    private readonly IPolicyAdminService _policyAdminService;

    public AdminPolicyController(IPolicyAdminService policyAdminService)
    {
        _policyAdminService = policyAdminService;
    }

    [HttpGet("requests/health")]
    public async Task<IActionResult> GetAllHealthRequests()
    {
        var requests = await _policyAdminService.GetAllHealthRequestsAsync();
        return Ok(requests);
    }

    [HttpPost("approve/health/{requestId}")]
    public async Task<IActionResult> ApproveHealthRequest(int requestId)
    {
        try
        {
            await _policyAdminService.ApproveHealthRequestAsync(requestId);
            return Ok();
        }
        catch (KeyNotFoundException)
        {
            return NotFound("Request not found");
        }
    }
    
    [HttpGet("requests/pet")]
    public async Task<IActionResult> GetAllPetRequests()
    {
        var requests = await _policyAdminService.GetAllPetRequestsAsync();
        return Ok(requests);
    }

    [HttpPost("approve/pet/{requestId}")]
    public async Task<IActionResult> ApprovePetRequest(int requestId)
    {
        try
        {
            await _policyAdminService.ApprovePetRequestAsync(requestId);
            return Ok();
        }
        catch (KeyNotFoundException)
        {
            return NotFound("Request not found");
        }
    }

    [HttpGet("requests/home")]
    public async Task<IActionResult> GetAllHomeRequests()
    {
        var requests = await _policyAdminService.GetAllHomeRequestsAsync();
        return Ok(requests);
    }

    [HttpPost("approve/home/{requestId}")]
    public async Task<IActionResult> ApproveHomeRequest(int requestId)
    {
        try
        {
            await _policyAdminService.ApproveHomeRequestAsync(requestId);
            return Ok();
        }
        catch (KeyNotFoundException)
        {
            return NotFound("Request not found");
        }
    }

    

    // Home ve Pet için benzer endpoint'ler...
}
