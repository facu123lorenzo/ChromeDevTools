using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Media query expression descriptor.

	/// </summary>
	[SupportedBy("Chrome")]
	public class MediaQueryExpression
	{
		/// <summary>
		/// Gets or setsMedia query expression value.

		/// </summary>
		public double Value { get; set; }
		/// <summary>
		/// Gets or setsMedia query expression units.

		/// </summary>
		public string Unit { get; set; }
		/// <summary>
		/// Gets or setsMedia query expression feature.

		/// </summary>
		public string Feature { get; set; }
		/// <summary>
		/// Gets or setsThe associated range of the value text in the enclosing stylesheet (if available).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange ValueRange { get; set; }
		/// <summary>
		/// Gets or setsComputed length of media query expression (if applicable).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ComputedLength { get; set; }
	}
}
