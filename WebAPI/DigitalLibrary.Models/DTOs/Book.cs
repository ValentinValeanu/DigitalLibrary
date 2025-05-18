namespace DigitalLibrary.Models.DTOs
{
    public record Book : BookInput
    {
        public required int Id { get; set; }
    }
}
