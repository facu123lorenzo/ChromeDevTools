using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Modifies the expression of a scope at-rule.

	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetScopeText)]
	[SupportedBy("Chrome")]
	public class SetScopeTextCommandResponse
	{
		/// <summary>
		/// Gets or setsThe resulting CSS Scope rule after modification.

		/// </summary>
		public CSSScope Scope { get; set; }
	}
}
