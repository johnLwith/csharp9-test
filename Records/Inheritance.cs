using System;


Person teacher = new Teacher("Nancy", "Davolio", 3, null);
Console.WriteLine(teacher);
// output: Teacher { FirstName = Nancy, LastName = Davolio, Grade = 3 }


Console.WriteLine(new Student<string>("1"));

public abstract record Person(string FirstName, string LastName);
public record Teacher(string FirstName, string LastName, int Grade, string[] Address)
    : Person(FirstName, LastName);


record Student<T>(T firstName);

public class InitClass
{ 
    public string First { init; get; }
}
