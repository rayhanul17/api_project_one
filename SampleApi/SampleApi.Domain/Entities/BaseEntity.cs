namespace SampleApi.Domain.Entities;

public class BaseEntity<T>
{
    public T Id { get; set; }
    public T CreatedBy { get; set; }
    public T ModifiedBy { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ModificationDate { get; set; }
    
}
