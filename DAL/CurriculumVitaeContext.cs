using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class CurriculumVitaeContext: DbContext
{
    public CurriculumVitaeContext(DbContextOptions<CurriculumVitaeContext> options) : base(options)
    {
    }
    public DbSet<Skill> Skills { get; set; } = null!;
    
}