using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	///Protocol object for BaseAudioContext

	/// </summary>
	[SupportedBy("Chrome")]
	public class BaseAudioContext
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ContextType ContextType { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ContextState ContextState { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContextRealtimeData RealtimeData { get; set; }
		/// <summary>
		/// Gets or setsPlatform-dependent callback buffer size.

		/// </summary>
		public double CallbackBufferSize { get; set; }
		/// <summary>
		/// Gets or setsNumber of output channels supported by audio hardware in use.

		/// </summary>
		public double MaxOutputChannelCount { get; set; }
		/// <summary>
		/// Gets or setsContext sample rate.

		/// </summary>
		public double SampleRate { get; set; }
	}
}
