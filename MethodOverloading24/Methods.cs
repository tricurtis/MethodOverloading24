using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading24;
internal class Methods
{
    public static  int Add(int x, int y)
    { 
        return x + y;
    }

    public static double Add(double x, double y)
    { 
        return x + y;
    }
        
    public static decimal Add(decimal x, decimal y)
    { 
        return x + y; 
    }

    public static string Add(int x, int y, bool withDollars)
    {
        if (withDollars && (x +y) !=1)
        {
            return $"{x + y} dollars";
        }
        else if (withDollars && (x +y) == 1)
        {
            return $"{x + y} dolllar";
        }
        else 
        {
            return $"{x + y}";
        }
    }


}

