using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Rectangle.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Rect
	{
		/// <summary>
		/// Gets or setsX coordinate

		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or setsY coordinate

		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or setsRectangle width

		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Gets or setsRectangle height

		/// </summary>
		public double Height { get; set; }
	}
}
