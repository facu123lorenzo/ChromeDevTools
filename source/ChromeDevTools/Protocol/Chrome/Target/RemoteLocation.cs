using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	[SupportedBy("Chrome")]
	public class RemoteLocation
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Host { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long Port { get; set; }
	}
}
