using Categories.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }

    [ForeignKey(nameof(IdCategory))]
    public int IdCategory { get; set; }

    
}
