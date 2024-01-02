using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	///Coverage data for a source range.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CoverageRange
	{
		/// <summary>
		/// Gets or setsJavaScript script source offset for the range start.

		/// </summary>
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or setsJavaScript script source offset for the range end.

		/// </summary>
		public long EndOffset { get; set; }
		/// <summary>
		/// Gets or setsCollected execution count of the source range.

		/// </summary>
		public long Count { get; set; }
	}
}
