using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///HTTP request data.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Request
	{
		/// <summary>
		/// Gets or setsRequest URL (without fragment).

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsFragment of the requested URL starting with hash, if present.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UrlFragment { get; set; }
		/// <summary>
		/// Gets or setsHTTP request method.

		/// </summary>
		public string Method { get; set; }
		/// <summary>
		/// Gets or setsHTTP request headers.

		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or setsHTTP POST request data.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PostData { get; set; }
		/// <summary>
		/// Gets or setsTrue when the request has POST data. Note that postData might still be omitted when this flag is true when the data is too long.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasPostData { get; set; }
		/// <summary>
		/// Gets or setsRequest body elements. This will be converted from base64 to binary

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PostDataEntry[] PostDataEntries { get; set; }
		/// <summary>
		/// Gets or setsThe mixed content type of the request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Security.MixedContentType MixedContentType { get; set; }
		/// <summary>
		/// Gets or setsPriority of the resource request at the time request is sent.

		/// </summary>
		public ResourcePriority InitialPriority { get; set; }
		/// <summary>
		/// Gets or setsThe referrer policy of the request, as defined in https://www.w3.org/TR/referrer-policy/

		/// </summary>
		public string ReferrerPolicy { get; set; }
		/// <summary>
		/// Gets or setsWhether is loaded via link preload.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsLinkPreload { get; set; }
		/// <summary>
		/// Gets or setsSet for requests when the TrustToken API is used. Contains the parameters
		/// passed by the developer (e.g. via "fetch") as understood by the backend.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TrustTokenParams TrustTokenParams { get; set; }
		/// <summary>
		/// Gets or setsTrue if this resource request is considered to be the 'same site' as the
		/// request correspondinfg to the main frame.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsSameSite { get; set; }
	}
}
