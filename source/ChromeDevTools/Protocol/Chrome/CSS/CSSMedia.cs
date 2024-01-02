using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///CSS media rule descriptor.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSMedia
	{
		/// <summary>
		/// Gets or setsMedia query text.

		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or setsSource of the media query: "mediaRule" if specified by a @media rule, "importRule" if
		/// specified by an @import rule, "linkedSheet" if specified by a "media" attribute in a linked
		/// stylesheet's LINK tag, "inlineSheet" if specified by a "media" attribute in an inline
		/// stylesheet's STYLE tag.

		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Gets or setsURL of the document containing the media query description.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or setsThe associated rule (@media or @import) header range in the enclosing stylesheet (if
		/// available).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the stylesheet containing this object (if exists).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or setsArray of media queries.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MediaQuery[] MediaList { get; set; }
	}
}
