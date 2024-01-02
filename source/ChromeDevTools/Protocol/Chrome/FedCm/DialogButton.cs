using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm{
	/// <summary>
	///The buttons on the FedCM dialog.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DialogButton
	{
			ConfirmIdpLoginContinue,
			ErrorGotIt,
			ErrorMoreDetails,
	}
}
