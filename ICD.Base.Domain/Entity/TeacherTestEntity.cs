using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity;

public class TeacherTestEntity : BaseEntity<int>
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Point { get; set; }
}