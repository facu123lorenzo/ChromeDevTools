using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Box model.

	/// </summary>
	[SupportedBy("Chrome")]
	public class BoxModel
	{
		/// <summary>
		/// Gets or setsContent box

		/// </summary>
		public double[] Content { get; set; }
		/// <summary>
		/// Gets or setsPadding box

		/// </summary>
		public double[] Padding { get; set; }
		/// <summary>
		/// Gets or setsBorder box

		/// </summary>
		public double[] Border { get; set; }
		/// <summary>
		/// Gets or setsMargin box

		/// </summary>
		public double[] Margin { get; set; }
		/// <summary>
		/// Gets or setsNode width

		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or setsNode height

		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Gets or setsShape outside coordinates

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ShapeOutsideInfo ShapeOutside { get; set; }
	}
}
