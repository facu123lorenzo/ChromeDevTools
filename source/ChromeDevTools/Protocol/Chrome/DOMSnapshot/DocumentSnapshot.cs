using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	///Document snapshot.

	/// </summary>
	[SupportedBy("Chrome")]
	public class DocumentSnapshot
	{
		/// <summary>
		/// Gets or setsDocument URL that `Document` or `FrameOwner` node points to.

		/// </summary>
		public long DocumentURL { get; set; }
		/// <summary>
		/// Gets or setsDocument title.

		/// </summary>
		public long Title { get; set; }
		/// <summary>
		/// Gets or setsBase URL that `Document` or `FrameOwner` node uses for URL completion.

		/// </summary>
		public long BaseURL { get; set; }
		/// <summary>
		/// Gets or setsContains the document's content language.

		/// </summary>
		public long ContentLanguage { get; set; }
		/// <summary>
		/// Gets or setsContains the document's character set encoding.

		/// </summary>
		public long EncodingName { get; set; }
		/// <summary>
		/// Gets or sets`DocumentType` node's publicId.

		/// </summary>
		public long PublicId { get; set; }
		/// <summary>
		/// Gets or sets`DocumentType` node's systemId.

		/// </summary>
		public long SystemId { get; set; }
		/// <summary>
		/// Gets or setsFrame ID for frame owner elements and also for the document node.

		/// </summary>
		public long FrameId { get; set; }
		/// <summary>
		/// Gets or setsA table with dom nodes.

		/// </summary>
		public NodeTreeSnapshot Nodes { get; set; }
		/// <summary>
		/// Gets or setsThe nodes in the layout tree.

		/// </summary>
		public LayoutTreeSnapshot Layout { get; set; }
		/// <summary>
		/// Gets or setsThe post-layout inline text nodes.

		/// </summary>
		public TextBoxSnapshot TextBoxes { get; set; }
		/// <summary>
		/// Gets or setsHorizontal scroll offset.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScrollOffsetX { get; set; }
		/// <summary>
		/// Gets or setsVertical scroll offset.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScrollOffsetY { get; set; }
		/// <summary>
		/// Gets or setsDocument content width.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ContentWidth { get; set; }
		/// <summary>
		/// Gets or setsDocument content height.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ContentHeight { get; set; }
	}
}
