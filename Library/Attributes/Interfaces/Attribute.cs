namespace Library.Attributes.Interfaces
{
    public interface Attribute<T>
    {
        bool HasValue { get; set; }
        T Value { get; set; }
        int AttributeTypeId { get; set; }
    }
}