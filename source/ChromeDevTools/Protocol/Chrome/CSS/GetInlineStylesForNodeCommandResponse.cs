using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM
	/// attributes) for a DOM node identified by `nodeId`.

	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetInlineStylesForNode)]
	[SupportedBy("Chrome")]
	public class GetInlineStylesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or setsInline style for the specified DOM node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Gets or setsAttribute-defined element style (e.g. resulting from "width=20 height=100%").

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle AttributesStyle { get; set; }
	}
}
