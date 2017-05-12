using Library;

namespace Business.Objects.BaseObjects
{
    public class BaseObjectWithGeometry : BaseObject
    {
        protected BaseObjectWithGeometry() { }
        public Geometry Geometry { get; set; }
    }
}