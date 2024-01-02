using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Description of an isolated world.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ExecutionContextDescription
	{
		/// <summary>
		/// Gets or setsUnique id of the execution context. It can be used to specify in which execution context
		/// script evaluation should be performed.

		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or setsExecution context origin.

		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or setsHuman readable name describing given context.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsA system-unique execution context identifier. Unlike the id, this is unique across
		/// multiple processes, so can be reliably used to identify specific context while backend
		/// performs a cross-process navigation.

		/// </summary>
		public string UniqueId { get; set; }
		/// <summary>
		/// Gets or setsEmbedder-specific auxiliary data likely matching {isDefault: boolean, type: 'default'|'isolated'|'worker', frameId: string}

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object AuxData { get; set; }
	}
}
