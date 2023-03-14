namespace SchoolManagement.Models
{
    public interface IBaseModel
    {
        int Id { get; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}