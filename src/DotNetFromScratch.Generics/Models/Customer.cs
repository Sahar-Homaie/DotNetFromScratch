
using DotNetFromScratch.Generics.GenericInterfaces;

namespace DotNetFromScratch.Generics.Models
{
    public class Customer: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
