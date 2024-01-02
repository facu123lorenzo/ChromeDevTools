using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	///Heap profile sample.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingProfileNode
	{
		/// <summary>
		/// Gets or setsSize of the sampled allocation.

		/// </summary>
		public double Size { get; set; }
		/// <summary>
		/// Gets or setsTotal bytes attributed to this sample.

		/// </summary>
		public double Total { get; set; }
		/// <summary>
		/// Gets or setsExecution stack at the point of allocation.

		/// </summary>
		public string[] Stack { get; set; }
	}
}
