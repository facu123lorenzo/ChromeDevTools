using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill{
	/// <summary>
	///Specified whether a filled field was done so by using the html autocomplete attribute or autofill heuristics.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FillingStrategy
	{
			AutocompleteAttribute,
			AutofillInferred,
	}
}
