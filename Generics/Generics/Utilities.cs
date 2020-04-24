using System;

namespace Generics
{

    //Sometimes we would want to limit what is been sent as type in our genric class i.e GenericList<T> , here T
    //So for example we can see : 
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        // if we want to create a generic version of the method  this is how we could do it :

        /*
         public T Max<T>(T a , T b)
        {
           return a > b ? a : b; // but this line will give error because at this time the compiler doesnt know the value of T.
            so it cannot apply comparison between a and b
            at this time it will think that a and b are both objects
        }
         */

        // so here we use the IComparable interface which contains a method called CompareTo through which we can compare the objects.
        // so this is the case where we need to apply the constraints like :

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;

        }

        /* To Simplify we can directly give our constraint to the class . Any of the two will work : 
         
          public class Utilities<T> where T : IComparable
          {
             public int Max(int a, int b)
             {
                 return a > b ? a : b;
             }
             public T Max(T a, T b) 
             {
                 return a.CompareTo(b) > 0 ? a : b;

             }
          }   
        */

        /*
         Other constraints:
         where T : IComparable    --while applying constraint to an interface
         where T: Product         --constraint to a class or subclass
         where T: struct          -- where T is value type
         where T: class          -- reference type
         where T : new ()       -- object with a default constructor 
         * */
    }
}
