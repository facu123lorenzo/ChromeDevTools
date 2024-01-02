using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	///Searches for given string in script content.

	/// </summary>
	[Command(ProtocolName.Debugger.SearchInContent)]
	[SupportedBy("iOS")]
	public class SearchInContentCommand: ICommand<SearchInContentCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the script to search in.

		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or setsString to search for.

		/// </summary>
		public string Query { get; set; }
		/// <summary>
		/// Gets or setsIf true, search is case sensitive.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CaseSensitive { get; set; }
		/// <summary>
		/// Gets or setsIf true, treats string parameter as regex.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsRegex { get; set; }
	}
}
