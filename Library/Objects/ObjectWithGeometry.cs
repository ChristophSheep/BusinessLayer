using Library;

namespace Business.Objects.BaseObjects
{
    public abstract class ObjectWithGeometry : ObjectWithAttributes
    {
        public GeometryAttribute Geometry { get; set; }
    }
}