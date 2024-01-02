using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	///Data that is only present on rare nodes.

	/// </summary>
	[SupportedBy("Chrome")]
	public class RareStringData
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long[] Index { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long[] Value { get; set; }
	}
}
