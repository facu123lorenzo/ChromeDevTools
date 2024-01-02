using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class ContentSecurityPolicyStatus
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string EffectiveDirectives { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool IsEnforced { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ContentSecurityPolicySource Source { get; set; }
	}
}
