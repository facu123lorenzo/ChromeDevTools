using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	/// <summary>
	///Frame identifier - manifest URL pair.

	/// </summary>
	[SupportedBy("iOS")]
	public class FrameWithManifest
	{
		/// <summary>
		/// Gets or setsFrame identifier.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsManifest URL.

		/// </summary>
		public string ManifestURL { get; set; }
		/// <summary>
		/// Gets or setsApplication cache status.

		/// </summary>
		public long Status { get; set; }
	}
}
