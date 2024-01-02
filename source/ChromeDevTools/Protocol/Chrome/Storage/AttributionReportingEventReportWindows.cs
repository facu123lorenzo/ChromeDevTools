using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingEventReportWindows
	{
		/// <summary>
		/// Gets or setsduration in seconds

		/// </summary>
		public long Start { get; set; }
		/// <summary>
		/// Gets or setsduration in seconds

		/// </summary>
		public long[] Ends { get; set; }
	}
}
