using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Modifies the property rule property name.

	/// </summary>
	[Command(ProtocolName.CSS.SetPropertyRulePropertyName)]
	[SupportedBy("Chrome")]
	public class SetPropertyRulePropertyNameCommand: ICommand<SetPropertyRulePropertyNameCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string PropertyName { get; set; }
	}
}
