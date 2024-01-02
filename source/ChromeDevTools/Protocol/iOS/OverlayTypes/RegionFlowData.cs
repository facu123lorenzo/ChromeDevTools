using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	[SupportedBy("iOS")]
	public class RegionFlowData
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public Region[] Regions { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Name { get; set; }
	}
}
