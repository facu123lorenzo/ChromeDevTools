using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Cookie object

	/// </summary>
	[SupportedBy("Chrome")]
	public class Cookie
	{
		/// <summary>
		/// Gets or setsCookie name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsCookie value.

		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsCookie domain.

		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Gets or setsCookie path.

		/// </summary>
		public string Path { get; set; }
		/// <summary>
		/// Gets or setsCookie expiration date as the number of seconds since the UNIX epoch.

		/// </summary>
		public double Expires { get; set; }
		/// <summary>
		/// Gets or setsCookie size.

		/// </summary>
		public long Size { get; set; }
		/// <summary>
		/// Gets or setsTrue if cookie is http-only.

		/// </summary>
		public bool HttpOnly { get; set; }
		/// <summary>
		/// Gets or setsTrue if cookie is secure.

		/// </summary>
		public bool Secure { get; set; }
		/// <summary>
		/// Gets or setsTrue in case of session cookie.

		/// </summary>
		public bool Session { get; set; }
		/// <summary>
		/// Gets or setsCookie SameSite type.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieSameSite SameSite { get; set; }
		/// <summary>
		/// Gets or setsCookie Priority

		/// </summary>
		public CookiePriority Priority { get; set; }
		/// <summary>
		/// Gets or setsTrue if cookie is SameParty.

		/// </summary>
		public bool SameParty { get; set; }
		/// <summary>
		/// Gets or setsCookie source scheme type.

		/// </summary>
		public CookieSourceScheme SourceScheme { get; set; }
		/// <summary>
		/// Gets or setsCookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
		/// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
		/// This is a temporary ability and it will be removed in the future.

		/// </summary>
		public long SourcePort { get; set; }
		/// <summary>
		/// Gets or setsCookie partition key. The site of the top-level URL the browser was visiting at the start
		/// of the request to the endpoint that set the cookie.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PartitionKey { get; set; }
		/// <summary>
		/// Gets or setsTrue if cookie partition key is opaque.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? PartitionKeyOpaque { get; set; }
	}
}
