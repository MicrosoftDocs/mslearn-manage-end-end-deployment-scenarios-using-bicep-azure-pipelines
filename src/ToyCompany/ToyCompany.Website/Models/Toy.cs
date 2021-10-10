using System.ComponentModel.DataAnnotations;

namespace ToyCompany.Website.Models
{
    public class Toy
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
