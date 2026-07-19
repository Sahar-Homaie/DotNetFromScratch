using DotNetFromScratch.Generics.GenericClasses;
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


var studentResponse = new ApiResponse<Student> { 
                        IsSuccessful = true, 
                        ResultMessage = "was created successfully.", 
                        Data = student
                    };
Console.WriteLine($"Data for Student {studentResponse.Data.Name} {studentResponse.ResultMessage}");

var unsuccessfulRes = new ApiResponse<Student>("Error creating student.");
Console.WriteLine(
    $"Creation was {(unsuccessfulRes.IsSuccessful ? "successful" : "unsuccessful")}, " +
    $"message: {unsuccessfulRes.ResultMessage}");

#endregion




