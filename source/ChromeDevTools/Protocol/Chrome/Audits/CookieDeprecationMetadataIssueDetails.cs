using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///This issue warns about third-party sites that are accessing cookies on the
	/// current page, and have been permitted due to having a global metadata grant.
	/// Note that in this context 'site' means eTLD+1. For example, if the URL
	/// `https://example.test:80/web_page` was accessing cookies, the site reported
	/// would be `example.test`.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CookieDeprecationMetadataIssueDetails
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string[] AllowedSites { get; set; }
	}
}
