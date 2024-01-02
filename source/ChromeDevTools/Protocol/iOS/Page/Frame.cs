using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	///Information about the Frame on the page.

	/// </summary>
	[SupportedBy("iOS")]
	public class Frame
	{
		/// <summary>
		/// Gets or setsFrame unique identifier.

		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or setsParent frame identifier.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ParentId { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the loader associated with this frame.

		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or setsFrame's name as specified in the tag.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsFrame document's URL.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsFrame document's security origin.

		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or setsFrame document's mimeType as determined by the browser.

		/// </summary>
		public string MimeType { get; set; }
	}
}
