// See https://aka.ms/new-console-template for more information
using ConsoleApp6;
// Properties Promote Encapsulation
// Property is a public way to access private field

Console.WriteLine("Hello, World!");
Dollar d = new Dollar();
//d._amount = 1.2243432m; // set
d.setamount(2.22m); // set by proberty method

Console.WriteLine(d._amount);  // get
Console.WriteLine(d.iszero);

