using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Navigation history entry.

	/// </summary>
	[SupportedBy("Chrome")]
	public class NavigationEntry
	{
		/// <summary>
		/// Gets or setsUnique id of the navigation history entry.

		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or setsURL of the navigation history entry.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsURL that the user typed in the url bar.

		/// </summary>
		public string UserTypedURL { get; set; }
		/// <summary>
		/// Gets or setsTitle of the navigation history entry.

		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or setsTransition type.

		/// </summary>
		public TransitionType TransitionType { get; set; }
	}
}
