using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Services;

namespace MovieApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorsController : ControllerBase
{
    private readonly AuthorService _authorService;

    public AuthorsController(AuthorService authorService)
    {
        _authorService = authorService;
    }
    
    [HttpGet]
    public List<Author> Get() =>
        _authorService.GetAll();
    
    [HttpGet("{id:length(24)}")]
    public ActionResult<Author> Get(int id)
    {
        var gallery = _authorService.Get(id);

        if (gallery is null)
        {
            return NotFound();
        }

        return gallery;
    }
    
    [HttpPost]
    public IActionResult Post(Author newGallery)
    {
        _authorService.Create(newGallery);

        return CreatedAtAction(nameof(Get), new { id = newGallery.Id }, newGallery);
    }
    
    [HttpPut("{id:length(24)}")]
    public IActionResult Update(int id, Author updatedGallery)
    {
        var gallery = _authorService.Get(id);

        if (gallery is null)
        {
            return NotFound();
        }

        updatedGallery.Id = gallery.Id;

        _authorService.Update(id, updatedGallery);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(int id)
    {
        var gallery = _authorService.Get(id);

        if (gallery is null)
        {
            return NotFound();
        }

        _authorService.Remove(id);

        return NoContent();
    }
}