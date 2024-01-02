using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	///A rectangle.

	/// </summary>
	[SupportedBy("iOS")]
	public class IntRect
	{
		/// <summary>
		/// Gets or setsThe x position.

		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or setsThe y position.

		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or setsThe width metric.

		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or setsThe height metric.

		/// </summary>
		public long Height { get; set; }
	}
}
