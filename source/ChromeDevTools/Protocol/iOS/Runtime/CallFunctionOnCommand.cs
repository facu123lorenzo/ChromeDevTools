using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	///Calls function with given declaration on the given object. Object group of the result is inherited from the target object.

	/// </summary>
	[Command(ProtocolName.Runtime.CallFunctionOn)]
	[SupportedBy("iOS")]
	public class CallFunctionOnCommand: ICommand<CallFunctionOnCommandResponse>
	{
		/// <summary>
		/// Gets or setsIdentifier of the object to call function on.

		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or setsDeclaration of the function to call.

		/// </summary>
		public string FunctionDeclaration { get; set; }
		/// <summary>
		/// Gets or setsCall arguments. All call arguments must belong to the same JavaScript world as the target object.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallArgument[] Arguments { get; set; }
		/// <summary>
		/// Gets or setsSpecifies whether function call should stop on exceptions and mute console. Overrides setPauseOnException state.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DoNotPauseOnExceptionsAndMuteConsole { get; set; }
		/// <summary>
		/// Gets or setsWhether the result is expected to be a JSON object which should be sent by value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Gets or setsWhether preview should be generated for the result.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
	}
}
