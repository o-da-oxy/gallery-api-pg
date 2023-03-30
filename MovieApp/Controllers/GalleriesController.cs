using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Services;

namespace MovieApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GalleriesController : ControllerBase
{
    private readonly GalleryService _galleriesService;

    public GalleriesController(GalleryService galleriesService)
    {
        _galleriesService = galleriesService;
    }
        
    
    [HttpGet]
    public List<Gallery> Get() =>
        _galleriesService.GetAll();
    
    [HttpGet("{id:length(24)}")]
    public ActionResult<Gallery> Get(int id)
    {
        var gallery = _galleriesService.Get(id);

        if (gallery is null)
        {
            return NotFound();
        }

        return gallery;
    }
    
    [HttpPost]
    public IActionResult Post(Gallery newGallery)
    {
        _galleriesService.Create(newGallery);

        return CreatedAtAction(nameof(Get), new { id = newGallery.Id }, newGallery);
    }
    
    [HttpPut("{id:length(24)}")]
    public IActionResult Update(int id, Gallery updatedGallery)
    {
        var gallery = _galleriesService.Get(id);

        if (gallery is null)
        {
            return NotFound();
        }

        updatedGallery.Id = gallery.Id;

        _galleriesService.Update(id, updatedGallery);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(int id)
    {
        var gallery = _galleriesService.Get(id);

        if (gallery is null)
        {
            return NotFound();
        }

        _galleriesService.Remove(id);

        return NoContent();
    }

}