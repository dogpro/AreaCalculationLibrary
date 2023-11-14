namespace AreaCalculationLibrary
{
    public abstract class IShape
    {
        public abstract double Area();

        protected abstract bool IsValid();
    }
}