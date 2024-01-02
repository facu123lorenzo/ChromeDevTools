using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	[SupportedBy("Chrome")]
	public class VirtualAuthenticatorOptions
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AuthenticatorProtocol Protocol { get; set; }
		/// <summary>
		/// Gets or setsDefaults to ctap2_0. Ignored if |protocol| == u2f.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Ctap2Version Ctap2Version { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AuthenticatorTransport Transport { get; set; }
		/// <summary>
		/// Gets or setsDefaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasResidentKey { get; set; }
		/// <summary>
		/// Gets or setsDefaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasUserVerification { get; set; }
		/// <summary>
		/// Gets or setsIf set to true, the authenticator will support the largeBlob extension.
		/// https://w3c.github.io/webauthn#largeBlob
		/// Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasLargeBlob { get; set; }
		/// <summary>
		/// Gets or setsIf set to true, the authenticator will support the credBlob extension.
		/// https://fidoalliance.org/specs/fido-v2.1-rd-20201208/fido-client-to-authenticator-protocol-v2.1-rd-20201208.html#sctn-credBlob-extension
		/// Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasCredBlob { get; set; }
		/// <summary>
		/// Gets or setsIf set to true, the authenticator will support the minPinLength extension.
		/// https://fidoalliance.org/specs/fido-v2.1-ps-20210615/fido-client-to-authenticator-protocol-v2.1-ps-20210615.html#sctn-minpinlength-extension
		/// Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasMinPinLength { get; set; }
		/// <summary>
		/// Gets or setsIf set to true, the authenticator will support the prf extension.
		/// https://w3c.github.io/webauthn/#prf-extension
		/// Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasPrf { get; set; }
		/// <summary>
		/// Gets or setsIf set to true, tests of user presence will succeed immediately.
		/// Otherwise, they will not be resolved. Defaults to true.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AutomaticPresenceSimulation { get; set; }
		/// <summary>
		/// Gets or setsSets whether User Verification succeeds or fails for an authenticator.
		/// Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsUserVerified { get; set; }
		/// <summary>
		/// Gets or setsCredentials created by this authenticator will have the backup
		/// eligibility (BE) flag set to this value. Defaults to false.
		/// https://w3c.github.io/webauthn/#sctn-credential-backup

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DefaultBackupEligibility { get; set; }
		/// <summary>
		/// Gets or setsCredentials created by this authenticator will have the backup state
		/// (BS) flag set to this value. Defaults to false.
		/// https://w3c.github.io/webauthn/#sctn-credential-backup

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DefaultBackupState { get; set; }
	}
}
