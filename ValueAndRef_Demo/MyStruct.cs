//Value types: structs and enums
public struct MyStruct
{
    //not a lot of data goes inside of a struct
    public int x;
}
public enum DaysOfTheWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}


//Reference types: classes and interfaces
public class MyClass
{
    //class will contain more members than a struct
    public List<string> myList = new List<string>();
}
public interface MyInterface
{
    void Authentication();
}