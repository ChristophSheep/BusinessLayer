using Library;

namespace Business.Objects.BaseObjects
{
    public abstract class ObjectWithGeometry : BaseObject
    {
        protected ObjectWithGeometry() { }

        public Geometry Geometry { get; set; }
    }
}