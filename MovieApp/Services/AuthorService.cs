using MovieApp.Data;

namespace MovieApp.Services;

public class AuthorService
{
    private readonly GalleryDataContext context;

    public AuthorService(GalleryDataContext context)
    {
        this.context = context;
    }

    public List<Author> GetAll()
    {
        return context.Authors.ToList();
    }

    public Author Get(int id)
    {
        return context.Authors.SingleOrDefault(x => x.Id == id);
    }

    public void Create(Author newAuthor)
    {
        context.Authors.AddAsync(newAuthor);
        context.SaveChanges();
    }

    public void Update(int id, Author updatedAuthor)
    {
        updatedAuthor.Id = id;
        context.Authors.Update(updatedAuthor);
        context.SaveChanges();
    }

    public void Remove(int id)
    {
        context.Authors.Remove(Get(id));
        context.SaveChanges();
    }
}