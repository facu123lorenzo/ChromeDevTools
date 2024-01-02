using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	///Notifies that the construction of an AudioListener has finished.

	/// </summary>
	[Event(ProtocolName.WebAudio.AudioListenerCreated)]
	[SupportedBy("Chrome")]
	public class AudioListenerCreatedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AudioListener Listener { get; set; }
	}
}
