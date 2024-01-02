using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm{
	/// <summary>
	///The types of FedCM dialogs.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DialogType
	{
			AccountChooser,
			AutoReauthn,
			ConfirmIdpLogin,
			Error,
	}
}
