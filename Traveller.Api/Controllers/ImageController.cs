using Microsoft.AspNetCore.Mvc;
using Traveller.Domain;
using Traveller.Domain.Models;
using Traveller.Dtos;
using Traveller.Services;

namespace Traveller.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
    private readonly Repositories _repositories;

    private readonly ILogger<HotelController> _logger;

    private readonly FileService _fileService;

    public FileController(Repositories repositories, ILogger<HotelController> logger, FileService fileService)
    {
        _repositories = repositories;
        _logger = logger;
        _fileService = fileService;
    }
    
    [HttpPost]
    public async Task<IActionResult> UploadFile(IFormFile? file)
    {
        try
        {
            if (file is null || file.Length == 0)
            {
                return BadRequest(" File not selected");
            }

            var path = await _fileService.SaveFileAsync(file, file.FileName);
            var image = new Image { ImagePath = path };
            await _repositories.Images.AddAsync(image);
            await _repositories.Images.SaveChangesAsync();
            return Ok(image.Id);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        try
        {
            var dbImage = await _repositories.Images.FindById(id);
            if (dbImage is null)
            {
                return NotFound($"Image with id {id} doesn't exist");
            }

            _fileService.DeleteFile(dbImage.ImagePath);

            await _repositories.Images.Remove(dbImage.Id);
            await _repositories.Images.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get([FromRoute] int id)
    {
        try
        {
            var dbImage = await _repositories.Images.FindById(id);
            if (dbImage is null)
            {
                return NotFound($"Image with id {id} doesn't exist");
            }
            var fileDto = new FileDto { Id = id, FileData = _fileService.GetFile(dbImage.ImagePath) };
            return Ok(fileDto);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}