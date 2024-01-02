using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Modifies the property rule property name.

	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetPropertyRulePropertyName)]
	[SupportedBy("Chrome")]
	public class SetPropertyRulePropertyNameCommandResponse
	{
		/// <summary>
		/// Gets or setsThe resulting key text after modification.

		/// </summary>
		public Value PropertyName { get; set; }
	}
}
