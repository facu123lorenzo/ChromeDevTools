using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Calls function with given declaration on the given object. Object group of the result is
	/// inherited from the target object.

	/// </summary>
	[Command(ProtocolName.Runtime.CallFunctionOn)]
	[SupportedBy("Chrome")]
	public class CallFunctionOnCommand: ICommand<CallFunctionOnCommandResponse>
	{
		/// <summary>
		/// Gets or setsDeclaration of the function to call.

		/// </summary>
		public string FunctionDeclaration { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the object to call function on. Either objectId or executionContextId should
		/// be specified.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or setsCall arguments. All call arguments must belong to the same JavaScript world as the target
		/// object.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallArgument[] Arguments { get; set; }
		/// <summary>
		/// Gets or setsIn silent mode exceptions thrown during evaluation are not reported and do not pause
		/// execution. Overrides `setPauseOnException` state.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Silent { get; set; }
		/// <summary>
		/// Gets or setsWhether the result is expected to be a JSON object which should be sent by value.
		/// Can be overriden by `serializationOptions`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Gets or setsWhether preview should be generated for the result.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// Gets or setsWhether execution should be treated as initiated by user in the UI.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? UserGesture { get; set; }
		/// <summary>
		/// Gets or setsWhether execution should `await` for resulting value and return once awaited promise is
		/// resolved.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AwaitPromise { get; set; }
		/// <summary>
		/// Gets or setsSpecifies execution context which global object will be used to call function on. Either
		/// executionContextId or objectId should be specified.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or setsSymbolic group name that can be used to release multiple objects. If objectGroup is not
		/// specified and objectId is, objectGroup will be inherited from object.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or setsWhether to throw an exception if side effect cannot be ruled out during evaluation.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ThrowOnSideEffect { get; set; }
		/// <summary>
		/// Gets or setsAn alternative way to specify the execution context to call function on.
		/// Compared to contextId that may be reused across processes, this is guaranteed to be
		/// system-unique, so it can be used to prevent accidental function call
		/// in context different than intended (e.g. as a result of navigation across process
		/// boundaries).
		/// This is mutually exclusive with `executionContextId`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UniqueContextId { get; set; }
		/// <summary>
		/// Gets or setsSpecifies the result serialization. If provided, overrides
		/// `generatePreview` and `returnByValue`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SerializationOptions SerializationOptions { get; set; }
	}
}
