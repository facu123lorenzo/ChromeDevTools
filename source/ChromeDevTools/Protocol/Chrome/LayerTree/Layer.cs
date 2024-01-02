using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	///Information about a compositing layer.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Layer
	{
		/// <summary>
		/// Gets or setsThe unique id for this layer.

		/// </summary>
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or setsThe id of parent (not present for root).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ParentLayerId { get; set; }
		/// <summary>
		/// Gets or setsThe backend id for the node associated with this layer.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or setsOffset from parent layer, X coordinate.

		/// </summary>
		public double OffsetX { get; set; }
		/// <summary>
		/// Gets or setsOffset from parent layer, Y coordinate.

		/// </summary>
		public double OffsetY { get; set; }
		/// <summary>
		/// Gets or setsLayer width.

		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Gets or setsLayer height.

		/// </summary>
		public double Height { get; set; }
		/// <summary>
		/// Gets or setsTransformation matrix for layer, default is identity matrix

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double[] Transform { get; set; }
		/// <summary>
		/// Gets or setsTransform anchor point X, absent if no transform specified

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double AnchorX { get; set; }
		/// <summary>
		/// Gets or setsTransform anchor point Y, absent if no transform specified

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double AnchorY { get; set; }
		/// <summary>
		/// Gets or setsTransform anchor point Z, absent if no transform specified

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double AnchorZ { get; set; }
		/// <summary>
		/// Gets or setsIndicates how many time this layer has painted.

		/// </summary>
		public long PaintCount { get; set; }
		/// <summary>
		/// Gets or setsIndicates whether this layer hosts any content, rather than being used for
		/// transform/scrolling purposes only.

		/// </summary>
		public bool DrawsContent { get; set; }
		/// <summary>
		/// Gets or setsSet if layer is not visible.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Invisible { get; set; }
		/// <summary>
		/// Gets or setsRectangles scrolling on main thread only.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ScrollRect[] ScrollRects { get; set; }
		/// <summary>
		/// Gets or setsSticky position constraint information

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StickyPositionConstraint StickyPositionConstraint { get; set; }
	}
}
