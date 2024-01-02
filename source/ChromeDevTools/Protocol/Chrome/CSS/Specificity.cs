using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Specificity:
	/// https://drafts.csswg.org/selectors/#specificity-rules

	/// </summary>
	[SupportedBy("Chrome")]
	public class Specificity
	{
		/// <summary>
		/// Gets or setsThe a component, which represents the number of ID selectors.

		/// </summary>
		public long A { get; set; }
		/// <summary>
		/// Gets or setsThe b component, which represents the number of class selectors, attributes selectors, and
		/// pseudo-classes.

		/// </summary>
		public long B { get; set; }
		/// <summary>
		/// Gets or setsThe c component, which represents the number of type selectors and pseudo-elements.

		/// </summary>
		public long C { get; set; }
	}
}
