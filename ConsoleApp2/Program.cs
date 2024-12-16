// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//C# Primitive Types
//task1
int num1= 1;
double num2= 1.5;
string name= "zainab";
bool condition= false;


Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(name);
Console.WriteLine(condition);

//Bonus
//char a variable to declare a single character, faster perfourmance

//task2
//converting int to double
int num3 = 0; double result = Convert.ToDouble(num3);


//C# Variables
//task1
string StudentName; //Pascal Case
double gradepointAverage; //Camel case
string favoraite_subject; //underscore

//task2
double a;
double w = 2;
double h = 3;

a = w * h;
Console.WriteLine(a);

//C# Control Flow
Console.WriteLine("enter time");
int currenthour = Convert.ToInt32(Console.ReadLine());

if (currenthour >= 11 && currenthour <=14)
    {
    Console.WriteLine("time for lunch");
    }



