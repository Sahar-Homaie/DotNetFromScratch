

namespace DotNetFromScratch.Generics.Constraints
{
    public class ReferenceTypeCache<TValue>
        where TValue: class
    {
        private TValue? _cachedValue;
        public void CacheData(TValue data)
        {
            _cachedValue = data;
        }
        public TValue? GetCachedValue()
        {
            return _cachedValue;
        }
    }
}
