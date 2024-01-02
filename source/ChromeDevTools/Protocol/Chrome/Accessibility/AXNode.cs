using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	///A node in the accessibility tree.

	/// </summary>
	[SupportedBy("Chrome")]
	public class AXNode
	{
		/// <summary>
		/// Gets or setsUnique identifier for this node.

		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// Gets or setsWhether this node is ignored for accessibility

		/// </summary>
		public bool Ignored { get; set; }
		/// <summary>
		/// Gets or setsCollection of reasons why this node is hidden.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXProperty[] IgnoredReasons { get; set; }
		/// <summary>
		/// Gets or setsThis `Node`'s role, whether explicit or implicit.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Role { get; set; }
		/// <summary>
		/// Gets or setsThis `Node`'s Chrome raw role.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue ChromeRole { get; set; }
		/// <summary>
		/// Gets or setsThe accessible name for this `Node`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Name { get; set; }
		/// <summary>
		/// Gets or setsThe accessible description for this `Node`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Description { get; set; }
		/// <summary>
		/// Gets or setsThe value for this `Node`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Value { get; set; }
		/// <summary>
		/// Gets or setsAll other properties

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXProperty[] Properties { get; set; }
		/// <summary>
		/// Gets or setsID for this node's parent.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ParentId { get; set; }
		/// <summary>
		/// Gets or setsIDs for each of this node's child nodes.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ChildIds { get; set; }
		/// <summary>
		/// Gets or setsThe backend ID for the associated DOM node, if any.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendDOMNodeId { get; set; }
		/// <summary>
		/// Gets or setsThe frame ID for the frame associated with this nodes document.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
