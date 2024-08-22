using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFashion.Core.Exceptions
{

	[Serializable]
	public class RaiseException : Exception
	{
		public RaiseException() { }
		public RaiseException(string message) : base(message) { }
		public RaiseException(string message, Exception inner) : base(message, inner) { }
		protected RaiseException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
