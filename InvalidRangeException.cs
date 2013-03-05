
using System;
public class InvalidRangeException<T> : Exception
{
    public InvalidRangeException(string msg)
        : base(msg)
    {
    }
}

//public InvalidRangeException(string msg, Exception inerrEx)
//    : base(msg, inerrEx)
//{
//}