
namespace TodoBE;
public class TodoItem
{
    public int id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public string? List { get; set; }
}