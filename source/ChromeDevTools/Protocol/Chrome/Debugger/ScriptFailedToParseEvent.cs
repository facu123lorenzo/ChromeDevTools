using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	///Fired when virtual machine fails to parse the script.

	/// </summary>
	[Event(ProtocolName.Debugger.ScriptFailedToParse)]
	[SupportedBy("Chrome")]
	public class ScriptFailedToParseEvent
	{
		/// <summary>
		/// Gets or setsIdentifier of the script parsed.

		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or setsURL or name of the script parsed (if any).

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsLine offset of the script within the resource with given URL (for script tags).

		/// </summary>
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or setsColumn offset of the script within the resource with given URL.

		/// </summary>
		public long StartColumn { get; set; }
		/// <summary>
		/// Gets or setsLast line of the script.

		/// </summary>
		public long EndLine { get; set; }
		/// <summary>
		/// Gets or setsLength of the last line of the script.

		/// </summary>
		public long EndColumn { get; set; }
		/// <summary>
		/// Gets or setsSpecifies script creation context.

		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or setsContent hash of the script, SHA-256.

		/// </summary>
		public string Hash { get; set; }
		/// <summary>
		/// Gets or setsEmbedder-specific auxiliary data likely matching {isDefault: boolean, type: 'default'|'isolated'|'worker', frameId: string}

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object ExecutionContextAuxData { get; set; }
		/// <summary>
		/// Gets or setsURL of source map associated with script (if any).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceMapURL { get; set; }
		/// <summary>
		/// Gets or setsTrue, if this script has sourceURL.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasSourceURL { get; set; }
		/// <summary>
		/// Gets or setsTrue, if this script is ES6 module.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsModule { get; set; }
		/// <summary>
		/// Gets or setsThis script length.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Length { get; set; }
		/// <summary>
		/// Gets or setsJavaScript top stack frame of where the script parsed event was triggered if available.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace StackTrace { get; set; }
		/// <summary>
		/// Gets or setsIf the scriptLanguage is WebAssembly, the code section offset in the module.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? CodeOffset { get; set; }
		/// <summary>
		/// Gets or setsThe language of the script.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Debugger.ScriptLanguage ScriptLanguage { get; set; }
		/// <summary>
		/// Gets or setsThe name the embedder supplied for this script.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string EmbedderName { get; set; }
	}
}
