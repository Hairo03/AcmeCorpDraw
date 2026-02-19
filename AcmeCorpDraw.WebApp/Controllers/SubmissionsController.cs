using AcmeCorpDraw.Domain.DTOs;
using AcmeCorpDraw.Domain.Interfaces;
using AcmeCorpDraw.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmeCorpDraw.WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubmissionsController : ControllerBase
{
    private readonly ISubmissionService _submissionService;
    private const int PAGESIZE = 10;

    public SubmissionsController(ISubmissionService submissionService)
    {
        _submissionService = submissionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IEnumerable<Submission> submissions = await _submissionService.GetAllSubmissionsAsync();
        return Ok(submissions);
    }

    [HttpGet("page/{pageNumber}")]
    public async Task<IActionResult> GetPage(int pageNumber)
    {
        IEnumerable<Submission> submissions = await _submissionService.GetAllSubmissionsAsync();
        
        IEnumerable<Submission> pagedResult = submissions
            .Skip((pageNumber - 1) * PAGESIZE)
            .Take(PAGESIZE);

        return Ok(pagedResult);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        Submission submission = await _submissionService.GetSubmissionByIdAsync(id);
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

    [HttpGet("count")]
    public async Task<IActionResult> GetCount()
    {
        int count = await _submissionService.GetSubmissionCountAsync();
        return Ok(count);
    }

    [HttpGet("count/{serialNumber}")]
    public async Task<IActionResult> CountBySerial(string serialNumber)
    {
        int count = await _submissionService.GetSubmissionCountBySerialAsync(serialNumber);
        return Ok(count);
    }
}