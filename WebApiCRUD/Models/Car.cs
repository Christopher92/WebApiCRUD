using System.ComponentModel.DataAnnotations;

namespace WebApiCRUD.Models
{
    public class Car
    {
        public int Id { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
