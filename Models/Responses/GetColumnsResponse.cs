namespace Aurora.Models.Responses
{
    public class GetColumnsResponse
    {
        public string Identifier { get; set; }
        public List<Column> Columns { get; set; }
    }

    public class Column
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool isNullable { get; set; }
    }
}
