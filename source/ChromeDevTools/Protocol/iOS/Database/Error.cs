using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	/// <summary>
	///Database error.

	/// </summary>
	[SupportedBy("iOS")]
	public class Error
	{
		/// <summary>
		/// Gets or setsError message.

		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or setsError code.

		/// </summary>
		public long Code { get; set; }
	}
}
