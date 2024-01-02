using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Modifies the expression of a supports at-rule.

	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetSupportsText)]
	[SupportedBy("Chrome")]
	public class SetSupportsTextCommandResponse
	{
		/// <summary>
		/// Gets or setsThe resulting CSS Supports rule after modification.

		/// </summary>
		public CSSSupports Supports { get; set; }
	}
}
