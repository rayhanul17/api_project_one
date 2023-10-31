namespace SampleApi.Domain.Entities;

public class User : BaseEntity<Guid>
{    
    public string FullName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
