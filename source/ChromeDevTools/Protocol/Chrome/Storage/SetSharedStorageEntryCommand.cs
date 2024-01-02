using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Sets entry with `key` and `value` for a given origin's shared storage.

	/// </summary>
	[Command(ProtocolName.Storage.SetSharedStorageEntry)]
	[SupportedBy("Chrome")]
	public class SetSharedStorageEntryCommand: ICommand<SetSharedStorageEntryCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsIf `ignoreIfPresent` is included and true, then only sets the entry if
		/// `key` doesn't already exist.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnoreIfPresent { get; set; }
	}
}
