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