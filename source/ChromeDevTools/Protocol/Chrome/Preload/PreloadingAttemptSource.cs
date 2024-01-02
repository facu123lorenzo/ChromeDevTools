using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	///Lists sources for a preloading attempt, specifically the ids of rule sets
	/// that had a speculation rule that triggered the attempt, and the
	/// BackendNodeIds of <a href> or <area href> elements that triggered the
	/// attempt (in the case of attempts triggered by a document rule). It is
	/// possible for mulitple rule sets and links to trigger a single attempt.

	/// </summary>
	[SupportedBy("Chrome")]
	public class PreloadingAttemptSource
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public PreloadingAttemptKey Key { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string[] RuleSetIds { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
