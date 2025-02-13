namespace Demo.Data;

[InterfaceType]
public class Publication
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int AuthorId { get; set; }

    [Required]
    public string? Title { get; set; }

    public virtual Author? Author { get; set; }
}