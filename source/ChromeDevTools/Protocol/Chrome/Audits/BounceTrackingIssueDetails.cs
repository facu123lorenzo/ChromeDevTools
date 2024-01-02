using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///This issue warns about sites in the redirect chain of a finished navigation
	/// that may be flagged as trackers and have their state cleared if they don't
	/// receive a user interaction. Note that in this context 'site' means eTLD+1.
	/// For example, if the URL `https://example.test:80/bounce` was in the
	/// redirect chain, the site reported would be `example.test`.

	/// </summary>
	[SupportedBy("Chrome")]
	public class BounceTrackingIssueDetails
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string[] TrackingSites { get; set; }
	}
}
