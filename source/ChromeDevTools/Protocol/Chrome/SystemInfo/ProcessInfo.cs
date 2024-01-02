using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	///Represents process info.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ProcessInfo
	{
		/// <summary>
		/// Gets or setsSpecifies process type.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsSpecifies process id.

		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or setsSpecifies cumulative CPU usage in seconds across all threads of the
		/// process since the process start.

		/// </summary>
		public double CpuTime { get; set; }
	}
}
