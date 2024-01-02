using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///Information about a cookie that is affected by an inspector issue.

	/// </summary>
	[SupportedBy("Chrome")]
	public class AffectedCookie
	{
		/// <summary>
		/// Gets or setsThe following three properties uniquely identify a cookie

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Domain { get; set; }
	}
}
