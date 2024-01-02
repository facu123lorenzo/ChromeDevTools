using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	///Describes the width and height dimensions of an entity.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Size
	{
		/// <summary>
		/// Gets or setsWidth in pixels.

		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or setsHeight in pixels.

		/// </summary>
		public long Height { get; set; }
	}
}
