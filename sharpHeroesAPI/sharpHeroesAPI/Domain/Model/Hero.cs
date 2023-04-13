using System.ComponentModel.DataAnnotations;

namespace sharpHeroesAPI.Model;

public class Hero {
    [Key]
    [Required(ErrorMessage = "Id is required")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    
    public string RealName { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "The Age must be greater than 1!!")]
    public int? Age { get; set; }
    
    [Required(ErrorMessage = "Power is required")]
    public string Power { get; set; }
    
    [Required(ErrorMessage = "Retired status is required")]
    public bool isRetired { get; set; }
}
