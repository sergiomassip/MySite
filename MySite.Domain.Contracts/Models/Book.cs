namespace MySite.Domain.Contracts.Models
{

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }       
        public string Edition { get; set; }
        public string Volume { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
