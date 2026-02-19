using AcmeCorpDraw.Domain.DTOs;
using AcmeCorpDraw.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AcmeCorpDraw.WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubmissionsController : ControllerBase
{
    private readonly ISubmissionService _submissionService;

    public SubmissionsController(ISubmissionService submissionService)
    {
        _submissionService = submissionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var submissions = await _submissionService.GetAllSubmissionsAsync();
        return Ok(submissions);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var submission = await _submissionService.GetSubmissionByIdAsync(id);
        return submission != null ? Ok(submission) : NotFound(new { error = "Submission not found." });
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SubmissionDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _submissionService.CreateSubmissionAsync(dto);
        
        if (!result.Success)
            return BadRequest(new { error = result.ErrorMessage });

        return CreatedAtAction(nameof(GetById), 
            new { id = result.Submission.Id }, 
            new { success = result.Success, submission = result.Submission, errorMessage = result.ErrorMessage });
    }

    [HttpGet("count/{serialNumber}")]
    public async Task<IActionResult> CountBySerial(string serialNumber)
    {
        var count = await _submissionService.GetSubmissionCountBySerialAsync(serialNumber);
        return Ok(count);
    }
}