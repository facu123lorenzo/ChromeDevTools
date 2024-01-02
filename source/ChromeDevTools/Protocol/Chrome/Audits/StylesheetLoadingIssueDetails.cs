using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///This issue warns when a referenced stylesheet couldn't be loaded.

	/// </summary>
	[SupportedBy("Chrome")]
	public class StylesheetLoadingIssueDetails
	{
		/// <summary>
		/// Gets or setsSource code position that referenced the failing stylesheet.

		/// </summary>
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or setsReason why the stylesheet couldn't be loaded.

		/// </summary>
		public StyleSheetLoadingIssueReason StyleSheetLoadingIssueReason { get; set; }
		/// <summary>
		/// Gets or setsContains additional info when the failure was due to a request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FailedRequestInfo FailedRequestInfo { get; set; }
	}
}
