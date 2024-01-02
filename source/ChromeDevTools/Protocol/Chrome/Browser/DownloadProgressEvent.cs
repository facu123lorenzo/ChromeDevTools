using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Fired when download makes progress. Last call has |done| == true.

	/// </summary>
	[Event(ProtocolName.Browser.DownloadProgress)]
	[SupportedBy("Chrome")]
	public class DownloadProgressEvent
	{
		/// <summary>
		/// Gets or setsGlobal unique identifier of the download.

		/// </summary>
		public string Guid { get; set; }
		/// <summary>
		/// Gets or setsTotal expected bytes to download.

		/// </summary>
		public double TotalBytes { get; set; }
		/// <summary>
		/// Gets or setsTotal bytes received.

		/// </summary>
		public double ReceivedBytes { get; set; }
		/// <summary>
		/// Gets or setsDownload status.

		/// </summary>
		public string State { get; set; }
	}
}
