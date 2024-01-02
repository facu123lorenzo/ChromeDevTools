using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	///Protocol object for AudioNode

	/// </summary>
	[SupportedBy("Chrome")]
	public class AudioNode
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string NodeType { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double NumberOfInputs { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double NumberOfOutputs { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double ChannelCount { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ChannelCountMode ChannelCountMode { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ChannelInterpretation ChannelInterpretation { get; set; }
	}
}
