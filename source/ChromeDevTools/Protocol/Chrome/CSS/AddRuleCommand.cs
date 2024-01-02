using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Inserts a new rule with the given `ruleText` in a stylesheet with given `styleSheetId`, at the
	/// position specified by `location`.

	/// </summary>
	[Command(ProtocolName.CSS.AddRule)]
	[SupportedBy("Chrome")]
	public class AddRuleCommand: ICommand<AddRuleCommandResponse>
	{
		/// <summary>
		/// Gets or setsThe css style sheet identifier where a new rule should be inserted.

		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or setsThe text of a new rule.

		/// </summary>
		public string RuleText { get; set; }
		/// <summary>
		/// Gets or setsText position of a new rule in the target style sheet.

		/// </summary>
		public SourceRange Location { get; set; }
		/// <summary>
		/// Gets or setsNodeId for the DOM node in whose context custom property declarations for registered properties should be
		/// validated. If omitted, declarations in the new rule text can only be validated statically, which may produce
		/// incorrect results if the declaration contains a var() for example.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeForPropertySyntaxValidation { get; set; }
	}
}
