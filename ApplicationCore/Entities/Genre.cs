using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Genre
{
    public int Id { get; set; }
    [Required (ErrorMessage ="Genre name is required")]
    public string Name { get; set; }
}