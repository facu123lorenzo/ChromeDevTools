using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Pair of reporting metadata details for a candidate URL for `selectURL()`.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageReportingMetadata
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string EventType { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ReportingUrl { get; set; }
	}
}
