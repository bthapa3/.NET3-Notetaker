using System.ComponentModel.DataAnnotations;

public class Note
{
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }

}
