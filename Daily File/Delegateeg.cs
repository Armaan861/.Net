/*//delegates - type that hold reference of method
using System;

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(588, 756));

delegate void MEssageDelegate(string message);

class Delegateeg
{
    static void Display(string message)
    {
        Console.WriteLine(message);
    }


    static void Main()
    {
        MEssageDelegate m = Display;
        m("Hello, i m learning dot net c#");


    }
}
*/
/*Short Notes (for your notebook)

Delegate: A type that stores the reference of a method and allows that method to be called indirectly.

Func: A built-in delegate that accepts parameters and returns a value.

Custom Delegate: A user-defined delegate that can store methods with the same signature.

Easy Way to Remember
Variable stores data (e.g., int x = 10;)
Delegate stores a method (e.g., MessageDelegate m = Display;)

That's the core idea of delegates in C#.

“Short”*/