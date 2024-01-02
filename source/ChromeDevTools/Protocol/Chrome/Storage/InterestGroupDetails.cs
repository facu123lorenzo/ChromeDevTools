using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///The full details of an interest group.

	/// </summary>
	[SupportedBy("Chrome")]
	public class InterestGroupDetails
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double ExpirationTime { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string JoiningOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BiddingLogicURL { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BiddingWasmHelperURL { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UpdateURL { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TrustedBiddingSignalsURL { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string[] TrustedBiddingSignalsKeys { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UserBiddingSignals { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public InterestGroupAd[] Ads { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public InterestGroupAd[] AdComponents { get; set; }
	}
}
