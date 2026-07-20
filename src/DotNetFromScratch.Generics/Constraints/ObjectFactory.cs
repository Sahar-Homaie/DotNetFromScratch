

namespace DotNetFromScratch.Generics.Constraints
{
    public class ObjectFactory<TItem>
        where TItem: new()
    {
        public TItem CreateItem()
        {
            return new TItem();
        }
    }
}
