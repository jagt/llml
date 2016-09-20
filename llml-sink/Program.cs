using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace llml.sink
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello llml!");

			var dict = new Dictionary<string, object>();
			IDictionary<string, object> roDict = new ReadOnlyDictionary<string, object>(dict);

		}
	}
}

