// See https://aka.ms/new-console-template for more information
using Prototype;

EmployeeProtoType temp1= new TempEmployee();
temp1.Name = "Temp 1";
temp1.ID = 1;
temp1.Address = new Address {City="Cairo",StreetName="Zidan",Building=10 };

EmployeeProtoType temp2=temp1.DeepCopy();


Console.WriteLine("Original");
Console.WriteLine(temp1.ToString());
Console.WriteLine("Temp 2");
Console.WriteLine(temp2.ToString());

temp2.Address.City = "Giza";
Console.WriteLine("Temp1 After change");
Console.WriteLine(temp1.ToString());
Console.WriteLine("Temp2 After change");
Console.WriteLine(temp2.ToString());