using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///CSS Shape Outside details.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ShapeOutsideInfo
	{
		/// <summary>
		/// Gets or setsShape bounds

		/// </summary>
		public double[] Bounds { get; set; }
		/// <summary>
		/// Gets or setsShape coordinate details

		/// </summary>
		public object[] Shape { get; set; }
		/// <summary>
		/// Gets or setsMargin shape bounds

		/// </summary>
		public object[] MarginShape { get; set; }
	}
}
