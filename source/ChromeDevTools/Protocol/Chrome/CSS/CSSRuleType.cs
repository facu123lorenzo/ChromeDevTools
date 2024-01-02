using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS{
	/// <summary>
	///Enum indicating the type of a CSS rule, used to represent the order of a style rule's ancestors.
	/// This list only contains rule types that are collected during the ancestor rule collection.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CSSRuleType
	{
			MediaRule,
			SupportsRule,
			ContainerRule,
			LayerRule,
			ScopeRule,
			StyleRule,
	}
}
