using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	///An explanation of an factor contributing to the security state.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SecurityStateExplanation
	{
		/// <summary>
		/// Gets or setsSecurity state representing the severity of the factor being explained.

		/// </summary>
		public SecurityState SecurityState { get; set; }
		/// <summary>
		/// Gets or setsTitle describing the type of factor.

		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or setsShort phrase describing the type of factor.

		/// </summary>
		public string Summary { get; set; }
		/// <summary>
		/// Gets or setsFull text explanation of the factor.

		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Gets or setsThe type of mixed content described by the explanation.

		/// </summary>
		public MixedContentType MixedContentType { get; set; }
		/// <summary>
		/// Gets or setsPage certificate.

		/// </summary>
		public string[] Certificate { get; set; }
		/// <summary>
		/// Gets or setsRecommendations to fix any issues.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Recommendations { get; set; }
	}
}
