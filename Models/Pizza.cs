namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {

        public int PizzaId { get; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgPath { get; set; }
        public decimal? Price { get; set; }

        public Pizza( int id ,string name, string description, string imgpath, decimal price) {
            Name = name;
            Description = description;
            ImgPath = imgpath;
            Price = price;
            PizzaId = id;
        }
    }
}