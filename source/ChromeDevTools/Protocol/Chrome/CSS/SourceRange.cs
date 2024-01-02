using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Text range within a resource. All numbers are zero-based.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SourceRange
	{
		/// <summary>
		/// Gets or setsStart line of range.

		/// </summary>
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or setsStart column of range (inclusive).

		/// </summary>
		public long StartColumn { get; set; }
		/// <summary>
		/// Gets or setsEnd line of range

		/// </summary>
		public long EndLine { get; set; }
		/// <summary>
		/// Gets or setsEnd column of range (exclusive).

		/// </summary>
		public long EndColumn { get; set; }
	}
}
