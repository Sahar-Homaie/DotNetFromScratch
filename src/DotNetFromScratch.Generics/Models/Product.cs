

using DotNetFromScratch.Generics.GenericInterfaces;

namespace DotNetFromScratch.Generics.Models
{
    public class Product: IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
