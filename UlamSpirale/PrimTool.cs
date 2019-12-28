namespace UlamSpirale
{
	/// <summary>
	/// PrimTool
	/// </summary>
	internal static class PrimTool
	{
		/// <summary>
		/// Test whether the parameter is a prime number
		/// </summary>
		/// <param name="candidate">number to test</param>
		/// <returns>true if the parameter is prim</returns>
		public static bool IsPrime(int candidate)
		{
			if ((candidate & 1) == 0)
			{
				return candidate == 2;
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
				if (IsPrime(candidate: candidate))
				{
					candidate++;
				}
			}
			return candidate;
		}

		public static int CreatePrime(int candidate)
		{
			for (int i = 2; i < int.MaxValue; i++)
			{
				if (IsPrime(candidate: candidate))
				{
					candidate++;
				}
			}
			return candidate;
		}
	}
}
