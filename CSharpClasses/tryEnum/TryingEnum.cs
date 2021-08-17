// Structures - Value Types - Primitives types (int, char, float, bool) and  custom Structures
// Classes - Reference Types - Non-Primitive types (classes, structures, arrays, strings)

// Value Types and Reference types. 
// Value types are stored in Stack Memory
// Reference types are stored in Heap Memory
// Reference of the classes stored in Heap Memory are stored in Stack Memory as the named variable

using System;

namespace CSharpClasses.tryEnum
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,     // default set to ZERO
        RegisteredAirMail = 2,  // automated to default + 1
        Express = 3             // automated to default + 2
    }

    // is actually the same as writing
    // public enum ShippingMethod
    // {RegularAirMail, RegisteredAirMail, Express}
}