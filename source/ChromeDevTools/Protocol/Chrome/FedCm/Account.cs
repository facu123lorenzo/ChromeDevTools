using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	/// <summary>
	///Corresponds to IdentityRequestAccount

	/// </summary>
	[SupportedBy("Chrome")]
	public class Account
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string AccountId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string GivenName { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string PictureUrl { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string IdpConfigUrl { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string IdpLoginUrl { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public LoginState LoginState { get; set; }
		/// <summary>
		/// Gets or setsThese two are only set if the loginState is signUp

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TermsOfServiceUrl { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PrivacyPolicyUrl { get; set; }
	}
}
