using System;

namespace ImplicitExplicitConversionShenanigans
{
    public class UserId
    {
        public UserId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }
        

        // You can define implicit and explicit conversions
        // between objects
        public static implicit operator UserId(Guid guid)
        {
            return new UserId(guid);
        }
        

        // It should be noted that you cannot have both an implicit
        // and explicit conversions between the same type pairs
        // public static explicit operator UserId(Guid guid)
        // {
        //     return new UserId(guid);
        // }
        
        public static explicit operator Guid(UserId id)
        {
            return id.Value;
        }
        
        
    }
}