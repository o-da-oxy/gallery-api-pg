using MovieApp.Data;

namespace MovieApp.Services;

public class GalleryService
{
    private readonly GalleryDataContext context;

    public GalleryService(GalleryDataContext context)
    {
        this.context = context;
    }

    public List<Gallery> GetAll()
    {
        return context.Galleries.ToList();
    }

    public Gallery Get(int id)
    {
        return context.Galleries.SingleOrDefault(x => x.Id == id);
    }

    public void Create(Gallery newGallery)
    {
        context.Galleries.AddAsync(newGallery);
        context.SaveChanges();
    }

    public void Update(int id, Gallery updatedGallery)
    {
        updatedGallery.Id = id;
        context.Galleries.Update(updatedGallery);
        context.SaveChanges();
    }

    public void Remove(int id)
    {
        context.Galleries.Remove(Get(id));
        context.SaveChanges();
    }
}