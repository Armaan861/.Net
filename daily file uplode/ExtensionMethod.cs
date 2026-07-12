//Extension method : - method that add a new method to an existing class without changing its source code
using System;

public static class ExtensionMethod
{
    public static String ProperCase(this String name)
    {
        return char.ToUpper(name[0]) +
        name.Substring(1).ToLower();
    }
}