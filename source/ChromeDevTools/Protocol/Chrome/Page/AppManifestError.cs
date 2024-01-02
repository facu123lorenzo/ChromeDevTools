using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Error while paring app manifest.

	/// </summary>
	[SupportedBy("Chrome")]
	public class AppManifestError
	{
		/// <summary>
		/// Gets or setsError message.

		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or setsIf criticial, this is a non-recoverable parse error.

		/// </summary>
		public long Critical { get; set; }
		/// <summary>
		/// Gets or setsError line.

		/// </summary>
		public long Line { get; set; }
		/// <summary>
		/// Gets or setsError column.

		/// </summary>
		public long Column { get; set; }
	}
}
