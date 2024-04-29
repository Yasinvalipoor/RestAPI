using Microsoft.EntityFrameworkCore;

namespace RestAPI.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public Brand brand { get; set; }

        public int BrandId { get; set; }
    }
}
