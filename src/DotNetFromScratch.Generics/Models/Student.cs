using DotNetFromScratch.Generics.Constraints;


namespace DotNetFromScratch.Generics.Models
{
    public class Student: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
