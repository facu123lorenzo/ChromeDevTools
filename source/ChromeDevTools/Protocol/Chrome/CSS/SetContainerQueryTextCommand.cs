using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Modifies the expression of a container query.

	/// </summary>
	[Command(ProtocolName.CSS.SetContainerQueryText)]
	[SupportedBy("Chrome")]
	public class SetContainerQueryTextCommand: ICommand<SetContainerQueryTextCommandResponse>
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
		public string Text { get; set; }
	}
}
