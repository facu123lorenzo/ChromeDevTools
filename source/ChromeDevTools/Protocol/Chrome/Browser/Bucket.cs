using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Chrome histogram bucket.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Bucket
	{
		/// <summary>
		/// Gets or setsMinimum value (inclusive).

		/// </summary>
		public long Low { get; set; }
		/// <summary>
		/// Gets or setsMaximum value (exclusive).

		/// </summary>
		public long High { get; set; }
		/// <summary>
		/// Gets or setsNumber of samples.

		/// </summary>
		public long Count { get; set; }
	}
}
