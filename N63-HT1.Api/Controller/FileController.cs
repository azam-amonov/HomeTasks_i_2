using Microsoft.AspNetCore.Mvc;
using N63_HT1.Api.Model;
using N63_HT1.Api.Service;

namespace N63_HT1.Api.Controller;

[ApiController]
[Route("/api/[controller]")]

public class FileController : ControllerBase
{
    private FileService _fileService;

    public FileController(FileService fileService)
    {
        _fileService = fileService;
    }

    [HttpPost]
    public async ValueTask<IActionResult> Upload([FromForm] StorageFile storageFile)
    {
        await _fileService.Upload(storageFile);
        return Ok();
    }

    [HttpDelete]
    private async ValueTask<IActionResult> Delete([FromForm] StorageFile storageFile)
    {
        await _fileService.Delete(storageFile);
        return Ok();
    }
    
}