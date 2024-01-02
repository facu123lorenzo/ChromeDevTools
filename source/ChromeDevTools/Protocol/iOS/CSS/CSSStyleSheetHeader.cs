using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///CSS stylesheet metainformation.

	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyleSheetHeader
	{
		/// <summary>
		/// Gets or setsThe stylesheet identifier.

		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or setsOwner frame identifier.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsStylesheet resource URL.

		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or setsStylesheet origin.

		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or setsStylesheet title.

		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or setsDenotes whether the stylesheet is disabled.

		/// </summary>
		public bool Disabled { get; set; }
		/// <summary>
		/// Gets or setsWhether this stylesheet is a <style> tag created by the parser. This is not set for document.written <style> tags.

		/// </summary>
		public bool IsInline { get; set; }
		/// <summary>
		/// Gets or setsLine offset of the stylesheet within the resource (zero based).

		/// </summary>
		public double StartLine { get; set; }
		/// <summary>
		/// Gets or setsColumn offset of the stylesheet within the resource (zero based).

		/// </summary>
		public double StartColumn { get; set; }
	}
}
