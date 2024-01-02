using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class InstallabilityErrorArgument
	{
		/// <summary>
		/// Gets or setsArgument name (e.g. name:'minimum-icon-size-in-pixels').

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsArgument value (e.g. value:'64').

		/// </summary>
		public string Value { get; set; }
	}
}
