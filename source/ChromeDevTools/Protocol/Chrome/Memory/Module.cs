using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	///Executable module information

	/// </summary>
	[SupportedBy("Chrome")]
	public class Module
	{
		/// <summary>
		/// Gets or setsName of the module.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsUUID of the module.

		/// </summary>
		public string Uuid { get; set; }
		/// <summary>
		/// Gets or setsBase address where the module is loaded into memory. Encoded as a decimal
		/// or hexadecimal (0x prefixed) string.

		/// </summary>
		public string BaseAddress { get; set; }
		/// <summary>
		/// Gets or setsSize of the module in bytes.

		/// </summary>
		public double Size { get; set; }
	}
}