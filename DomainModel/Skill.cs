using System.ComponentModel.DataAnnotations;

namespace DomainModel;

public class Skill
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public string Name { get; set; } = null!;
}