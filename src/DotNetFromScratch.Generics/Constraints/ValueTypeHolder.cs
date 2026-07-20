

namespace DotNetFromScratch.Generics.Constraints
{
    public class ValueTypeHolder<TValue>
        where TValue: struct
    {
        public TValue Value { get; set; }
    }
}
