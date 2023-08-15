namespace Core.Persistence.Dynamic;

public class Filter
{
    public string Field { get; set; }
    public string? Value { get; set; }
    public string Operator { get; set; }
    public string? Logic { get; set; }

    public IEnumerable<Filter>? Filters { get; set; }

    public Filter()
    {
        Field = String.Empty;
        Operator = String.Empty;

    }

    public Filter(string field, string @operator)
    {
        field = Field;
        Operator = @operator;
    }
}