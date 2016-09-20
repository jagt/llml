using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace llml
{
	///	lua table like data structure, that has a array part and a hashtable part.
	/// this is more of a lightweight wrapper that sets both parts to empty readonly objects for failsafe
	public sealed class llTable
	{
		/// read only dictionary 
		private static IDictionary<string, llData> _EMPTY_READONLY_DICTIONARY;

		private static llData[] _EMPTY_ARRAY;

		static llTable() {
			var emptyDict = new Dictionary<string, llData>();
			_EMPTY_READONLY_DICTIONARY = new ReadOnlyDictionary<string, llData>(emptyDict);
			_EMPTY_ARRAY = new llData[0]; 
		}

		/// Array part of the table
		private llData[] _arrayPart = _EMPTY_ARRAY;

		/// Dictionary part of the table
		private IDictionary<string, llData> _dictPart = _EMPTY_READONLY_DICTIONARY;

		public llData[] ArrayPart
		{
			get { return _arrayPart; }
			set { _arrayPart = value; }
		}

		public IDictionary<string, llData> DictPart
		{
			get { return _dictPart; }
			set { _dictPart = value; }
		}
	}
}
