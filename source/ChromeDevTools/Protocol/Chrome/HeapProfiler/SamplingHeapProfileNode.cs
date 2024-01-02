using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	///Sampling Heap Profile node. Holds callsite information, allocation statistics and child nodes.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingHeapProfileNode
	{
		/// <summary>
		/// Gets or setsFunction location.

		/// </summary>
		public Runtime.CallFrame CallFrame { get; set; }
		/// <summary>
		/// Gets or setsAllocations size in bytes for the node excluding children.

		/// </summary>
		public double SelfSize { get; set; }
		/// <summary>
		/// Gets or setsNode id. Ids are unique across all profiles collected between startSampling and stopSampling.

		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or setsChild nodes.

		/// </summary>
		public SamplingHeapProfileNode[] Children { get; set; }
	}
}
