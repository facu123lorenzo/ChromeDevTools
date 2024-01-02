using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Applies specified style edits one after another in the given order.

	/// </summary>
	[Command(ProtocolName.CSS.SetStyleTexts)]
	[SupportedBy("Chrome")]
	public class SetStyleTextsCommand: ICommand<SetStyleTextsCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StyleDeclarationEdit[] Edits { get; set; }
		/// <summary>
		/// Gets or setsNodeId for the DOM node in whose context custom property declarations for registered properties should be
		/// validated. If omitted, declarations in the new rule text can only be validated statically, which may produce
		/// incorrect results if the declaration contains a var() for example.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeForPropertySyntaxValidation { get; set; }
	}
}
