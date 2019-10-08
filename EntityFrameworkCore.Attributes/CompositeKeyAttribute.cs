using System;

namespace EntityFrameworkCore.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class CompositeKeyAttribute : Attribute
    {
    }
}
