using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Chrome histogram.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Histogram
	{
		/// <summary>
		/// Gets or setsName.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsSum of sample values.

		/// </summary>
		public long Sum { get; set; }
		/// <summary>
		/// Gets or setsTotal number of samples.

		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// Gets or setsBuckets.

		/// </summary>
		public Bucket[] Buckets { get; set; }
	}
}
