// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.Interface;

Console.WriteLine("Hello, World!");
Console.WriteLine("Whats up !");

Student student = new Student();
student.FirstName = "Mohammad";
student.LastName = "Sheakh";
student.Greet();
Console.WriteLine(student.Sum(2, 2)) ;

FileInfoAgain file = new FileInfoAgain();
Ifile ifile = new FileInfoAgain();
Ibinary ibinary = new FileInfoAgain();
Console.WriteLine("------------------ Interface --------------------");
file.NextFile();
ifile.ReadFile();
ibinary.isBinary();
Console.WriteLine("------------------ Ternary Operator --------------------");
int x = 12; int y = 13;
string result = x > y ? "x is greater " : "y is greater";
Console.WriteLine("Greater is : " + result);

Console.WriteLine("------------------  --------------------");


Console.WriteLine("------------------  --------------------");


Console.WriteLine("------------------  --------------------");





