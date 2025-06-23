using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiniInventoryManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public required CategoryName Category { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 1000000, ErrorMessage = "Price must be between 0.01 and 100000")]
        public float Price { get; set; }

        [Range(0, 10000, ErrorMessage = "Quantity must be between 0 and 10,000")]
        public int Quantity { get; set; }
    }

    public enum CategoryName
    {
        Electronics,
        Clothing,
        Beauty,
        Food,
        Book,
        Health,
        Tools
    }
}
