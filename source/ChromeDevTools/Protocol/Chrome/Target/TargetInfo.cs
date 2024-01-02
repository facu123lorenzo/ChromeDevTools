using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	[SupportedBy("Chrome")]
	public class TargetInfo
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsWhether the target has an attached client.

		/// </summary>
		public bool Attached { get; set; }
		/// <summary>
		/// Gets or setsOpener target Id

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OpenerId { get; set; }
		/// <summary>
		/// Gets or setsWhether the target has access to the originating window.

		/// </summary>
		public bool CanAccessOpener { get; set; }
		/// <summary>
		/// Gets or setsFrame id of originating window (is only set if target has an opener).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OpenerFrameId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
		/// <summary>
		/// Gets or setsProvides additional details for specific target types. For example, for
		/// the type of "page", this may be set to "portal" or "prerender".

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
	}
}
