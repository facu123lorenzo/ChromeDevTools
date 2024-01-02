using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///A descriptor of operation to mutate style declaration text.

	/// </summary>
	[SupportedBy("Chrome")]
	public class StyleDeclarationEdit
	{
		/// <summary>
		/// Gets or setsThe css style sheet identifier.

		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or setsThe range of the style text in the enclosing stylesheet.

		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or setsNew style text.

		/// </summary>
		public string Text { get; set; }
	}
}
