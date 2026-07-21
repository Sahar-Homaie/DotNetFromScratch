using DotNetFromScratch.Generics.Constraints;
using DotNetFromScratch.Generics.GenericClasses;
using DotNetFromScratch.Generics.GenericInterfaces;
using DotNetFromScratch.Generics.GenericMethods;
using DotNetFromScratch.Generics.Models;




#region --------------------------- GenericMethods --------------------------------------
var genericMethods = new GenericMethods();

genericMethods.PrintValue("Sahar");
genericMethods.PrintValue(12);
genericMethods.PrintValue(18.5);


var first = 10;
var second = 20;
genericMethods.Swap(ref first, ref second);
Console.WriteLine($"first {first} and second {second}");

Student student1 = new Student { Name = "Sahar" };
Student student2 = new Student { Name = "Maryam" };
genericMethods.Swap(ref student1, ref student2);
Console.WriteLine($"first {student1.Name} and second {student2.Name}");
#endregion


#region --------------------------- GenericClasses--------------------------------------
var workWithValue = new WorkWithValue<int>();
 workWithValue.GetValue(10);
int number = workWithValue.ReturnValue();
Console.WriteLine($"number is : {number}");

var workWithStudent = new WorkWithValue<Student>();
workWithStudent.GetValue(new Student { Name = "Sahar" });
var student = workWithStudent.ReturnValue();
Console.WriteLine($"The student name is: {student.Name}");


var unsuccessfulRes = new ApiResponse<Student>("Error creating student.");
Console.WriteLine(
    $"Creation was {(unsuccessfulRes.IsSuccessful ? "successful" : "unsuccessful")}, " +
    $"message: {unsuccessfulRes.ResultMessage}");

#endregion


#region --------------------------- GenericConstraints--------------------------------------
var repo = new EntityRepository<Student>();
var std1 = new Student { Id = 1, Name = "Sahar" };
var std2 = new Student { Id = 2, Name = "Maryam" };
repo.AddEntity(std1);
repo.AddEntity(std2);
var id = 2;
var res = repo.Find(id);
Console.WriteLine($"Student with Id: {res?.Id} is : {res?.Name}");

//var delRes = repo.DeleteEntity(id);
//Console.WriteLine($"deleting was {(delRes? "successful": "unsucsessful")}");
//var delRes2 = repo.DeleteEntity(id);
//Console.WriteLine($"deleting was {(delRes2? "successful": "unsuccessful")}");

var allStudents = repo.GetAllEntities();

foreach(var item in allStudents)
{
    Console.WriteLine($"{item.Id} - Name: {item.Name}");
}
var s = allStudents.ToList();
s.Add(new Student { Id = 3, Name = "Mojgan"});
s[0].Name = "Changed";
foreach (var item in allStudents)
{
    Console.WriteLine($"{item.Id} - Name: {item.Name}");
}



var cache = new ReferenceTypeCache<Student>();
Console.WriteLine($"Cache value is: {cache.GetCachedValue()}");

cache.CacheData(student);
Console.WriteLine($"cache value is : {cache.GetCachedValue()?.Name}");


var valueType = new ValueTypeHolder<int>();
valueType.Value = 10;
Console.WriteLine($"value type is: {valueType.Value}");


var objectFactory = new ObjectFactory<Student>();
var std3 = objectFactory.CreateItem();
std3.Name = "Ahmad";
Console.WriteLine($"factory name is: {std3.Name}");

var entityFactory = new EntityFactory<Student>();
var std4 = entityFactory.CreateRefTypeEntity();
std4.Id = 4;
std4.Name = "Zahra Ame";
Console.WriteLine($"{std4.Id}- {std4.Name}");

#endregion


#region --------------------------- GenericInterfaces--------------------------------------
IRepository<Product, Guid> prodRepo = new InMemoryRepository<Product, Guid>();
var product1 = new Product() { Id = Guid.NewGuid(), Name = "Mouse" };
var product2 = new Product() { Id = Guid.NewGuid(), Name = "Keyboard" };
prodRepo.Add(product1);
prodRepo.Add(product2);

foreach (var item in prodRepo.GetAll())
{
    Console.WriteLine($"id: {item.Id} - ProdName: {item.Name}");
}

var selectProd = prodRepo.Find(product1.Id);
Console.WriteLine($"found product: {selectProd?.Name}");

var isDeleted = prodRepo.Delete(product2.Id);
Console.WriteLine($"Deleted: {isDeleted}");
foreach (var item in prodRepo.GetAll())
{
    Console.WriteLine($"id: {item.Id}- ProdName: {item.Name}");
}
#endregion




