﻿using System;
using System.Collections.Generic;

namespace llml
{
	///	Actual type of this llData instance.
	public enum llDataType
	{
		Null,
		Boolean,
		String,
		Double,
		Int64,
		Table,
	}

	/// Union type of serialized data value, is one of the type in llDataType
	public sealed class llData
	{
		/// Actual data stored as an object.
		private object _value;

	}
}


