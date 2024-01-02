using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	///Triggered when a credential is added to an authenticator.

	/// </summary>
	[Event(ProtocolName.WebAuthn.CredentialAdded)]
	[SupportedBy("Chrome")]
	public class CredentialAddedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public Credential Credential { get; set; }
	}
}
