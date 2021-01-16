namespace CampIntro
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoriId { get; set; }

        public Product(int ıd, string name, int price, int catId)
        {
            Id = ıd;
            Name = name;
            Price = price;
            CategoriId = catId;
        }
    }
}
