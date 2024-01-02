using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	///Requests data from object store or index.

	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestData)]
	[SupportedBy("iOS")]
	public class RequestDataCommand: ICommand<RequestDataCommandResponse>
	{
		/// <summary>
		/// Gets or setsSecurity origin.

		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or setsDatabase name.

		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or setsObject store name.

		/// </summary>
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Gets or setsIndex name, empty string for object store data requests.

		/// </summary>
		public string IndexName { get; set; }
		/// <summary>
		/// Gets or setsNumber of records to skip.

		/// </summary>
		public long SkipCount { get; set; }
		/// <summary>
		/// Gets or setsNumber of records to fetch.

		/// </summary>
		public long PageSize { get; set; }
		/// <summary>
		/// Gets or setsKey range.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public KeyRange KeyRange { get; set; }
	}
}
