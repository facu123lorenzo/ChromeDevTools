using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Returns properties of a given object. Object group of the result is inherited from the target
	/// object.

	/// </summary>
	[Command(ProtocolName.Runtime.GetProperties)]
	[SupportedBy("Chrome")]
	public class GetPropertiesCommand: ICommand<GetPropertiesCommandResponse>
	{
		/// <summary>
		/// Gets or setsIdentifier of the object to return properties for.

		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or setsIf true, returns properties belonging only to the element itself, not to its prototype
		/// chain.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OwnProperties { get; set; }
		/// <summary>
		/// Gets or setsIf true, returns accessor properties (with getter/setter) only; internal properties are not
		/// returned either.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AccessorPropertiesOnly { get; set; }
		/// <summary>
		/// Gets or setsWhether preview should be generated for the results.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// Gets or setsIf true, returns non-indexed properties only.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? NonIndexedPropertiesOnly { get; set; }
	}
}
