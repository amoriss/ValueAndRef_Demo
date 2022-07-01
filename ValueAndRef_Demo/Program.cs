// See https://aka.ms/new-console-template for more information
using ValueAndRef_Demo;

Console.WriteLine("Hello, World!");


#region  Value Types
//Stack is last in, first out container
//Value types stores the actual data instead of the place in memory for it

//Numbers
int x;
double y;
float f;
decimal z;

//Individual character
char a = 'a';
bool b = true;

//Struct (is a value type container that is stored on the stack)
MyStruct struct1;
DaysOfTheWeek d;

#endregion 


#region Reference Types
//can be made nullable
double firstNumber = 10;
double secondNumber = firstNumber;
secondNumber += 10;
Console.WriteLine(secondNumber);

double price = 25.99;
double copyofprice = price;
Console.WriteLine(copyofprice);

var d1 = new Dog();

int[] myArray = new int[] { 1, 2, 3 };
int[] copyOfMyArray = myArray;
copyOfMyArray[0] = 10;
Console.WriteLine(copyOfMyArray[0]);
#endregion