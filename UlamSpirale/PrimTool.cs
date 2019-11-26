using System;
using System.Collections.Generic;
using System.Text;

namespace UlamSpirale
{
  static class PrimTool
  {
    public static bool IsPrime(int candidate)
    {
      // Test whether the parameter is a prime number.
      if ((candidate & 1) == 0)
      {
        if (candidate == 2)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      // Note:
      // ... This version was changed to test the square.
      // ... Original version tested against the square root.
      // ... Also we exclude 1 at the very end.
      for (int i = 3; (i * i) <= candidate; i += 2)
      {
        if ((candidate % i) == 0)
        {
          return false;
        }
      }
      return candidate != 1;
    }

    public static int GetPrime(int candidate)
    {
      for (int i = 2; i < int.MaxValue; i++)
      {
        if (IsPrime(candidate)) candidate++;
      }
      return candidate;
    }

    public static int CreatePrime(int candidate)
    {
      for (int i = 2; i < int.MaxValue; i++)
      {
        if (IsPrime(candidate)) candidate++;
      }
      return candidate;
    }

  }
}
