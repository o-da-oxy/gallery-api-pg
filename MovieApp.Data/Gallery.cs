using System.ComponentModel.DataAnnotations;

namespace MovieApp.Data
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public int MaxPicturesCount { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GalleryId { get; set; }
    }
    
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int AuthorId { get; set; }
    }
}
