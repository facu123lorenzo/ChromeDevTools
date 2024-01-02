using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Viewport for capturing screenshot.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Viewport
	{
		/// <summary>
		/// Gets or setsX offset in device independent pixels (dip).

		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or setsY offset in device independent pixels (dip).

		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or setsRectangle width in device independent pixels (dip).

		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Gets or setsRectangle height in device independent pixels (dip).

		/// </summary>
		public double Height { get; set; }
		/// <summary>
		/// Gets or setsPage scale factor.

		/// </summary>
		public double Scale { get; set; }
	}
}
