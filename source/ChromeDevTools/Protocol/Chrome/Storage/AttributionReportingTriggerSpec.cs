using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingTriggerSpec
	{
		/// <summary>
		/// Gets or setsnumber instead of integer because not all uint32 can be represented by
		/// int

		/// </summary>
		public double[] TriggerData { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingEventReportWindows EventReportWindows { get; set; }
	}
}
