using System;

/// Misc things

namespace llml
{
	/// base exception class for all llml throw
	public class llException : Exception
	{
		public llException(string msg) : base(msg) { }
	}
}
