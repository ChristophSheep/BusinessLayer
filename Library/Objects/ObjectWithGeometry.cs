using Library;

namespace Business.Objects.BaseObjects
{
    public abstract class ObjectWithGeometry : ObjectWithAttributes
    {
        public Geometry GeometryAttribute { get; set; }
    }
}