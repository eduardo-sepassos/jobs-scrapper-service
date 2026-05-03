using JobScrapper.Application.UseCases.JobScrapping;
using Microsoft.AspNetCore.Mvc;

namespace JobsScrapper.Api.Controllers;

[ApiController]
[Route("api/jobs")]
public class JobsController : ControllerBase
{
    private readonly IJobScrapping _jobScrapping;

    public JobsController(IJobScrapping jobScrapping)
    {
        _jobScrapping = jobScrapping;
    }

    [HttpPost("process")]
    public async Task<IActionResult> Process()
    {
        try
        {
            await _jobScrapping.ExecuteAsync();
            return Ok("Job scrapping process started successfully.");
        }
        catch (Exception ex)
        {
            return UnprocessableEntity($"An error occurred while starting the job scrapping process: {ex.Message}");
        }
    }
}
