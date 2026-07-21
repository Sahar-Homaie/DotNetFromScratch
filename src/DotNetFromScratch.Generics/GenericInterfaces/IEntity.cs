
namespace DotNetFromScratch.Generics.GenericInterfaces
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
