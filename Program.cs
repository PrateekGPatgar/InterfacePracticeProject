// See https://aka.ms/new-console-template for more information
using InterfacePracticeProject;

Console.WriteLine("Hello, World!");

string[] arr = { "1 . Circle ", "2 . Rectangle", "3 .Square" };
int choice;

Console.WriteLine("Which area you want to find out");
Console.WriteLine("Enter the numbers: ");

for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}



Console.WriteLine("Enter the Choice: ");
choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Circle circle = new Circle();
        circle.InputValues();
        circle.CalculateArea();
        break;
    case 2:
        Rectangle rectangle = new Rectangle(); 
        rectangle.AcceptReactangleValue();
        rectangle.CalculateArea();
        break;
    case 3:
        Square square = new Square();
        square.AcceptSquareValye();
        square.CalculateArea();
        break;
}

















